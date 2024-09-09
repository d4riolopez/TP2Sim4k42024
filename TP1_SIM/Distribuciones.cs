using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet.Numerics.Distributions;

namespace TP2_SIM
{
    public partial class Distribuciones : Form
    {
        private int cantidadIntervalos { get; set; }
        public Distribuciones()
        {
            InitializeComponent();
        }

        private void Distribuciones_Load(object sender, EventArgs e)
        {
            this.CargarCombo();
        }

        // Carga el combo de Intervalos con los valores
        private void CargarCombo()
        {
            this.cmb_intervalos.Items.Add("5");
            this.cmb_intervalos.Items.Add("10");
            this.cmb_intervalos.Items.Add("15");
            this.cmb_intervalos.Items.Add("20");
            this.cmb_intervalos.Items.Add("25");
        }
        private void cmb_intervalos_SelectedIndexChanged(object sender, EventArgs e)
        {
            cantidadIntervalos = Int16.Parse(this.cmb_intervalos.Text);
        }

        #region Parametros Exponencial
        private void txt_exponencial_media_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (this.txt_exponencial_media.Text != "" && this.txt_exponencial_media.Text != "0" && this.txt_exponencial_media.Text != "0,")
                {
                    decimal media = decimal.Parse(this.txt_exponencial_media.Text);
                    if (media == 0)
                    {
                        this.txt_exponencial_frecuencia.Text = "";
                    }
                    else
                    {
                        decimal aux = Decimal.Divide(1, media);
                        this.txt_exponencial_frecuencia.Text = (Math.Truncate(aux * 100000) / 100000).ToString();
                    }
                }
                else
                {
                    this.txt_exponencial_frecuencia.Text = "0";
                }
            }
            catch (Exception)
            {
                this.txt_exponencial_frecuencia.Text = "0";
            }
        }

        private void txt_exponencial_frecuencia_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (this.txt_exponencial_frecuencia.Text != "" && this.txt_exponencial_frecuencia.Text != "0" && this.txt_exponencial_frecuencia.Text != "0,")
                {
                    decimal media = decimal.Parse(this.txt_exponencial_frecuencia.Text);
                    if (media == 0)
                    {
                        this.txt_exponencial_media.Text = "";
                    }
                    else
                    {
                        decimal aux = Decimal.Divide(1, media);
                        this.txt_exponencial_media.Text = (Math.Truncate(aux * 100000) / 100000).ToString();
                    }
                }
                else
                {
                    this.txt_exponencial_media.Text = "0";
                }
            }
            catch (Exception)
            {
                this.txt_exponencial_media.Text = "0";
            }
        }

        #endregion

        #region RadioButton
        private void rb_uniforme_CheckedChanged(object sender, EventArgs e)
        {
            this.grp_normal.Visible = false;
            this.grp_exponencial.Visible = false;
            this.grp_uniformeAB.Visible = true;
            this.panel_resultado.Visible = false;
        }

        private void rb_normal_CheckedChanged(object sender, EventArgs e)
        {
            this.grp_normal.Visible = true;
            this.grp_exponencial.Visible = false;
            this.panel_resultado.Visible = false;
            this.grp_uniformeAB.Visible = false;
        }

        private void rb_exponencial_CheckedChanged(object sender, EventArgs e)
        {
            this.grp_normal.Visible = false;
            this.grp_exponencial.Visible = true;
            this.panel_resultado.Visible = false;
            this.grp_uniformeAB.Visible = false;
        }

        #endregion

        #region Validaciones Simulaciones
        private bool ValidarSimular()
        {
            if(this.txt_muestra.Text == "")
            {
                MessageBox.Show("Debe cargar una muestra");
                return false;
            }
            if(this.txt_desde.Text == "" || this.txt_hasta.Text == "")
            {
                MessageBox.Show("Debe cargar unos límites");
                return false;
            }
            if(cantidadIntervalos == 0)
            {
                MessageBox.Show("Debe cargar un intervalo");
                return false;
            }
            if (this.rb_uniforme.Checked == true)
            {
                if (this.txt_uniforme_inferior.Text == "" || this.txt_uniforme_superior.Text == "")
                {
                    MessageBox.Show("Debe cargar los datos de la uniforme");
                    return false;
                }
                try
                {
                    double desde = double.Parse(this.txt_uniforme_inferior.Text);
                    double hasta = double.Parse(this.txt_uniforme_superior.Text);
                    if(desde > hasta)
                    {
                        double aux = desde; desde = hasta; hasta = aux;
                        this.txt_uniforme_superior.Text = hasta.ToString();
                        this.txt_uniforme_inferior.Text = desde.ToString();
                    }
                    if(desde == hasta)
                    {
                        MessageBox.Show("Los extremos no pueden ser iguales");
                        return false;
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Error al validar las variables");
                    return false;
                }
            }
            else if (this.rb_normal.Checked == true)
            {
                if (this.txt_normal_desviacion.Text == "" || this.txt_normal_media.Text == "")
                {
                    MessageBox.Show("Debe cargar los datos de la normal");
                    return false;
                }
            }
            else if (this.rb_exponencial.Checked == true)
            {
                if (this.txt_exponencial_frecuencia.Text == "" || this.txt_exponencial_media.Text == "")
                {
                    MessageBox.Show("Debe cargar los datos de la exponencial negativa");
                    return false;
                }
            }
            return true;
        }

        private void btn_simular_Click(object sender, EventArgs e)
        {
            this.panel_resultado.Visible = false;
            if (!ValidarSimular())
                return;
            long tamañoMuestra; long desde; long hasta; int cantidadIntervalos;
            tamañoMuestra = long.Parse(this.txt_muestra.Text);
            desde = long.Parse(this.txt_desde.Text);
            hasta = long.Parse(this.txt_hasta.Text);
            cantidadIntervalos = this.cantidadIntervalos;



            if (this.rb_uniforme.Checked == true) {
                double limiteInferior = double.Parse(this.txt_uniforme_inferior.Text);
                double limiteSuperior = double.Parse(this.txt_uniforme_superior.Text);
                GenerarNumerosUniformes(tamañoMuestra, desde, hasta, cantidadIntervalos, limiteInferior, limiteSuperior);
            } else if (this.rb_normal.Checked == true) {
                double media = double.Parse(this.txt_normal_media.Text);
                double desviacion = double.Parse(this.txt_normal_desviacion.Text);
                GenerarNumerosNormales(tamañoMuestra, desde, hasta, cantidadIntervalos, media, desviacion);
            } else if (this.rb_exponencial.Checked == true) {
                double lambda = double.Parse(this.txt_exponencial_frecuencia.Text);
                GenerarNumerosExponenciales(tamañoMuestra, desde, hasta, cantidadIntervalos, lambda);
            }
        }
        #endregion

        #region Generadores

        #region Generador Uniforme
        private void GenerarNumerosUniformes(long tamañoMuestra, long desde, long hasta, long cantidadIntervalos, double limiteInferior, double limiteSuperior)
        {
            Random random = new Random();
            double x = 0;
            List<double> numerosGenerados = new List<double>();
            this.grid_resultados.Rows.Clear();
            double max = 0; double min = 0;
            for (int i = 0; i < tamañoMuestra; i++)
            {
                double nroRandom = TruncarACuatro(random.NextDouble());
                x = generarVariableUniforme(nroRandom, limiteInferior, limiteSuperior);
                numerosGenerados.Add(x);

                if (i == 0)
                {
                    max = x;
                    min = x;
                }
                if (x > max)
                    max = x;
                if (x < min)
                    min = x;

                if (i >= desde && i <= hasta)
                {
                    int j = this.grid_resultados.Rows.Add();
                    this.grid_resultados.Rows[j].Cells[0].Value = i;
                    this.grid_resultados.Rows[j].Cells[1].Value = x;
                }
            }
            AnalizarGenerador(numerosGenerados, cantidadIntervalos, DistribucionEnum.UNIFORME, max, min, tamañoMuestra);
        }
        private double generarVariableUniforme(double nroRandom, double limiteInf, double limiteSup)
        {
            //Genera numero uniforme [a,b] con random uniforme [0,1]
            // x = A + RND ( B - A )
            return TruncarACuatro(limiteInf + (nroRandom * (limiteSup - limiteInf)));
        }

        #endregion

        #region Generador Normal
        private void GenerarNumerosNormales(long tamañoMuestra, long desde, long hasta, long cantidadIntervalos, double media, double desviacion)
        {
            Random random = new Random();
            List<double> numerosGenerados = new List<double>();
            double[] xi = new double[2];
            double x = 0;
            double max = 0; double min = 0;
            this.grid_resultados.Rows.Clear();
            for (int i = 0; i < tamañoMuestra; i++)
            {
                if(i % 2 == 0)
                {
                    //si es par, tengo que generar 2 nuevos numeros
                    double nroRandom1 = TruncarACuatro(random.NextDouble());
                    double nroRandom2 = TruncarACuatro(random.NextDouble());
                    xi = generarVariableNormal(nroRandom1, nroRandom2, media, desviacion);
                    x = xi[0];
                } else //si es impar, tengo que usar el numero anterior generado
                {
                    x = xi[1];
                }
                if (i == 0)
                {
                    max = x;
                    min = x;
                }

                if (x > max)
                    max = x;
                if (x < min)
                    min = x;

                numerosGenerados.Add(x);

                if (i >= desde && i <= hasta)
                {
                    int j = this.grid_resultados.Rows.Add();
                    this.grid_resultados.Rows[j].Cells[0].Value = i;
                    this.grid_resultados.Rows[j].Cells[1].Value = x;
                }
            }
            AnalizarGenerador(numerosGenerados, cantidadIntervalos, DistribucionEnum.NORMAL, max, min, tamañoMuestra);
        }
        private double[] generarVariableNormal(double nroRandom1, double nroRandom2, double media, double desviacion)
        {
            //Genera numero normal con random uniforme [0,1]
            double[] numerosGenerados = new double[2];
            numerosGenerados[0] = TruncarACuatro(((Math.Sqrt(-2 * Math.Log(1 - nroRandom1)) * Math.Cos(2 * Math.PI * nroRandom2)) * desviacion) + media);
            numerosGenerados[1] = TruncarACuatro(((Math.Sqrt(-2 * Math.Log(1 - nroRandom1)) * Math.Sin(2 * Math.PI * nroRandom2)) * desviacion) + media);
            return numerosGenerados;
        }

        #endregion

        #region Generador Exponencial 
        private void GenerarNumerosExponenciales(long tamañoMuestra, long desde, long hasta, long cantidadIntervalos, double lambda)
        {
            Random random = new Random();
            List<double> numerosGenerados = new List<double>();
            double x = 0;
            this.grid_resultados.Rows.Clear();
            double max = 0; double min = 0;
            for (int i = 0; i < tamañoMuestra; i++)
            {
                double nroRandom = TruncarACuatro(random.NextDouble());
                x = generarVariableExponencial(nroRandom, lambda);
                numerosGenerados.Add(x);

                if (i == 0)
                {
                    max = x;
                    min = x;
                }

                if (x > max)
                    max = x;
                if (x < min)
                    min = x;

                if (i >= desde && i <= hasta)
                {
                    int j = this.grid_resultados.Rows.Add();
                    this.grid_resultados.Rows[j].Cells[0].Value = i;
                    this.grid_resultados.Rows[j].Cells[1].Value = x;
                }
            }
            AnalizarGenerador(numerosGenerados, cantidadIntervalos, DistribucionEnum.EXPONENCIAL, max, min, tamañoMuestra);
        }
        private double generarVariableExponencial(double nroRandom, double lambda)
        {
            //Genera numero exponencial con random uniforme [0,1]
            // x = -1/λ * Ln(1 - RND)
            return this.TruncarACuatro(Math.Log(1 - nroRandom) / (-lambda));
        }

        #endregion

        #endregion

        private void AnalizarGenerador(List<double> lista, long cantidadIntervalos, DistribucionEnum distribucion, double max, double min, long tamañoMuestra)
        {
            int[] acumulador = new int[cantidadIntervalos]; //array de frecuencias observadas
            double[] limites = new double[cantidadIntervalos * 2];

            //Obtener los intervalos de la lista generada
            double salto = (double)(max-min) / cantidadIntervalos;
            for (int i = 0; i < limites.Length; i++)
            {
                if (i == 0)
                {
                    limites[i] = min;
                    continue;
                }
                if (i % 2 == 1)
                {
                    limites[i] = limites[i - 1] + salto;
                }
                else
                {
                    limites[i] = limites[i - 1];
                }
            }
            limites[limites.Count() - 1] = max+0.0001;

            //Encuentra la frecuencia observada en cada intervalo
            foreach (double random in lista)
            {
                for (int i = 0; i < limites.Length; i += 2)
                {
                    if(random >= limites[i] && random < limites[i + 1])
                    {
                        acumulador[i / 2] += 1;
                        break;
                    }
                }
            }

            //Carga el grafico en el chart
            this.chart_resultado.Series["Fo"].Points.Clear();
            for (int i = 0; i < limites.Length; i+= 2)
            {
                this.chart_resultado.Series["Fo"].Points.AddXY($"{Math.Truncate(limites[i]*10000)/10000}-{Math.Truncate(limites[i+1] * 10000) / 10000}", acumulador[i / 2]);
            }

            //Generar Frecuencias esperadas
            double[] frecuenciasEsperadas = ObtenerFrecuenciasEsperada(distribucion, max, min, cantidadIntervalos, tamañoMuestra, limites);

            //Carga la grilla analisis
            this.grid_analisis.Rows.Clear();
            double valorAnterior = 0; double valorActual;
            for (int i = 0; i < limites.Length; i+= 2)
            {
                this.grid_analisis.Rows.Add();
                this.grid_analisis.Rows[i / 2].Cells[0].Value = $"{Math.Truncate(limites[i] * 10000) / 10000}-{Math.Truncate(limites[i + 1] * 10000) / 10000}";
                this.grid_analisis.Rows[i / 2].Cells[1].Value = acumulador[i / 2];
                this.grid_analisis.Rows[i / 2].Cells[2].Value = frecuenciasEsperadas[i / 2];
                this.grid_analisis.Rows[i / 2].Cells[3].Value = Math.Pow(acumulador[i / 2] - frecuenciasEsperadas[i / 2], 2) / frecuenciasEsperadas[i / 2];
                if (i == 0)
                {
                    valorAnterior = Convert.ToDouble(this.grid_analisis.Rows[0].Cells[3].Value.ToString());
                    this.grid_analisis.Rows[0].Cells[4].Value = $"{valorAnterior}";
                }
                else
                {
                    valorActual = Double.Parse(this.grid_analisis.Rows[i / 2].Cells[3].Value.ToString());
                    this.grid_analisis.Rows[i / 2].Cells[4].Value = $"{valorActual + valorAnterior}";
                    valorAnterior = valorActual + valorAnterior;
                }
            }

            this.panel_resultado.Visible = true;
        }

        private double[] ObtenerFrecuenciasEsperada(DistribucionEnum distribucion, double max, double min, long cantidadIntervalos, double tamañoMuestra, double[] limites)
        {
            double[] frecuenciasEsperadas = new double[cantidadIntervalos];
            double rango = max - min;
            switch (distribucion)
            {
                case DistribucionEnum.UNIFORME:
                    double fe = tamañoMuestra / cantidadIntervalos;
                    for (int i = 0; i < cantidadIntervalos; i++)
                    {
                        frecuenciasEsperadas[i] = TruncarACuatro(fe);
                    }
                    break;
                case DistribucionEnum.EXPONENCIAL:
                    double lambda = double.Parse(this.txt_exponencial_frecuencia.Text);
                    for (int i = 0; i < limites.Length; i+= 2)
                    {
                        double acumuladoSuperior = 1 - Math.Exp(lambda * limites[i + 1] * -1);
                        double acumuladoInferior = 1 - Math.Exp(lambda * limites[i] * -1);
                        frecuenciasEsperadas[i/2] = TruncarACuatro((acumuladoSuperior - acumuladoInferior) * tamañoMuestra);
                    }
                    break;
                case DistribucionEnum.NORMAL:
                    double desviacion = double.Parse(this.txt_normal_desviacion.Text);
                    double media = double.Parse(this.txt_normal_media.Text);
                    for (int i = 0; i < limites.Length; i += 2)
                    {
                        double marcaClase = (limites[i + 1] + limites[i]) / 2;
                        double anchoIntervalo = limites[i + 1] - limites[i];
                        double primerTermino = 1 / (desviacion * Math.Sqrt(2 * Math.PI));
                        double segundoTermino = Math.Exp(-0.5 * Math.Pow(((marcaClase-media)/desviacion),2));
                        frecuenciasEsperadas[i/2] = TruncarACuatro(primerTermino * segundoTermino * anchoIntervalo * tamañoMuestra);
                    }
                    break;
                default:
                    break;
            }
            return frecuenciasEsperadas;
        }



        private double TruncarACuatro(double nro)
        {
            return Math.Truncate(nro * 10000) / 10000;
        }

        private double ObtenerJiTabulado(double gradosLibertad, double nivelSignificancia)
        {
            ChiSquared c = new ChiSquared(gradosLibertad);

            return c.InverseCumulativeDistribution(nivelSignificancia);
        }


    }

    public enum DistribucionEnum
    {
        UNIFORME = 1,
        EXPONENCIAL = 2,
        NORMAL = 3,
    }
}

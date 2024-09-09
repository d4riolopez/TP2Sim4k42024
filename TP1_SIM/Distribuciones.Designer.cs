
namespace TP2_SIM
{
    partial class Distribuciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grid_resultados = new System.Windows.Forms.DataGridView();
            this.i = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.random = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_simular = new System.Windows.Forms.Button();
            this.txt_hasta = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_desde = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_muestra = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_intervalos = new System.Windows.Forms.ComboBox();
            this.rb_lenguaje = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_exponencial = new System.Windows.Forms.RadioButton();
            this.rb_normal = new System.Windows.Forms.RadioButton();
            this.rb_uniforme = new System.Windows.Forms.RadioButton();
            this.grp_uniformeAB = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_uniforme_superior = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_uniforme_inferior = new System.Windows.Forms.TextBox();
            this.grp_normal = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_normal_desviacion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_normal_media = new System.Windows.Forms.TextBox();
            this.grp_exponencial = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_exponencial_media = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_exponencial_frecuencia = new System.Windows.Forms.TextBox();
            this.panel_resultado = new System.Windows.Forms.FlowLayoutPanel();
            this.grid_analisis = new System.Windows.Forms.DataGridView();
            this.intervalo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cacum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chart_resultado = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_resultados)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grp_uniformeAB.SuspendLayout();
            this.grp_normal.SuspendLayout();
            this.grp_exponencial.SuspendLayout();
            this.panel_resultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_analisis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_resultado)).BeginInit();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(254, 742);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(162, 16);
            this.label14.TabIndex = 26;
            this.label14.Text = "Montini, Sebastian - 76630";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(52, 742);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "Floreano, Micaela - 72276";
            // 
            // grid_resultados
            // 
            this.grid_resultados.AllowUserToAddRows = false;
            this.grid_resultados.AllowUserToDeleteRows = false;
            this.grid_resultados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_resultados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_resultados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.grid_resultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_resultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.i,
            this.random});
            this.grid_resultados.Location = new System.Drawing.Point(853, 152);
            this.grid_resultados.Name = "grid_resultados";
            this.grid_resultados.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_resultados.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.grid_resultados.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.grid_resultados.RowTemplate.Height = 25;
            this.grid_resultados.Size = new System.Drawing.Size(239, 449);
            this.grid_resultados.TabIndex = 22;
            // 
            // i
            // 
            this.i.FillWeight = 50.76142F;
            this.i.HeaderText = "i";
            this.i.Name = "i";
            this.i.ReadOnly = true;
            // 
            // random
            // 
            this.random.FillWeight = 149.2386F;
            this.random.HeaderText = "Numero aleatorio";
            this.random.Name = "random";
            this.random.ReadOnly = true;
            // 
            // btn_simular
            // 
            this.btn_simular.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_simular.BackColor = System.Drawing.Color.Transparent;
            this.btn_simular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_simular.Location = new System.Drawing.Point(924, 65);
            this.btn_simular.Name = "btn_simular";
            this.btn_simular.Size = new System.Drawing.Size(140, 26);
            this.btn_simular.TabIndex = 20;
            this.btn_simular.Text = "Simular";
            this.btn_simular.UseVisualStyleBackColor = false;
            this.btn_simular.Click += new System.EventHandler(this.btn_simular_Click);
            // 
            // txt_hasta
            // 
            this.txt_hasta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.txt_hasta.ForeColor = System.Drawing.SystemColors.Info;
            this.txt_hasta.Location = new System.Drawing.Point(216, 100);
            this.txt_hasta.Mask = "999999999999";
            this.txt_hasta.Name = "txt_hasta";
            this.txt_hasta.Size = new System.Drawing.Size(109, 20);
            this.txt_hasta.TabIndex = 24;
            this.txt_hasta.Text = "2";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(213, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Hasta:";
            // 
            // txt_desde
            // 
            this.txt_desde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.txt_desde.ForeColor = System.Drawing.SystemColors.Info;
            this.txt_desde.Location = new System.Drawing.Point(77, 100);
            this.txt_desde.Mask = "999999999999";
            this.txt_desde.Name = "txt_desde";
            this.txt_desde.Size = new System.Drawing.Size(109, 20);
            this.txt_desde.TabIndex = 23;
            this.txt_desde.Text = "1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(74, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Desde:";
            // 
            // txt_muestra
            // 
            this.txt_muestra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.txt_muestra.ForeColor = System.Drawing.SystemColors.Info;
            this.txt_muestra.Location = new System.Drawing.Point(76, 49);
            this.txt_muestra.Mask = "999999999999";
            this.txt_muestra.Name = "txt_muestra";
            this.txt_muestra.Size = new System.Drawing.Size(109, 20);
            this.txt_muestra.TabIndex = 21;
            this.txt_muestra.Text = "10000";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(72, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Tamaño de la muestra:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(213, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Cantidad de intervalos:";
            // 
            // cmb_intervalos
            // 
            this.cmb_intervalos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.cmb_intervalos.ForeColor = System.Drawing.SystemColors.Info;
            this.cmb_intervalos.FormattingEnabled = true;
            this.cmb_intervalos.Location = new System.Drawing.Point(215, 47);
            this.cmb_intervalos.Name = "cmb_intervalos";
            this.cmb_intervalos.Size = new System.Drawing.Size(110, 21);
            this.cmb_intervalos.TabIndex = 19;
            this.cmb_intervalos.SelectedIndexChanged += new System.EventHandler(this.cmb_intervalos_SelectedIndexChanged);
            // 
            // rb_lenguaje
            // 
            this.rb_lenguaje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rb_lenguaje.AutoSize = true;
            this.rb_lenguaje.BackColor = System.Drawing.Color.Transparent;
            this.rb_lenguaje.Location = new System.Drawing.Point(923, -18);
            this.rb_lenguaje.Name = "rb_lenguaje";
            this.rb_lenguaje.Size = new System.Drawing.Size(135, 17);
            this.rb_lenguaje.TabIndex = 14;
            this.rb_lenguaje.Text = "Generador del lenguaje";
            this.rb_lenguaje.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_exponencial);
            this.groupBox1.Controls.Add(this.rb_normal);
            this.groupBox1.Controls.Add(this.rb_uniforme);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(361, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(120, 100);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Distribuciones";
            // 
            // rb_exponencial
            // 
            this.rb_exponencial.AutoSize = true;
            this.rb_exponencial.Location = new System.Drawing.Point(16, 65);
            this.rb_exponencial.Name = "rb_exponencial";
            this.rb_exponencial.Size = new System.Drawing.Size(83, 17);
            this.rb_exponencial.TabIndex = 2;
            this.rb_exponencial.Text = "Exponencial";
            this.rb_exponencial.UseVisualStyleBackColor = true;
            this.rb_exponencial.CheckedChanged += new System.EventHandler(this.rb_exponencial_CheckedChanged);
            // 
            // rb_normal
            // 
            this.rb_normal.AutoSize = true;
            this.rb_normal.Location = new System.Drawing.Point(16, 43);
            this.rb_normal.Name = "rb_normal";
            this.rb_normal.Size = new System.Drawing.Size(58, 17);
            this.rb_normal.TabIndex = 1;
            this.rb_normal.Text = "Normal";
            this.rb_normal.UseVisualStyleBackColor = true;
            this.rb_normal.CheckedChanged += new System.EventHandler(this.rb_normal_CheckedChanged);
            // 
            // rb_uniforme
            // 
            this.rb_uniforme.AutoSize = true;
            this.rb_uniforme.Checked = true;
            this.rb_uniforme.Location = new System.Drawing.Point(16, 20);
            this.rb_uniforme.Name = "rb_uniforme";
            this.rb_uniforme.Size = new System.Drawing.Size(91, 17);
            this.rb_uniforme.TabIndex = 0;
            this.rb_uniforme.TabStop = true;
            this.rb_uniforme.Text = "Uniforme [a,b]";
            this.rb_uniforme.UseVisualStyleBackColor = true;
            this.rb_uniforme.CheckedChanged += new System.EventHandler(this.rb_uniforme_CheckedChanged);
            // 
            // grp_uniformeAB
            // 
            this.grp_uniformeAB.Controls.Add(this.label2);
            this.grp_uniformeAB.Controls.Add(this.txt_uniforme_superior);
            this.grp_uniformeAB.Controls.Add(this.label1);
            this.grp_uniformeAB.Controls.Add(this.txt_uniforme_inferior);
            this.grp_uniformeAB.ForeColor = System.Drawing.SystemColors.Control;
            this.grp_uniformeAB.Location = new System.Drawing.Point(505, 46);
            this.grp_uniformeAB.Name = "grp_uniformeAB";
            this.grp_uniformeAB.Size = new System.Drawing.Size(231, 100);
            this.grp_uniformeAB.TabIndex = 28;
            this.grp_uniformeAB.TabStop = false;
            this.grp_uniformeAB.Text = "Parametros Uniforme [a,b]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Superior (b):";
            // 
            // txt_uniforme_superior
            // 
            this.txt_uniforme_superior.Location = new System.Drawing.Point(110, 46);
            this.txt_uniforme_superior.Name = "txt_uniforme_superior";
            this.txt_uniforme_superior.Size = new System.Drawing.Size(100, 20);
            this.txt_uniforme_superior.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inferior (a):";
            // 
            // txt_uniforme_inferior
            // 
            this.txt_uniforme_inferior.Location = new System.Drawing.Point(110, 20);
            this.txt_uniforme_inferior.Name = "txt_uniforme_inferior";
            this.txt_uniforme_inferior.Size = new System.Drawing.Size(100, 20);
            this.txt_uniforme_inferior.TabIndex = 0;
            // 
            // grp_normal
            // 
            this.grp_normal.Controls.Add(this.label3);
            this.grp_normal.Controls.Add(this.txt_normal_desviacion);
            this.grp_normal.Controls.Add(this.label4);
            this.grp_normal.Controls.Add(this.txt_normal_media);
            this.grp_normal.Location = new System.Drawing.Point(505, 27);
            this.grp_normal.Name = "grp_normal";
            this.grp_normal.Size = new System.Drawing.Size(231, 100);
            this.grp_normal.TabIndex = 29;
            this.grp_normal.TabStop = false;
            this.grp_normal.Text = "Parametros Normal";
            this.grp_normal.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Desv. Estandar:";
            // 
            // txt_normal_desviacion
            // 
            this.txt_normal_desviacion.Location = new System.Drawing.Point(110, 46);
            this.txt_normal_desviacion.Name = "txt_normal_desviacion";
            this.txt_normal_desviacion.Size = new System.Drawing.Size(100, 20);
            this.txt_normal_desviacion.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Media:";
            // 
            // txt_normal_media
            // 
            this.txt_normal_media.Location = new System.Drawing.Point(110, 20);
            this.txt_normal_media.Name = "txt_normal_media";
            this.txt_normal_media.Size = new System.Drawing.Size(100, 20);
            this.txt_normal_media.TabIndex = 0;
            // 
            // grp_exponencial
            // 
            this.grp_exponencial.Controls.Add(this.label7);
            this.grp_exponencial.Controls.Add(this.txt_exponencial_media);
            this.grp_exponencial.Controls.Add(this.label8);
            this.grp_exponencial.Controls.Add(this.txt_exponencial_frecuencia);
            this.grp_exponencial.ForeColor = System.Drawing.SystemColors.Control;
            this.grp_exponencial.Location = new System.Drawing.Point(505, 27);
            this.grp_exponencial.Name = "grp_exponencial";
            this.grp_exponencial.Size = new System.Drawing.Size(231, 100);
            this.grp_exponencial.TabIndex = 29;
            this.grp_exponencial.TabStop = false;
            this.grp_exponencial.Text = "Parametros Exponencial";
            this.grp_exponencial.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "media (µ = 1 / λ):";
            // 
            // txt_exponencial_media
            // 
            this.txt_exponencial_media.Location = new System.Drawing.Point(108, 20);
            this.txt_exponencial_media.Name = "txt_exponencial_media";
            this.txt_exponencial_media.Size = new System.Drawing.Size(100, 20);
            this.txt_exponencial_media.TabIndex = 2;
            this.txt_exponencial_media.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_exponencial_media_KeyUp);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = " frecuencia (λ):";
            // 
            // txt_exponencial_frecuencia
            // 
            this.txt_exponencial_frecuencia.Location = new System.Drawing.Point(108, 46);
            this.txt_exponencial_frecuencia.Name = "txt_exponencial_frecuencia";
            this.txt_exponencial_frecuencia.Size = new System.Drawing.Size(100, 20);
            this.txt_exponencial_frecuencia.TabIndex = 0;
            this.txt_exponencial_frecuencia.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_exponencial_frecuencia_KeyUp);
            // 
            // panel_resultado
            // 
            this.panel_resultado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_resultado.Controls.Add(this.grid_analisis);
            this.panel_resultado.Controls.Add(this.chart_resultado);
            this.panel_resultado.Location = new System.Drawing.Point(43, 152);
            this.panel_resultado.Name = "panel_resultado";
            this.panel_resultado.Size = new System.Drawing.Size(801, 575);
            this.panel_resultado.TabIndex = 31;
            this.panel_resultado.Visible = false;
            // 
            // grid_analisis
            // 
            this.grid_analisis.AllowUserToAddRows = false;
            this.grid_analisis.AllowUserToDeleteRows = false;
            this.grid_analisis.AllowUserToOrderColumns = true;
            this.grid_analisis.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.grid_analisis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_analisis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.intervalo,
            this.fo,
            this.fe,
            this.c,
            this.cacum});
            this.grid_analisis.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grid_analisis.Location = new System.Drawing.Point(3, 3);
            this.grid_analisis.Name = "grid_analisis";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_analisis.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.grid_analisis.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grid_analisis.Size = new System.Drawing.Size(569, 192);
            this.grid_analisis.TabIndex = 1;
            // 
            // intervalo
            // 
            this.intervalo.HeaderText = "Intervalo";
            this.intervalo.Name = "intervalo";
            // 
            // fo
            // 
            this.fo.HeaderText = "Fo";
            this.fo.Name = "fo";
            // 
            // fe
            // 
            this.fe.HeaderText = "Fe";
            this.fe.Name = "fe";
            // 
            // c
            // 
            this.c.HeaderText = "C";
            this.c.Name = "c";
            // 
            // cacum
            // 
            this.cacum.HeaderText = "Cacum";
            this.cacum.Name = "cacum";
            // 
            // chart_resultado
            // 
            this.chart_resultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            chartArea1.Name = "ChartArea1";
            this.chart_resultado.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_resultado.Legends.Add(legend1);
            this.chart_resultado.Location = new System.Drawing.Point(3, 201);
            this.chart_resultado.Name = "chart_resultado";
            this.chart_resultado.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Fo";
            this.chart_resultado.Series.Add(series1);
            this.chart_resultado.Size = new System.Drawing.Size(801, 374);
            this.chart_resultado.TabIndex = 0;
            this.chart_resultado.Text = "chart1";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(851, 693);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(167, 16);
            this.label16.TabIndex = 37;
            this.label16.Text = "94091 - Nadia Denis Elwart";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(851, 715);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(191, 16);
            this.label15.TabIndex = 36;
            this.label15.Text = "77461 - Emanuel Fabián Orona";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(851, 672);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(139, 16);
            this.label12.TabIndex = 35;
            this.label12.Text = "76822 - Lucas Niveyro";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(851, 647);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(143, 16);
            this.label13.TabIndex = 34;
            this.label13.Text = "70989 - Tomas Romeu";
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(850, 625);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(189, 16);
            this.label17.TabIndex = 33;
            this.label17.Text = "57837 - Gabriel Osmar Palacio";
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(851, 604);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(157, 16);
            this.label18.TabIndex = 32;
            this.label18.Text = "77033 - Juan Cruz Peralta";
            // 
            // Distribuciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(1104, 630);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.grid_resultados);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.grp_uniformeAB);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.panel_resultado);
            this.Controls.Add(this.grp_exponencial);
            this.Controls.Add(this.grp_normal);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_simular);
            this.Controls.Add(this.txt_hasta);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_desde);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_muestra);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmb_intervalos);
            this.Controls.Add(this.rb_lenguaje);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "Distribuciones";
            this.Text = "Distribuciones";
            this.Load += new System.EventHandler(this.Distribuciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_resultados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grp_uniformeAB.ResumeLayout(false);
            this.grp_uniformeAB.PerformLayout();
            this.grp_normal.ResumeLayout(false);
            this.grp_normal.PerformLayout();
            this.grp_exponencial.ResumeLayout(false);
            this.grp_exponencial.PerformLayout();
            this.panel_resultado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_analisis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_resultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView grid_resultados;
        private System.Windows.Forms.Button btn_simular;
        private System.Windows.Forms.MaskedTextBox txt_hasta;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox txt_desde;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox txt_muestra;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_intervalos;
        private System.Windows.Forms.RadioButton rb_lenguaje;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_exponencial;
        private System.Windows.Forms.RadioButton rb_normal;
        private System.Windows.Forms.RadioButton rb_uniforme;
        private System.Windows.Forms.GroupBox grp_uniformeAB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_uniforme_superior;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_uniforme_inferior;
        private System.Windows.Forms.GroupBox grp_normal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_normal_desviacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_normal_media;
        private System.Windows.Forms.GroupBox grp_exponencial;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_exponencial_media;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_exponencial_frecuencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn i;
        private System.Windows.Forms.DataGridViewTextBoxColumn random;
        private System.Windows.Forms.FlowLayoutPanel panel_resultado;
        private System.Windows.Forms.DataGridView grid_analisis;
        private System.Windows.Forms.DataGridViewTextBoxColumn intervalo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fe;
        private System.Windows.Forms.DataGridViewTextBoxColumn c;
        private System.Windows.Forms.DataGridViewTextBoxColumn cacum;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_resultado;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
    }
}
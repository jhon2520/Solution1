namespace Presentacion.FormsCarteras.Consumo
{
    partial class FormConsumo
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsumo));
            this.dgvPlanPagoComercial = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel15 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.tbxCuota = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.contadorTasa = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.contadorPlazo = new System.Windows.Forms.NumericUpDown();
            this.panel17 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.tbxMonto = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblCedula = new System.Windows.Forms.Label();
            this.tbxCedula = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnAnalisis = new System.Windows.Forms.Button();
            this.btnCalculadora = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSimulador = new System.Windows.Forms.Label();
            this.pnlCentro = new System.Windows.Forms.Panel();
            this.trancisionFormAnalisis = new BunifuAnimatorNS.BunifuTransition(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanPagoComercial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contadorTasa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contadorPlazo)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlCentro.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPlanPagoComercial
            // 
            this.dgvPlanPagoComercial.AllowUserToAddRows = false;
            this.dgvPlanPagoComercial.AllowUserToDeleteRows = false;
            this.dgvPlanPagoComercial.AllowUserToResizeColumns = false;
            this.dgvPlanPagoComercial.AllowUserToResizeRows = false;
            this.dgvPlanPagoComercial.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.dgvPlanPagoComercial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPlanPagoComercial.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPlanPagoComercial.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPlanPagoComercial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPlanPagoComercial.ColumnHeadersHeight = 30;
            this.dgvPlanPagoComercial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPlanPagoComercial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.trancisionFormAnalisis.SetDecoration(this.dgvPlanPagoComercial, BunifuAnimatorNS.DecorationType.None);
            this.dgvPlanPagoComercial.EnableHeadersVisualStyles = false;
            this.dgvPlanPagoComercial.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvPlanPagoComercial.Location = new System.Drawing.Point(18, 129);
            this.dgvPlanPagoComercial.Name = "dgvPlanPagoComercial";
            this.dgvPlanPagoComercial.ReadOnly = true;
            this.dgvPlanPagoComercial.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPlanPagoComercial.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPlanPagoComercial.RowHeadersVisible = false;
            this.dgvPlanPagoComercial.RowHeadersWidth = 62;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dgvPlanPagoComercial.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPlanPagoComercial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlanPagoComercial.Size = new System.Drawing.Size(720, 333);
            this.dgvPlanPagoComercial.TabIndex = 99;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Periodo";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Saldo Inicial";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 120;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Cuota";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 120;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Abono Interés";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 120;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Abono Capital";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 120;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Saldo Final";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 120;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.trancisionFormAnalisis.SetDecoration(this.panel15, BunifuAnimatorNS.DecorationType.None);
            this.panel15.Location = new System.Drawing.Point(314, 84);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(136, 1);
            this.panel15.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.trancisionFormAnalisis.SetDecoration(this.label10, BunifuAnimatorNS.DecorationType.None);
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(264, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 16);
            this.label10.TabIndex = 32;
            this.label10.Text = "Cuota";
            // 
            // tbxCuota
            // 
            this.tbxCuota.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxCuota.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.trancisionFormAnalisis.SetDecoration(this.tbxCuota, BunifuAnimatorNS.DecorationType.None);
            this.tbxCuota.Enabled = false;
            this.tbxCuota.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCuota.ForeColor = System.Drawing.Color.Gray;
            this.tbxCuota.Location = new System.Drawing.Point(316, 63);
            this.tbxCuota.Multiline = true;
            this.tbxCuota.Name = "tbxCuota";
            this.tbxCuota.Size = new System.Drawing.Size(136, 20);
            this.tbxCuota.TabIndex = 30;
            this.tbxCuota.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.trancisionFormAnalisis.SetDecoration(this.label9, BunifuAnimatorNS.DecorationType.None);
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(572, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 16);
            this.label9.TabIndex = 29;
            this.label9.Text = "Tasa MV";
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.trancisionFormAnalisis.SetDecoration(this.panel14, BunifuAnimatorNS.DecorationType.None);
            this.panel14.Location = new System.Drawing.Point(624, 53);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(58, 1);
            this.panel14.TabIndex = 28;
            // 
            // contadorTasa
            // 
            this.contadorTasa.BackColor = System.Drawing.Color.WhiteSmoke;
            this.contadorTasa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.contadorTasa.DecimalPlaces = 1;
            this.trancisionFormAnalisis.SetDecoration(this.contadorTasa, BunifuAnimatorNS.DecorationType.None);
            this.contadorTasa.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contadorTasa.ForeColor = System.Drawing.Color.Gray;
            this.contadorTasa.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.contadorTasa.Location = new System.Drawing.Point(626, 35);
            this.contadorTasa.Name = "contadorTasa";
            this.contadorTasa.Size = new System.Drawing.Size(58, 18);
            this.contadorTasa.TabIndex = 27;
            this.contadorTasa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.trancisionFormAnalisis.SetDecoration(this.label8, BunifuAnimatorNS.DecorationType.None);
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(449, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 16);
            this.label8.TabIndex = 26;
            this.label8.Text = "Plazo";
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.trancisionFormAnalisis.SetDecoration(this.panel13, BunifuAnimatorNS.DecorationType.None);
            this.panel13.Location = new System.Drawing.Point(489, 53);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(58, 1);
            this.panel13.TabIndex = 25;
            // 
            // contadorPlazo
            // 
            this.contadorPlazo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.contadorPlazo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.trancisionFormAnalisis.SetDecoration(this.contadorPlazo, BunifuAnimatorNS.DecorationType.None);
            this.contadorPlazo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contadorPlazo.ForeColor = System.Drawing.Color.Gray;
            this.contadorPlazo.Location = new System.Drawing.Point(491, 33);
            this.contadorPlazo.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.contadorPlazo.Name = "contadorPlazo";
            this.contadorPlazo.Size = new System.Drawing.Size(58, 18);
            this.contadorPlazo.TabIndex = 24;
            this.contadorPlazo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.trancisionFormAnalisis.SetDecoration(this.panel17, BunifuAnimatorNS.DecorationType.None);
            this.panel17.Location = new System.Drawing.Point(287, 51);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(136, 1);
            this.panel17.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.trancisionFormAnalisis.SetDecoration(this.label12, BunifuAnimatorNS.DecorationType.None);
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Gray;
            this.label12.Location = new System.Drawing.Point(239, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 16);
            this.label12.TabIndex = 11;
            this.label12.Text = "Monto";
            // 
            // tbxMonto
            // 
            this.tbxMonto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxMonto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.trancisionFormAnalisis.SetDecoration(this.tbxMonto, BunifuAnimatorNS.DecorationType.None);
            this.tbxMonto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMonto.ForeColor = System.Drawing.Color.DimGray;
            this.tbxMonto.Location = new System.Drawing.Point(287, 29);
            this.tbxMonto.Multiline = true;
            this.tbxMonto.Name = "tbxMonto";
            this.tbxMonto.Size = new System.Drawing.Size(136, 20);
            this.tbxMonto.TabIndex = 1;
            this.tbxMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.tbxMonto);
            this.panel1.Controls.Add(this.panel17);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.lblCedula);
            this.panel1.Controls.Add(this.tbxCedula);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel15);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.tbxCuota);
            this.panel1.Controls.Add(this.contadorPlazo);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.panel13);
            this.panel1.Controls.Add(this.contadorTasa);
            this.panel1.Controls.Add(this.panel14);
            this.panel1.Controls.Add(this.label9);
            this.trancisionFormAnalisis.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(18, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(720, 102);
            this.panel1.TabIndex = 97;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.trancisionFormAnalisis.SetDecoration(this.panel4, BunifuAnimatorNS.DecorationType.None);
            this.panel4.Location = new System.Drawing.Point(80, 51);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(136, 1);
            this.panel4.TabIndex = 5;
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.BackColor = System.Drawing.Color.Transparent;
            this.trancisionFormAnalisis.SetDecoration(this.lblCedula, BunifuAnimatorNS.DecorationType.None);
            this.lblCedula.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedula.ForeColor = System.Drawing.Color.Gray;
            this.lblCedula.Location = new System.Drawing.Point(32, 32);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(51, 16);
            this.lblCedula.TabIndex = 11;
            this.lblCedula.Text = "Cédula\r\n";
            // 
            // tbxCedula
            // 
            this.tbxCedula.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxCedula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.trancisionFormAnalisis.SetDecoration(this.tbxCedula, BunifuAnimatorNS.DecorationType.None);
            this.tbxCedula.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCedula.ForeColor = System.Drawing.Color.DimGray;
            this.tbxCedula.Location = new System.Drawing.Point(80, 32);
            this.tbxCedula.Multiline = true;
            this.tbxCedula.Name = "tbxCedula";
            this.tbxCedula.Size = new System.Drawing.Size(136, 20);
            this.tbxCedula.TabIndex = 1;
            this.tbxCedula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.panel3.Controls.Add(this.btnLimpiar);
            this.panel3.Controls.Add(this.btnExportar);
            this.panel3.Controls.Add(this.btnAnalisis);
            this.panel3.Controls.Add(this.btnCalculadora);
            this.trancisionFormAnalisis.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(104, 493);
            this.panel3.TabIndex = 100;
            // 
            // btnLimpiar
            // 
            this.trancisionFormAnalisis.SetDecoration(this.btnLimpiar, BunifuAnimatorNS.DecorationType.None);
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Century Gothic", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(0, 282);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(104, 30);
            this.btnLimpiar.TabIndex = 21;
            this.btnLimpiar.Text = "Nuevo";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnExportar
            // 
            this.trancisionFormAnalisis.SetDecoration(this.btnExportar, BunifuAnimatorNS.DecorationType.None);
            this.btnExportar.FlatAppearance.BorderSize = 0;
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Font = new System.Drawing.Font("Century Gothic", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.ForeColor = System.Drawing.Color.White;
            this.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportar.Location = new System.Drawing.Point(0, 249);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(104, 30);
            this.btnExportar.TabIndex = 20;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            // 
            // btnAnalisis
            // 
            this.trancisionFormAnalisis.SetDecoration(this.btnAnalisis, BunifuAnimatorNS.DecorationType.None);
            this.btnAnalisis.FlatAppearance.BorderSize = 0;
            this.btnAnalisis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnalisis.Font = new System.Drawing.Font("Century Gothic", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalisis.ForeColor = System.Drawing.Color.White;
            this.btnAnalisis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnalisis.Location = new System.Drawing.Point(0, 216);
            this.btnAnalisis.Name = "btnAnalisis";
            this.btnAnalisis.Size = new System.Drawing.Size(104, 30);
            this.btnAnalisis.TabIndex = 19;
            this.btnAnalisis.Text = "Análisis";
            this.btnAnalisis.UseVisualStyleBackColor = true;
            // 
            // btnCalculadora
            // 
            this.trancisionFormAnalisis.SetDecoration(this.btnCalculadora, BunifuAnimatorNS.DecorationType.None);
            this.btnCalculadora.FlatAppearance.BorderSize = 0;
            this.btnCalculadora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculadora.Font = new System.Drawing.Font("Century Gothic", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculadora.ForeColor = System.Drawing.Color.White;
            this.btnCalculadora.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalculadora.Location = new System.Drawing.Point(-1, 316);
            this.btnCalculadora.Name = "btnCalculadora";
            this.btnCalculadora.Size = new System.Drawing.Size(104, 30);
            this.btnCalculadora.TabIndex = 18;
            this.btnCalculadora.Text = "      Calculadora";
            this.btnCalculadora.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Ivory;
            this.panel2.BackgroundImage = global::Presentacion.Properties.Resources.panelTitulosMorado;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.lblSimulador);
            this.trancisionFormAnalisis.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Location = new System.Drawing.Point(-5, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(725, 24);
            this.panel2.TabIndex = 0;
            // 
            // lblSimulador
            // 
            this.lblSimulador.AutoSize = true;
            this.lblSimulador.BackColor = System.Drawing.Color.Transparent;
            this.trancisionFormAnalisis.SetDecoration(this.lblSimulador, BunifuAnimatorNS.DecorationType.None);
            this.lblSimulador.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSimulador.ForeColor = System.Drawing.SystemColors.Window;
            this.lblSimulador.Location = new System.Drawing.Point(206, 5);
            this.lblSimulador.Name = "lblSimulador";
            this.lblSimulador.Size = new System.Drawing.Size(313, 15);
            this.lblSimulador.TabIndex = 10;
            this.lblSimulador.Text = "Variables iniciales de entrada para el análisis del crédito\r\n";
            // 
            // pnlCentro
            // 
            this.pnlCentro.Controls.Add(this.panel1);
            this.pnlCentro.Controls.Add(this.dgvPlanPagoComercial);
            this.trancisionFormAnalisis.SetDecoration(this.pnlCentro, BunifuAnimatorNS.DecorationType.None);
            this.pnlCentro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCentro.Location = new System.Drawing.Point(104, 0);
            this.pnlCentro.Name = "pnlCentro";
            this.pnlCentro.Size = new System.Drawing.Size(771, 493);
            this.pnlCentro.TabIndex = 101;
            // 
            // trancisionFormAnalisis
            // 
            this.trancisionFormAnalisis.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.trancisionFormAnalisis.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 1;
            animation2.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 2F;
            animation2.TransparencyCoeff = 0F;
            this.trancisionFormAnalisis.DefaultAnimation = animation2;
            this.trancisionFormAnalisis.Interval = 30;
            // 
            // FormConsumo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(875, 493);
            this.Controls.Add(this.pnlCentro);
            this.Controls.Add(this.panel3);
            this.trancisionFormAnalisis.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormConsumo";
            this.Text = "FormConsumo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanPagoComercial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contadorTasa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contadorPlazo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlCentro.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvPlanPagoComercial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Panel panel15;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox tbxCuota;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Panel panel14;
        public System.Windows.Forms.NumericUpDown contadorTasa;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Panel panel13;
        public System.Windows.Forms.NumericUpDown contadorPlazo;
        public System.Windows.Forms.Panel panel17;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox tbxMonto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.TextBox tbxCedula;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label lblSimulador;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Button btnLimpiar;
        public System.Windows.Forms.Button btnExportar;
        public System.Windows.Forms.Button btnAnalisis;
        public System.Windows.Forms.Button btnCalculadora;
        public System.Windows.Forms.Panel pnlCentro;
        public BunifuAnimatorNS.BunifuTransition trancisionFormAnalisis;
    }
}
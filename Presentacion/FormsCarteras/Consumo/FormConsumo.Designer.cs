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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            BunifuAnimatorNS.Animation animation4 = new BunifuAnimatorNS.Animation();
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
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.pnlCambioDeColor = new System.Windows.Forms.Panel();
            this.lblSimulador = new System.Windows.Forms.Label();
            this.btnPlanCuotas = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblCedula = new System.Windows.Forms.Label();
            this.tbxCedula = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCalculadora = new System.Windows.Forms.Button();
            this.pnlExportar = new System.Windows.Forms.Panel();
            this.btnExportarPDF = new System.Windows.Forms.Button();
            this.btnExportarExcel = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnAnalisis = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pnlCentro = new System.Windows.Forms.Panel();
            this.trancisionFormAnalisis = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.ttFormConsumo = new System.Windows.Forms.ToolTip(this.components);
            this.elipsePnlSuperior = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.elipseDgv = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanPagoComercial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contadorTasa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contadorPlazo)).BeginInit();
            this.pnlPrincipal.SuspendLayout();
            this.pnlCambioDeColor.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlExportar.SuspendLayout();
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
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPlanPagoComercial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
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
            this.dgvPlanPagoComercial.Location = new System.Drawing.Point(29, 139);
            this.dgvPlanPagoComercial.Name = "dgvPlanPagoComercial";
            this.dgvPlanPagoComercial.ReadOnly = true;
            this.dgvPlanPagoComercial.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPlanPagoComercial.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvPlanPagoComercial.RowHeadersVisible = false;
            this.dgvPlanPagoComercial.RowHeadersWidth = 62;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            this.dgvPlanPagoComercial.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvPlanPagoComercial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlanPagoComercial.Size = new System.Drawing.Size(768, 445);
            this.dgvPlanPagoComercial.TabIndex = 99;
            this.dgvPlanPagoComercial.TabStop = false;
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
            this.panel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.trancisionFormAnalisis.SetDecoration(this.panel15, BunifuAnimatorNS.DecorationType.None);
            this.panel15.Location = new System.Drawing.Point(326, 84);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(136, 1);
            this.panel15.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.trancisionFormAnalisis.SetDecoration(this.label10, BunifuAnimatorNS.DecorationType.None);
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(276, 64);
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
            this.tbxCuota.Location = new System.Drawing.Point(328, 67);
            this.tbxCuota.Name = "tbxCuota";
            this.tbxCuota.Size = new System.Drawing.Size(136, 15);
            this.tbxCuota.TabIndex = 30;
            this.tbxCuota.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.trancisionFormAnalisis.SetDecoration(this.label9, BunifuAnimatorNS.DecorationType.None);
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(608, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 16);
            this.label9.TabIndex = 29;
            this.label9.Text = "Tasa MV";
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.trancisionFormAnalisis.SetDecoration(this.panel14, BunifuAnimatorNS.DecorationType.None);
            this.panel14.Location = new System.Drawing.Point(660, 53);
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
            this.contadorTasa.Location = new System.Drawing.Point(662, 35);
            this.contadorTasa.Name = "contadorTasa";
            this.contadorTasa.Size = new System.Drawing.Size(58, 18);
            this.contadorTasa.TabIndex = 3;
            this.contadorTasa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.trancisionFormAnalisis.SetDecoration(this.label8, BunifuAnimatorNS.DecorationType.None);
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(485, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 16);
            this.label8.TabIndex = 26;
            this.label8.Text = "Plazo";
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.trancisionFormAnalisis.SetDecoration(this.panel13, BunifuAnimatorNS.DecorationType.None);
            this.panel13.Location = new System.Drawing.Point(525, 53);
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
            this.contadorPlazo.Location = new System.Drawing.Point(527, 33);
            this.contadorPlazo.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.contadorPlazo.Name = "contadorPlazo";
            this.contadorPlazo.Size = new System.Drawing.Size(58, 18);
            this.contadorPlazo.TabIndex = 2;
            this.contadorPlazo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.trancisionFormAnalisis.SetDecoration(this.panel17, BunifuAnimatorNS.DecorationType.None);
            this.panel17.Location = new System.Drawing.Point(323, 51);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(136, 1);
            this.panel17.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.WhiteSmoke;
            this.trancisionFormAnalisis.SetDecoration(this.label12, BunifuAnimatorNS.DecorationType.None);
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Gray;
            this.label12.Location = new System.Drawing.Point(275, 32);
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
            this.tbxMonto.Location = new System.Drawing.Point(323, 33);
            this.tbxMonto.Name = "tbxMonto";
            this.tbxMonto.Size = new System.Drawing.Size(136, 15);
            this.tbxMonto.TabIndex = 1;
            this.tbxMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlPrincipal.Controls.Add(this.pnlCambioDeColor);
            this.pnlPrincipal.Controls.Add(this.btnPlanCuotas);
            this.pnlPrincipal.Controls.Add(this.label12);
            this.pnlPrincipal.Controls.Add(this.tbxMonto);
            this.pnlPrincipal.Controls.Add(this.panel17);
            this.pnlPrincipal.Controls.Add(this.panel4);
            this.pnlPrincipal.Controls.Add(this.lblCedula);
            this.pnlPrincipal.Controls.Add(this.tbxCedula);
            this.pnlPrincipal.Controls.Add(this.panel15);
            this.pnlPrincipal.Controls.Add(this.label8);
            this.pnlPrincipal.Controls.Add(this.tbxCuota);
            this.pnlPrincipal.Controls.Add(this.contadorPlazo);
            this.pnlPrincipal.Controls.Add(this.label10);
            this.pnlPrincipal.Controls.Add(this.panel13);
            this.pnlPrincipal.Controls.Add(this.contadorTasa);
            this.pnlPrincipal.Controls.Add(this.panel14);
            this.pnlPrincipal.Controls.Add(this.label9);
            this.trancisionFormAnalisis.SetDecoration(this.pnlPrincipal, BunifuAnimatorNS.DecorationType.None);
            this.pnlPrincipal.Location = new System.Drawing.Point(29, 21);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(768, 102);
            this.pnlPrincipal.TabIndex = 97;
            // 
            // pnlCambioDeColor
            // 
            this.pnlCambioDeColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.pnlCambioDeColor.Controls.Add(this.lblSimulador);
            this.trancisionFormAnalisis.SetDecoration(this.pnlCambioDeColor, BunifuAnimatorNS.DecorationType.None);
            this.pnlCambioDeColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCambioDeColor.Location = new System.Drawing.Point(0, 0);
            this.pnlCambioDeColor.Name = "pnlCambioDeColor";
            this.pnlCambioDeColor.Size = new System.Drawing.Size(768, 22);
            this.pnlCambioDeColor.TabIndex = 34;
            // 
            // lblSimulador
            // 
            this.lblSimulador.AutoSize = true;
            this.lblSimulador.BackColor = System.Drawing.Color.Transparent;
            this.trancisionFormAnalisis.SetDecoration(this.lblSimulador, BunifuAnimatorNS.DecorationType.None);
            this.lblSimulador.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSimulador.ForeColor = System.Drawing.SystemColors.Window;
            this.lblSimulador.Location = new System.Drawing.Point(204, 4);
            this.lblSimulador.Name = "lblSimulador";
            this.lblSimulador.Size = new System.Drawing.Size(313, 15);
            this.lblSimulador.TabIndex = 10;
            this.lblSimulador.Text = "Variables iniciales de entrada para el análisis del crédito\r\n";
            // 
            // btnPlanCuotas
            // 
            this.btnPlanCuotas.BackgroundImage = global::Presentacion.Properties.Resources.planCuotas;
            this.btnPlanCuotas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlanCuotas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trancisionFormAnalisis.SetDecoration(this.btnPlanCuotas, BunifuAnimatorNS.DecorationType.None);
            this.btnPlanCuotas.FlatAppearance.BorderSize = 0;
            this.btnPlanCuotas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPlanCuotas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPlanCuotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlanCuotas.Font = new System.Drawing.Font("Century Gothic", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlanCuotas.ForeColor = System.Drawing.Color.DimGray;
            this.btnPlanCuotas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlanCuotas.Location = new System.Drawing.Point(474, 61);
            this.btnPlanCuotas.Name = "btnPlanCuotas";
            this.btnPlanCuotas.Size = new System.Drawing.Size(39, 30);
            this.btnPlanCuotas.TabIndex = 4;
            this.btnPlanCuotas.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.trancisionFormAnalisis.SetDecoration(this.panel4, BunifuAnimatorNS.DecorationType.None);
            this.panel4.Location = new System.Drawing.Point(116, 51);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(136, 1);
            this.panel4.TabIndex = 5;
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.BackColor = System.Drawing.Color.WhiteSmoke;
            this.trancisionFormAnalisis.SetDecoration(this.lblCedula, BunifuAnimatorNS.DecorationType.None);
            this.lblCedula.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedula.ForeColor = System.Drawing.Color.Gray;
            this.lblCedula.Location = new System.Drawing.Point(68, 32);
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
            this.tbxCedula.Location = new System.Drawing.Point(116, 34);
            this.tbxCedula.Name = "tbxCedula";
            this.tbxCedula.Size = new System.Drawing.Size(136, 15);
            this.tbxCedula.TabIndex = 0;
            this.tbxCedula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.panel3.Controls.Add(this.btnCalculadora);
            this.panel3.Controls.Add(this.pnlExportar);
            this.panel3.Controls.Add(this.btnExportar);
            this.panel3.Controls.Add(this.btnAnalisis);
            this.panel3.Controls.Add(this.panel5);
            this.trancisionFormAnalisis.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(118, 648);
            this.panel3.TabIndex = 100;
            // 
            // btnCalculadora
            // 
            this.btnCalculadora.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trancisionFormAnalisis.SetDecoration(this.btnCalculadora, BunifuAnimatorNS.DecorationType.None);
            this.btnCalculadora.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCalculadora.FlatAppearance.BorderSize = 0;
            this.btnCalculadora.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnCalculadora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculadora.Font = new System.Drawing.Font("Century Gothic", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculadora.ForeColor = System.Drawing.Color.White;
            this.btnCalculadora.Image = global::Presentacion.Properties.Resources.divisor;
            this.btnCalculadora.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalculadora.Location = new System.Drawing.Point(0, 383);
            this.btnCalculadora.Name = "btnCalculadora";
            this.btnCalculadora.Size = new System.Drawing.Size(118, 33);
            this.btnCalculadora.TabIndex = 9;
            this.btnCalculadora.Text = "       Calculadora";
            this.btnCalculadora.UseVisualStyleBackColor = true;
            // 
            // pnlExportar
            // 
            this.pnlExportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.pnlExportar.Controls.Add(this.btnExportarPDF);
            this.pnlExportar.Controls.Add(this.btnExportarExcel);
            this.trancisionFormAnalisis.SetDecoration(this.pnlExportar, BunifuAnimatorNS.DecorationType.None);
            this.pnlExportar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlExportar.Location = new System.Drawing.Point(0, 317);
            this.pnlExportar.Name = "pnlExportar";
            this.pnlExportar.Size = new System.Drawing.Size(118, 66);
            this.pnlExportar.TabIndex = 22;
            // 
            // btnExportarPDF
            // 
            this.btnExportarPDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnExportarPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trancisionFormAnalisis.SetDecoration(this.btnExportarPDF, BunifuAnimatorNS.DecorationType.None);
            this.btnExportarPDF.FlatAppearance.BorderSize = 0;
            this.btnExportarPDF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnExportarPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportarPDF.Font = new System.Drawing.Font("Century Gothic", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportarPDF.ForeColor = System.Drawing.Color.White;
            this.btnExportarPDF.Image = global::Presentacion.Properties.Resources.pdf_30px;
            this.btnExportarPDF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportarPDF.Location = new System.Drawing.Point(0, 33);
            this.btnExportarPDF.Name = "btnExportarPDF";
            this.btnExportarPDF.Size = new System.Drawing.Size(124, 33);
            this.btnExportarPDF.TabIndex = 8;
            this.btnExportarPDF.Text = "        PDF";
            this.btnExportarPDF.UseVisualStyleBackColor = false;
            // 
            // btnExportarExcel
            // 
            this.btnExportarExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnExportarExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trancisionFormAnalisis.SetDecoration(this.btnExportarExcel, BunifuAnimatorNS.DecorationType.None);
            this.btnExportarExcel.FlatAppearance.BorderSize = 0;
            this.btnExportarExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnExportarExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportarExcel.Font = new System.Drawing.Font("Century Gothic", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportarExcel.ForeColor = System.Drawing.Color.White;
            this.btnExportarExcel.Image = global::Presentacion.Properties.Resources.microsoft_excel_32px;
            this.btnExportarExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportarExcel.Location = new System.Drawing.Point(0, 0);
            this.btnExportarExcel.Name = "btnExportarExcel";
            this.btnExportarExcel.Size = new System.Drawing.Size(124, 33);
            this.btnExportarExcel.TabIndex = 7;
            this.btnExportarExcel.Text = "        Excel";
            this.btnExportarExcel.UseVisualStyleBackColor = false;
            // 
            // btnExportar
            // 
            this.btnExportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trancisionFormAnalisis.SetDecoration(this.btnExportar, BunifuAnimatorNS.DecorationType.None);
            this.btnExportar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExportar.FlatAppearance.BorderSize = 0;
            this.btnExportar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Font = new System.Drawing.Font("Century Gothic", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.ForeColor = System.Drawing.Color.White;
            this.btnExportar.Image = global::Presentacion.Properties.Resources.export_30px;
            this.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportar.Location = new System.Drawing.Point(0, 284);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(118, 33);
            this.btnExportar.TabIndex = 6;
            this.btnExportar.Text = "      Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            // 
            // btnAnalisis
            // 
            this.btnAnalisis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trancisionFormAnalisis.SetDecoration(this.btnAnalisis, BunifuAnimatorNS.DecorationType.None);
            this.btnAnalisis.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAnalisis.FlatAppearance.BorderSize = 0;
            this.btnAnalisis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnAnalisis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnalisis.Font = new System.Drawing.Font("Century Gothic", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalisis.ForeColor = System.Drawing.Color.White;
            this.btnAnalisis.Image = global::Presentacion.Properties.Resources.analyze_24px;
            this.btnAnalisis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnalisis.Location = new System.Drawing.Point(0, 251);
            this.btnAnalisis.Name = "btnAnalisis";
            this.btnAnalisis.Size = new System.Drawing.Size(118, 33);
            this.btnAnalisis.TabIndex = 5;
            this.btnAnalisis.Text = "      Análisis";
            this.btnAnalisis.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.trancisionFormAnalisis.SetDecoration(this.panel5, BunifuAnimatorNS.DecorationType.None);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(118, 251);
            this.panel5.TabIndex = 0;
            // 
            // pnlCentro
            // 
            this.pnlCentro.AutoScroll = true;
            this.pnlCentro.AutoSize = true;
            this.pnlCentro.Controls.Add(this.pnlPrincipal);
            this.pnlCentro.Controls.Add(this.dgvPlanPagoComercial);
            this.trancisionFormAnalisis.SetDecoration(this.pnlCentro, BunifuAnimatorNS.DecorationType.None);
            this.pnlCentro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCentro.Location = new System.Drawing.Point(118, 0);
            this.pnlCentro.Name = "pnlCentro";
            this.pnlCentro.Size = new System.Drawing.Size(842, 648);
            this.pnlCentro.TabIndex = 101;
            // 
            // trancisionFormAnalisis
            // 
            this.trancisionFormAnalisis.AnimationType = BunifuAnimatorNS.AnimationType.Mosaic;
            this.trancisionFormAnalisis.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 20;
            animation4.Padding = new System.Windows.Forms.Padding(30);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 0F;
            this.trancisionFormAnalisis.DefaultAnimation = animation4;
            this.trancisionFormAnalisis.MaxAnimationTime = 2500;
            // 
            // ttFormConsumo
            // 
            this.ttFormConsumo.IsBalloon = true;
            this.ttFormConsumo.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttFormConsumo.ToolTipTitle = "Información:";
            // 
            // elipsePnlSuperior
            // 
            this.elipsePnlSuperior.ElipseRadius = 4;
            this.elipsePnlSuperior.TargetControl = this.pnlPrincipal;
            // 
            // elipseDgv
            // 
            this.elipseDgv.ElipseRadius = 4;
            this.elipseDgv.TargetControl = this.dgvPlanPagoComercial;
            // 
            // FormConsumo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(960, 648);
            this.Controls.Add(this.pnlCentro);
            this.Controls.Add(this.panel3);
            this.trancisionFormAnalisis.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(960, 648);
            this.MinimumSize = new System.Drawing.Size(960, 648);
            this.Name = "FormConsumo";
            this.Text = "FormConsumo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanPagoComercial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contadorTasa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contadorPlazo)).EndInit();
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            this.pnlCambioDeColor.ResumeLayout(false);
            this.pnlCambioDeColor.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.pnlExportar.ResumeLayout(false);
            this.pnlCentro.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Label lblCedula;
        public System.Windows.Forms.Label lblSimulador;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Button btnExportar;
        public System.Windows.Forms.Button btnAnalisis;
        public System.Windows.Forms.Button btnCalculadora;
        public System.Windows.Forms.Panel pnlCentro;
        public BunifuAnimatorNS.BunifuTransition trancisionFormAnalisis;
        public System.Windows.Forms.Button btnPlanCuotas;
        public System.Windows.Forms.TextBox tbxCedula;
        public System.Windows.Forms.ToolTip ttFormConsumo;
        public System.Windows.Forms.Panel pnlExportar;
        public System.Windows.Forms.Button btnExportarPDF;
        public System.Windows.Forms.Button btnExportarExcel;
        private System.Windows.Forms.Panel panel5;
        private Bunifu.Framework.UI.BunifuElipse elipsePnlSuperior;
        public System.Windows.Forms.Panel pnlCambioDeColor;
        public System.Windows.Forms.Panel pnlPrincipal;
        private Bunifu.Framework.UI.BunifuElipse elipseDgv;
    }
}
using System.Windows.Forms;


namespace Presentacion.Ventanas.Calculadora
{
    partial class FormCalculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCalculadora));
            this.pnlSuperiorForm = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pnlLinea1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.tbxAConvertir = new System.Windows.Forms.TextBox();
            this.rbtTasaNominal1 = new System.Windows.Forms.RadioButton();
            this.rbtTasaEfectiva1 = new System.Windows.Forms.RadioButton();
            this.rbtTasaEfectiva2 = new System.Windows.Forms.RadioButton();
            this.rbtTasaNominal2 = new System.Windows.Forms.RadioButton();
            this.pnlLinea2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxConvertida = new System.Windows.Forms.TextBox();
            this.btnConvertirTasa = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.timerForm = new System.Windows.Forms.Timer(this.components);
            this.elipseForm = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.elipseBtnConvertir = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.DragForm = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ttCalculadora = new System.Windows.Forms.ToolTip(this.components);
            this.pnl5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxPuntos = new System.Windows.Forms.TextBox();
            this.pnl4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxDTF = new System.Windows.Forms.TextBox();
            this.pnl7 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxTasaMensual = new System.Windows.Forms.TextBox();
            this.pnl6 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxTasaEA = new System.Windows.Forms.TextBox();
            this.btnConvertir2 = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.elipseBtnConvertir2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlSuperiorForm.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSuperiorForm
            // 
            this.pnlSuperiorForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(100)))), ((int)(((byte)(26)))));
            this.pnlSuperiorForm.Controls.Add(this.btnCerrar);
            this.pnlSuperiorForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperiorForm.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperiorForm.Name = "pnlSuperiorForm";
            this.pnlSuperiorForm.Size = new System.Drawing.Size(673, 36);
            this.pnlSuperiorForm.TabIndex = 2;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrar.BackgroundImage")));
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(653, 1);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(18, 18);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.UseVisualStyleBackColor = false;
            // 
            // pnlLinea1
            // 
            this.pnlLinea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pnlLinea1.Location = new System.Drawing.Point(150, 104);
            this.pnlLinea1.Name = "pnlLinea1";
            this.pnlLinea1.Size = new System.Drawing.Size(75, 1);
            this.pnlLinea1.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DimGray;
            this.label12.Location = new System.Drawing.Point(43, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 16);
            this.label12.TabIndex = 14;
            this.label12.Text = "Tasa a convertir";
            // 
            // tbxAConvertir
            // 
            this.tbxAConvertir.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxAConvertir.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxAConvertir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAConvertir.ForeColor = System.Drawing.Color.DimGray;
            this.tbxAConvertir.Location = new System.Drawing.Point(150, 85);
            this.tbxAConvertir.Multiline = true;
            this.tbxAConvertir.Name = "tbxAConvertir";
            this.tbxAConvertir.Size = new System.Drawing.Size(75, 20);
            this.tbxAConvertir.TabIndex = 12;
            this.tbxAConvertir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rbtTasaNominal1
            // 
            this.rbtTasaNominal1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtTasaNominal1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtTasaNominal1.ForeColor = System.Drawing.Color.DimGray;
            this.rbtTasaNominal1.Location = new System.Drawing.Point(11, 11);
            this.rbtTasaNominal1.Name = "rbtTasaNominal1";
            this.rbtTasaNominal1.Size = new System.Drawing.Size(55, 24);
            this.rbtTasaNominal1.TabIndex = 15;
            this.rbtTasaNominal1.TabStop = true;
            this.rbtTasaNominal1.Text = "NM";
            this.rbtTasaNominal1.UseVisualStyleBackColor = true;
            // 
            // rbtTasaEfectiva1
            // 
            this.rbtTasaEfectiva1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtTasaEfectiva1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtTasaEfectiva1.ForeColor = System.Drawing.Color.DimGray;
            this.rbtTasaEfectiva1.Location = new System.Drawing.Point(11, 37);
            this.rbtTasaEfectiva1.Name = "rbtTasaEfectiva1";
            this.rbtTasaEfectiva1.Size = new System.Drawing.Size(55, 24);
            this.rbtTasaEfectiva1.TabIndex = 16;
            this.rbtTasaEfectiva1.TabStop = true;
            this.rbtTasaEfectiva1.Text = "EA";
            this.rbtTasaEfectiva1.UseVisualStyleBackColor = true;
            // 
            // rbtTasaEfectiva2
            // 
            this.rbtTasaEfectiva2.Enabled = false;
            this.rbtTasaEfectiva2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtTasaEfectiva2.ForeColor = System.Drawing.Color.DimGray;
            this.rbtTasaEfectiva2.Location = new System.Drawing.Point(11, 32);
            this.rbtTasaEfectiva2.Name = "rbtTasaEfectiva2";
            this.rbtTasaEfectiva2.Size = new System.Drawing.Size(55, 24);
            this.rbtTasaEfectiva2.TabIndex = 21;
            this.rbtTasaEfectiva2.TabStop = true;
            this.rbtTasaEfectiva2.Text = "EA";
            this.rbtTasaEfectiva2.UseVisualStyleBackColor = true;
            // 
            // rbtTasaNominal2
            // 
            this.rbtTasaNominal2.Enabled = false;
            this.rbtTasaNominal2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtTasaNominal2.ForeColor = System.Drawing.Color.DimGray;
            this.rbtTasaNominal2.Location = new System.Drawing.Point(11, 6);
            this.rbtTasaNominal2.Name = "rbtTasaNominal2";
            this.rbtTasaNominal2.Size = new System.Drawing.Size(55, 24);
            this.rbtTasaNominal2.TabIndex = 20;
            this.rbtTasaNominal2.TabStop = true;
            this.rbtTasaNominal2.Text = "NM";
            this.rbtTasaNominal2.UseVisualStyleBackColor = true;
            // 
            // pnlLinea2
            // 
            this.pnlLinea2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pnlLinea2.Location = new System.Drawing.Point(150, 170);
            this.pnlLinea2.Name = "pnlLinea2";
            this.pnlLinea2.Size = new System.Drawing.Size(75, 1);
            this.pnlLinea2.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(43, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Tasa convertida";
            // 
            // tbxConvertida
            // 
            this.tbxConvertida.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxConvertida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxConvertida.Enabled = false;
            this.tbxConvertida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxConvertida.ForeColor = System.Drawing.Color.DimGray;
            this.tbxConvertida.Location = new System.Drawing.Point(150, 151);
            this.tbxConvertida.Multiline = true;
            this.tbxConvertida.Name = "tbxConvertida";
            this.tbxConvertida.Size = new System.Drawing.Size(75, 20);
            this.tbxConvertida.TabIndex = 17;
            this.tbxConvertida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnConvertirTasa
            // 
            this.btnConvertirTasa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(100)))), ((int)(((byte)(26)))));
            this.btnConvertirTasa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConvertirTasa.FlatAppearance.BorderSize = 0;
            this.btnConvertirTasa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvertirTasa.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertirTasa.ForeColor = System.Drawing.Color.White;
            this.btnConvertirTasa.Location = new System.Drawing.Point(120, 238);
            this.btnConvertirTasa.Name = "btnConvertirTasa";
            this.btnConvertirTasa.Size = new System.Drawing.Size(104, 26);
            this.btnConvertirTasa.TabIndex = 23;
            this.btnConvertirTasa.Text = "Convertir";
            this.btnConvertirTasa.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbtTasaNominal1);
            this.panel2.Controls.Add(this.rbtTasaEfectiva1);
            this.panel2.Location = new System.Drawing.Point(225, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(77, 71);
            this.panel2.TabIndex = 28;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rbtTasaEfectiva2);
            this.panel3.Controls.Add(this.rbtTasaNominal2);
            this.panel3.Location = new System.Drawing.Point(225, 140);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(76, 62);
            this.panel3.TabIndex = 29;
            // 
            // timerForm
            // 
            this.timerForm.Enabled = true;
            this.timerForm.Interval = 10;
            // 
            // elipseForm
            // 
            this.elipseForm.ElipseRadius = 5;
            this.elipseForm.TargetControl = this;
            // 
            // elipseBtnConvertir
            // 
            this.elipseBtnConvertir.ElipseRadius = 4;
            this.elipseBtnConvertir.TargetControl = this.btnConvertirTasa;
            // 
            // DragForm
            // 
            this.DragForm.Fixed = true;
            this.DragForm.Horizontal = true;
            this.DragForm.TargetControl = this.pnlSuperiorForm;
            this.DragForm.Vertical = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Presentacion.Properties.Resources.Flecha;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(72, 111);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 40);
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // ttCalculadora
            // 
            this.ttCalculadora.IsBalloon = true;
            this.ttCalculadora.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttCalculadora.ToolTipTitle = "Información:";
            // 
            // pnl5
            // 
            this.pnl5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pnl5.Location = new System.Drawing.Point(517, 122);
            this.pnl5.Name = "pnl5";
            this.pnl5.Size = new System.Drawing.Size(75, 1);
            this.pnl5.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(410, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 35;
            this.label2.Text = "Puntos";
            // 
            // tbxPuntos
            // 
            this.tbxPuntos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxPuntos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxPuntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPuntos.ForeColor = System.Drawing.Color.DimGray;
            this.tbxPuntos.Location = new System.Drawing.Point(517, 103);
            this.tbxPuntos.Multiline = true;
            this.tbxPuntos.Name = "tbxPuntos";
            this.tbxPuntos.Size = new System.Drawing.Size(75, 20);
            this.tbxPuntos.TabIndex = 33;
            this.tbxPuntos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnl4
            // 
            this.pnl4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pnl4.Location = new System.Drawing.Point(517, 81);
            this.pnl4.Name = "pnl4";
            this.pnl4.Size = new System.Drawing.Size(75, 1);
            this.pnl4.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(410, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 16);
            this.label3.TabIndex = 32;
            this.label3.Text = "DTF";
            // 
            // tbxDTF
            // 
            this.tbxDTF.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxDTF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxDTF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDTF.ForeColor = System.Drawing.Color.DimGray;
            this.tbxDTF.Location = new System.Drawing.Point(517, 62);
            this.tbxDTF.Multiline = true;
            this.tbxDTF.Name = "tbxDTF";
            this.tbxDTF.Size = new System.Drawing.Size(75, 20);
            this.tbxDTF.TabIndex = 30;
            this.tbxDTF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnl7
            // 
            this.pnl7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pnl7.Location = new System.Drawing.Point(517, 206);
            this.pnl7.Name = "pnl7";
            this.pnl7.Size = new System.Drawing.Size(75, 1);
            this.pnl7.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(410, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 42;
            this.label4.Text = "Tasa Mensual";
            // 
            // tbxTasaMensual
            // 
            this.tbxTasaMensual.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxTasaMensual.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxTasaMensual.Enabled = false;
            this.tbxTasaMensual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTasaMensual.ForeColor = System.Drawing.Color.DimGray;
            this.tbxTasaMensual.Location = new System.Drawing.Point(517, 187);
            this.tbxTasaMensual.Multiline = true;
            this.tbxTasaMensual.Name = "tbxTasaMensual";
            this.tbxTasaMensual.Size = new System.Drawing.Size(75, 20);
            this.tbxTasaMensual.TabIndex = 40;
            this.tbxTasaMensual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnl6
            // 
            this.pnl6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pnl6.Location = new System.Drawing.Point(517, 165);
            this.pnl6.Name = "pnl6";
            this.pnl6.Size = new System.Drawing.Size(75, 1);
            this.pnl6.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(410, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 39;
            this.label5.Text = "Tasa E.A";
            // 
            // tbxTasaEA
            // 
            this.tbxTasaEA.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxTasaEA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxTasaEA.Enabled = false;
            this.tbxTasaEA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTasaEA.ForeColor = System.Drawing.Color.DimGray;
            this.tbxTasaEA.Location = new System.Drawing.Point(517, 146);
            this.tbxTasaEA.Multiline = true;
            this.tbxTasaEA.Name = "tbxTasaEA";
            this.tbxTasaEA.Size = new System.Drawing.Size(75, 20);
            this.tbxTasaEA.TabIndex = 37;
            this.tbxTasaEA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnConvertir2
            // 
            this.btnConvertir2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(100)))), ((int)(((byte)(26)))));
            this.btnConvertir2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConvertir2.FlatAppearance.BorderSize = 0;
            this.btnConvertir2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvertir2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertir2.ForeColor = System.Drawing.Color.White;
            this.btnConvertir2.Location = new System.Drawing.Point(453, 240);
            this.btnConvertir2.Name = "btnConvertir2";
            this.btnConvertir2.Size = new System.Drawing.Size(104, 26);
            this.btnConvertir2.TabIndex = 43;
            this.btnConvertir2.Text = "Convertir";
            this.btnConvertir2.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DarkGray;
            this.panel7.Location = new System.Drawing.Point(340, 43);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1, 241);
            this.panel7.TabIndex = 44;
            // 
            // elipseBtnConvertir2
            // 
            this.elipseBtnConvertir2.ElipseRadius = 4;
            this.elipseBtnConvertir2.TargetControl = this.btnConvertir2;
            // 
            // FormCalculadora
            // 
            this.AcceptButton = this.btnConvertirTasa;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(673, 290);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.btnConvertir2);
            this.Controls.Add(this.pnl7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxTasaMensual);
            this.Controls.Add(this.pnl6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxTasaEA);
            this.Controls.Add(this.pnl5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxPuntos);
            this.Controls.Add(this.pnl4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxDTF);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnConvertirTasa);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pnlLinea2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxConvertida);
            this.Controls.Add(this.pnlLinea1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbxAConvertir);
            this.Controls.Add(this.pnlSuperiorForm);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCalculadora";
            this.pnlSuperiorForm.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.Button btnConvertirTasa;
        public System.Windows.Forms.RadioButton rbtTasaEfectiva2;
        public System.Windows.Forms.RadioButton rbtTasaNominal2;
        public System.Windows.Forms.Panel pnlLinea2;
        public System.Windows.Forms.TextBox tbxConvertida;
        public System.Windows.Forms.RadioButton rbtTasaEfectiva1;
        public System.Windows.Forms.RadioButton rbtTasaNominal1;
        public System.Windows.Forms.Panel pnlLinea1;
        public System.Windows.Forms.TextBox tbxAConvertir;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Timer timerForm;
        private Bunifu.Framework.UI.BunifuElipse elipseForm;
        private Bunifu.Framework.UI.BunifuElipse elipseBtnConvertir;
        private Bunifu.Framework.UI.BunifuDragControl DragForm;
        public Panel pnlSuperiorForm;
        public ToolTip ttCalculadora;
        private Panel panel7;
        public Button btnConvertir2;
        public Panel pnl7;
        public Label label4;
        public TextBox tbxTasaMensual;
        public Panel pnl6;
        public Label label5;
        public TextBox tbxTasaEA;
        public Panel pnl5;
        public Label label2;
        public TextBox tbxPuntos;
        public Panel pnl4;
        public Label label3;
        public TextBox tbxDTF;
        private Bunifu.Framework.UI.BunifuElipse elipseBtnConvertir2;
    }
}
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel17 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.tbxAConvertir = new System.Windows.Forms.TextBox();
            this.rbtTasaNominal1 = new System.Windows.Forms.RadioButton();
            this.rbtTasaEfectiva1 = new System.Windows.Forms.RadioButton();
            this.rbtTasaEfectiva2 = new System.Windows.Forms.RadioButton();
            this.rbtTasaNominal2 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxConvertida = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ptbDiseno = new System.Windows.Forms.PictureBox();
            this.btnConvertirTasa = new System.Windows.Forms.Button();
            this.btnLimpiarTasa = new System.Windows.Forms.Button();
            this.lblSimulador = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.timerForm = new System.Windows.Forms.Timer(this.components);
            this.pnlSuperiorForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDiseno)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSuperiorForm
            // 
            this.pnlSuperiorForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(100)))), ((int)(((byte)(26)))));
            this.pnlSuperiorForm.Controls.Add(this.pictureBox1);
            this.pnlSuperiorForm.Controls.Add(this.btnMinimizar);
            this.pnlSuperiorForm.Controls.Add(this.btnCerrar);
            this.pnlSuperiorForm.Controls.Add(this.lblTitulo);
            this.pnlSuperiorForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperiorForm.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperiorForm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlSuperiorForm.Name = "pnlSuperiorForm";
            this.pnlSuperiorForm.Size = new System.Drawing.Size(612, 48);
            this.pnlSuperiorForm.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Presentacion.Properties.Resources.LogoPrograma2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 32);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.BackgroundImage = global::Presentacion.Properties.Resources.minimizar;
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Location = new System.Drawing.Point(549, -1);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(29, 27);
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrar.BackgroundImage")));
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(581, -1);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(29, 27);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.UseVisualStyleBackColor = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(233, 11);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(128, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Calculadora\r\n";
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel17.Location = new System.Drawing.Point(363, 128);
            this.panel17.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(100, 1);
            this.panel17.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Gray;
            this.label12.Location = new System.Drawing.Point(220, 110);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(130, 18);
            this.label12.TabIndex = 14;
            this.label12.Text = "Tasa a convertir";
            // 
            // tbxAConvertir
            // 
            this.tbxAConvertir.BackColor = System.Drawing.Color.Ivory;
            this.tbxAConvertir.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxAConvertir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAConvertir.ForeColor = System.Drawing.Color.DimGray;
            this.tbxAConvertir.Location = new System.Drawing.Point(363, 105);
            this.tbxAConvertir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxAConvertir.Multiline = true;
            this.tbxAConvertir.Name = "tbxAConvertir";
            this.tbxAConvertir.Size = new System.Drawing.Size(100, 25);
            this.tbxAConvertir.TabIndex = 12;
            this.tbxAConvertir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rbtTasaNominal1
            // 
            this.rbtTasaNominal1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtTasaNominal1.ForeColor = System.Drawing.Color.Gray;
            this.rbtTasaNominal1.Location = new System.Drawing.Point(471, 101);
            this.rbtTasaNominal1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtTasaNominal1.Name = "rbtTasaNominal1";
            this.rbtTasaNominal1.Size = new System.Drawing.Size(73, 30);
            this.rbtTasaNominal1.TabIndex = 15;
            this.rbtTasaNominal1.TabStop = true;
            this.rbtTasaNominal1.Text = "NM";
            this.rbtTasaNominal1.UseVisualStyleBackColor = true;
            // 
            // rbtTasaEfectiva1
            // 
            this.rbtTasaEfectiva1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtTasaEfectiva1.ForeColor = System.Drawing.Color.Gray;
            this.rbtTasaEfectiva1.Location = new System.Drawing.Point(471, 127);
            this.rbtTasaEfectiva1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtTasaEfectiva1.Name = "rbtTasaEfectiva1";
            this.rbtTasaEfectiva1.Size = new System.Drawing.Size(73, 30);
            this.rbtTasaEfectiva1.TabIndex = 16;
            this.rbtTasaEfectiva1.TabStop = true;
            this.rbtTasaEfectiva1.Text = "EA";
            this.rbtTasaEfectiva1.UseVisualStyleBackColor = true;
            // 
            // rbtTasaEfectiva2
            // 
            this.rbtTasaEfectiva2.Enabled = false;
            this.rbtTasaEfectiva2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtTasaEfectiva2.ForeColor = System.Drawing.Color.Gray;
            this.rbtTasaEfectiva2.Location = new System.Drawing.Point(8, 30);
            this.rbtTasaEfectiva2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtTasaEfectiva2.Name = "rbtTasaEfectiva2";
            this.rbtTasaEfectiva2.Size = new System.Drawing.Size(73, 30);
            this.rbtTasaEfectiva2.TabIndex = 21;
            this.rbtTasaEfectiva2.TabStop = true;
            this.rbtTasaEfectiva2.Text = "EA";
            this.rbtTasaEfectiva2.UseVisualStyleBackColor = true;
            // 
            // rbtTasaNominal2
            // 
            this.rbtTasaNominal2.Enabled = false;
            this.rbtTasaNominal2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtTasaNominal2.ForeColor = System.Drawing.Color.Gray;
            this.rbtTasaNominal2.Location = new System.Drawing.Point(8, 4);
            this.rbtTasaNominal2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtTasaNominal2.Name = "rbtTasaNominal2";
            this.rbtTasaNominal2.Size = new System.Drawing.Size(73, 30);
            this.rbtTasaNominal2.TabIndex = 20;
            this.rbtTasaNominal2.TabStop = true;
            this.rbtTasaNominal2.Text = "NM";
            this.rbtTasaNominal2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Location = new System.Drawing.Point(363, 209);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 1);
            this.panel1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(220, 191);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "Tasa convertida";
            // 
            // tbxConvertida
            // 
            this.tbxConvertida.BackColor = System.Drawing.Color.Ivory;
            this.tbxConvertida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxConvertida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxConvertida.ForeColor = System.Drawing.Color.DimGray;
            this.tbxConvertida.Location = new System.Drawing.Point(363, 186);
            this.tbxConvertida.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxConvertida.Multiline = true;
            this.tbxConvertida.Name = "tbxConvertida";
            this.tbxConvertida.Size = new System.Drawing.Size(100, 25);
            this.tbxConvertida.TabIndex = 17;
            this.tbxConvertida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Presentacion.Properties.Resources.Flecha;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(259, 137);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(63, 49);
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // ptbDiseno
            // 
            this.ptbDiseno.BackgroundImage = global::Presentacion.Properties.Resources.diseñoFondo;
            this.ptbDiseno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbDiseno.Location = new System.Drawing.Point(-4, 100);
            this.ptbDiseno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ptbDiseno.Name = "ptbDiseno";
            this.ptbDiseno.Size = new System.Drawing.Size(211, 244);
            this.ptbDiseno.TabIndex = 3;
            this.ptbDiseno.TabStop = false;
            // 
            // btnConvertirTasa
            // 
            this.btnConvertirTasa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(100)))), ((int)(((byte)(26)))));
            this.btnConvertirTasa.FlatAppearance.BorderSize = 0;
            this.btnConvertirTasa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvertirTasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertirTasa.ForeColor = System.Drawing.Color.White;
            this.btnConvertirTasa.Location = new System.Drawing.Point(237, 278);
            this.btnConvertirTasa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConvertirTasa.Name = "btnConvertirTasa";
            this.btnConvertirTasa.Size = new System.Drawing.Size(139, 32);
            this.btnConvertirTasa.TabIndex = 23;
            this.btnConvertirTasa.Text = "Convertir";
            this.btnConvertirTasa.UseVisualStyleBackColor = false;
            // 
            // btnLimpiarTasa
            // 
            this.btnLimpiarTasa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(100)))), ((int)(((byte)(26)))));
            this.btnLimpiarTasa.FlatAppearance.BorderSize = 0;
            this.btnLimpiarTasa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarTasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarTasa.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarTasa.Location = new System.Drawing.Point(384, 278);
            this.btnLimpiarTasa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLimpiarTasa.Name = "btnLimpiarTasa";
            this.btnLimpiarTasa.Size = new System.Drawing.Size(139, 32);
            this.btnLimpiarTasa.TabIndex = 24;
            this.btnLimpiarTasa.Text = "Nuevo";
            this.btnLimpiarTasa.UseVisualStyleBackColor = false;
            // 
            // lblSimulador
            // 
            this.lblSimulador.AutoSize = true;
            this.lblSimulador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(121)))), ((int)(((byte)(31)))));
            this.lblSimulador.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSimulador.ForeColor = System.Drawing.Color.White;
            this.lblSimulador.Location = new System.Drawing.Point(16, 300);
            this.lblSimulador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSimulador.Name = "lblSimulador";
            this.lblSimulador.Size = new System.Drawing.Size(128, 26);
            this.lblSimulador.TabIndex = 27;
            this.lblSimulador.Text = "Simulador de créditos\r\nSENA";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(463, 87);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(103, 87);
            this.panel2.TabIndex = 28;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rbtTasaEfectiva2);
            this.panel3.Controls.Add(this.rbtTasaNominal2);
            this.panel3.Location = new System.Drawing.Point(463, 178);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(101, 76);
            this.panel3.TabIndex = 29;
            // 
            // timerForm
            // 
            this.timerForm.Enabled = true;
            this.timerForm.Interval = 10;
            // 
            // FormCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(612, 341);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblSimulador);
            this.Controls.Add(this.btnLimpiarTasa);
            this.Controls.Add(this.btnConvertirTasa);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxConvertida);
            this.Controls.Add(this.rbtTasaEfectiva1);
            this.Controls.Add(this.rbtTasaNominal1);
            this.Controls.Add(this.panel17);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbxAConvertir);
            this.Controls.Add(this.pnlSuperiorForm);
            this.Controls.Add(this.ptbDiseno);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCalculadora";
            this.pnlSuperiorForm.ResumeLayout(false);
            this.pnlSuperiorForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDiseno)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlSuperiorForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button btnMinimizar;
        public System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox ptbDiseno;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.Button btnLimpiarTasa;
        public System.Windows.Forms.Button btnConvertirTasa;
        public System.Windows.Forms.Label lblSimulador;
        public System.Windows.Forms.RadioButton rbtTasaEfectiva2;
        public System.Windows.Forms.RadioButton rbtTasaNominal2;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox tbxConvertida;
        public System.Windows.Forms.RadioButton rbtTasaEfectiva1;
        public System.Windows.Forms.RadioButton rbtTasaNominal1;
        public System.Windows.Forms.Panel panel17;
        public System.Windows.Forms.TextBox tbxAConvertir;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Timer timerForm;
    }
}
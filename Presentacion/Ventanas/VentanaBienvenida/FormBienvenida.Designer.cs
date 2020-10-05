namespace Presentacion.Ventanas.VentanaBienvenida
{
    partial class FormBienvenida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBienvenida));
            this.elipseFormBienvenida = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dragFormBienvenida = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnlSuperiorFormBienvenida = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlCentroFormBienvenida = new System.Windows.Forms.Panel();
            this.lblSimulador = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.ptbLogo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.ptbDiseno = new System.Windows.Forms.PictureBox();
            this.timerFechaHora = new System.Windows.Forms.Timer(this.components);
            this.elipseBtnIngresar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.timerForm = new System.Windows.Forms.Timer(this.components);
            this.dragForm = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.dragLogo = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.dragLblTitulo = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnlSuperiorFormBienvenida.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlCentroFormBienvenida.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDiseno)).BeginInit();
            this.SuspendLayout();
            // 
            // elipseFormBienvenida
            // 
            this.elipseFormBienvenida.ElipseRadius = 6;
            this.elipseFormBienvenida.TargetControl = this;
            // 
            // dragFormBienvenida
            // 
            this.dragFormBienvenida.Fixed = true;
            this.dragFormBienvenida.Horizontal = true;
            this.dragFormBienvenida.TargetControl = this.pnlSuperiorFormBienvenida;
            this.dragFormBienvenida.Vertical = true;
            // 
            // pnlSuperiorFormBienvenida
            // 
            this.pnlSuperiorFormBienvenida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(100)))), ((int)(((byte)(26)))));
            this.pnlSuperiorFormBienvenida.Controls.Add(this.pictureBox1);
            this.pnlSuperiorFormBienvenida.Controls.Add(this.btnMinimizar);
            this.pnlSuperiorFormBienvenida.Controls.Add(this.btnCerrar);
            this.pnlSuperiorFormBienvenida.Controls.Add(this.lblTitulo);
            this.pnlSuperiorFormBienvenida.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperiorFormBienvenida.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperiorFormBienvenida.Name = "pnlSuperiorFormBienvenida";
            this.pnlSuperiorFormBienvenida.Size = new System.Drawing.Size(541, 44);
            this.pnlSuperiorFormBienvenida.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Presentacion.Properties.Resources.LogoPrograma2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
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
            this.btnMinimizar.Location = new System.Drawing.Point(494, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(22, 22);
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
            this.btnCerrar.Location = new System.Drawing.Point(518, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(22, 22);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.UseVisualStyleBackColor = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(126, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(294, 19);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "SERVICIO NACIONAL DE APRENDIZAJE\r\n";
            // 
            // pnlCentroFormBienvenida
            // 
            this.pnlCentroFormBienvenida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(240)))), ((int)(((byte)(238)))));
            this.pnlCentroFormBienvenida.Controls.Add(this.lblSimulador);
            this.pnlCentroFormBienvenida.Controls.Add(this.btnIngresar);
            this.pnlCentroFormBienvenida.Controls.Add(this.tbxNombre);
            this.pnlCentroFormBienvenida.Controls.Add(this.ptbLogo);
            this.pnlCentroFormBienvenida.Controls.Add(this.panel1);
            this.pnlCentroFormBienvenida.Controls.Add(this.lblHora);
            this.pnlCentroFormBienvenida.Controls.Add(this.lblFecha);
            this.pnlCentroFormBienvenida.Controls.Add(this.ptbDiseno);
            this.pnlCentroFormBienvenida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCentroFormBienvenida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlCentroFormBienvenida.Location = new System.Drawing.Point(0, 44);
            this.pnlCentroFormBienvenida.Name = "pnlCentroFormBienvenida";
            this.pnlCentroFormBienvenida.Size = new System.Drawing.Size(541, 270);
            this.pnlCentroFormBienvenida.TabIndex = 1;
            // 
            // lblSimulador
            // 
            this.lblSimulador.AutoSize = true;
            this.lblSimulador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(121)))), ((int)(((byte)(31)))));
            this.lblSimulador.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSimulador.ForeColor = System.Drawing.Color.White;
            this.lblSimulador.Location = new System.Drawing.Point(12, 229);
            this.lblSimulador.Name = "lblSimulador";
            this.lblSimulador.Size = new System.Drawing.Size(125, 30);
            this.lblSimulador.TabIndex = 8;
            this.lblSimulador.Text = "Simulador de créditos\r\nSENA";
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(100)))), ((int)(((byte)(26)))));
            this.btnIngresar.FlatAppearance.BorderSize = 0;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.Color.White;
            this.btnIngresar.Location = new System.Drawing.Point(309, 202);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(167, 32);
            this.btnIngresar.TabIndex = 7;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            // 
            // tbxNombre
            // 
            this.tbxNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(240)))), ((int)(((byte)(238)))));
            this.tbxNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxNombre.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNombre.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbxNombre.Location = new System.Drawing.Point(273, 150);
            this.tbxNombre.Multiline = true;
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(239, 27);
            this.tbxNombre.TabIndex = 6;
            this.tbxNombre.Text = "Ingrese su nombre";
            this.tbxNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ptbLogo
            // 
            this.ptbLogo.BackgroundImage = global::Presentacion.Properties.Resources.logo;
            this.ptbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbLogo.Location = new System.Drawing.Point(146, 38);
            this.ptbLogo.Name = "ptbLogo";
            this.ptbLogo.Size = new System.Drawing.Size(120, 120);
            this.ptbLogo.TabIndex = 0;
            this.ptbLogo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Location = new System.Drawing.Point(290, 179);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 1);
            this.panel1.TabIndex = 4;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(100)))), ((int)(((byte)(26)))));
            this.lblHora.Location = new System.Drawing.Point(493, 20);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(50, 16);
            this.lblHora.TabIndex = 3;
            this.lblHora.Text = "00:00:00";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(100)))), ((int)(((byte)(26)))));
            this.lblFecha.Location = new System.Drawing.Point(468, 3);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(74, 17);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "00/00/0000";
            // 
            // ptbDiseno
            // 
            this.ptbDiseno.BackgroundImage = global::Presentacion.Properties.Resources.diseñoFondo;
            this.ptbDiseno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbDiseno.Location = new System.Drawing.Point(-3, 36);
            this.ptbDiseno.Name = "ptbDiseno";
            this.ptbDiseno.Size = new System.Drawing.Size(205, 237);
            this.ptbDiseno.TabIndex = 1;
            this.ptbDiseno.TabStop = false;
            // 
            // timerFechaHora
            // 
            this.timerFechaHora.Enabled = true;
            // 
            // elipseBtnIngresar
            // 
            this.elipseBtnIngresar.ElipseRadius = 10;
            this.elipseBtnIngresar.TargetControl = this.btnIngresar;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // timerForm
            // 
            this.timerForm.Enabled = true;
            this.timerForm.Interval = 10;
            // 
            // dragForm
            // 
            this.dragForm.Fixed = true;
            this.dragForm.Horizontal = true;
            this.dragForm.TargetControl = this.pnlCentroFormBienvenida;
            this.dragForm.Vertical = true;
            // 
            // dragLogo
            // 
            this.dragLogo.Fixed = true;
            this.dragLogo.Horizontal = true;
            this.dragLogo.TargetControl = this.ptbLogo;
            this.dragLogo.Vertical = true;
            // 
            // dragLblTitulo
            // 
            this.dragLblTitulo.Fixed = true;
            this.dragLblTitulo.Horizontal = true;
            this.dragLblTitulo.TargetControl = this.lblTitulo;
            this.dragLblTitulo.Vertical = true;
            // 
            // FormBienvenida
            // 
            this.AcceptButton = this.btnIngresar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(541, 314);
            this.Controls.Add(this.pnlCentroFormBienvenida);
            this.Controls.Add(this.pnlSuperiorFormBienvenida);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBienvenida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBienvenida";
            this.pnlSuperiorFormBienvenida.ResumeLayout(false);
            this.pnlSuperiorFormBienvenida.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlCentroFormBienvenida.ResumeLayout(false);
            this.pnlCentroFormBienvenida.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDiseno)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Bunifu.Framework.UI.BunifuElipse elipseFormBienvenida;
        public Bunifu.Framework.UI.BunifuDragControl dragFormBienvenida;
        private System.Windows.Forms.Panel pnlSuperiorFormBienvenida;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlCentroFormBienvenida;
        private System.Windows.Forms.PictureBox ptbLogo;
        private System.Windows.Forms.PictureBox ptbDiseno;
        public System.Windows.Forms.Timer timerFechaHora;
        public System.Windows.Forms.Label lblHora;
        public System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btnIngresar;
        private Bunifu.Framework.UI.BunifuElipse elipseBtnIngresar;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        public System.Windows.Forms.Label lblSimulador;
        public System.Windows.Forms.Button btnCerrar;
        public System.Windows.Forms.Button btnMinimizar;
        public System.Windows.Forms.TextBox tbxNombre;
        public System.Windows.Forms.Timer timerForm;
        private Bunifu.Framework.UI.BunifuDragControl dragForm;
        private Bunifu.Framework.UI.BunifuDragControl dragLogo;
        private Bunifu.Framework.UI.BunifuDragControl dragLblTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
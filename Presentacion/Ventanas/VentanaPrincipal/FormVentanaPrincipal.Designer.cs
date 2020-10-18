namespace Presentacion.Ventanas.VentanaPrincipal
{
    partial class FormVentanaPrincipal
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVentanaPrincipal));
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.pnlCentro = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSimulador = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.pnlIzquierdo = new System.Windows.Forms.Panel();
            this.lblLinkAcercaDe = new System.Windows.Forms.LinkLabel();
            this.pnlFlecha = new System.Windows.Forms.Panel();
            this.lblNombre = new System.Windows.Forms.Label();
            this.timerFecha = new System.Windows.Forms.Timer(this.components);
            this.timerForm = new System.Windows.Forms.Timer(this.components);
            this.dragForm = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.elipseForm = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuTransitionForm = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.btnPagina = new System.Windows.Forms.Button();
            this.btnYoutube = new System.Windows.Forms.Button();
            this.btnTwitter = new System.Windows.Forms.Button();
            this.btnFacebook = new System.Windows.Forms.Button();
            this.btnInstagram = new System.Windows.Forms.Button();
            this.ptbLogo = new System.Windows.Forms.PictureBox();
            this.btnCalculadora = new System.Windows.Forms.Button();
            this.btnMicro = new System.Windows.Forms.Button();
            this.btnVivienda = new System.Windows.Forms.Button();
            this.btnConsumo = new System.Windows.Forms.Button();
            this.btnComercial = new System.Windows.Forms.Button();
            this.btnCerrarFormActivo = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pnlSuperior.SuspendLayout();
            this.pnlCentro.SuspendLayout();
            this.pnlIzquierdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(100)))), ((int)(((byte)(26)))));
            this.pnlSuperior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlSuperior.Controls.Add(this.btnCerrarFormActivo);
            this.pnlSuperior.Controls.Add(this.btnMinimizar);
            this.pnlSuperior.Controls.Add(this.btnCerrar);
            this.bunifuTransitionForm.SetDecoration(this.pnlSuperior, BunifuAnimatorNS.DecorationType.None);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(1018, 52);
            this.pnlSuperior.TabIndex = 0;
            // 
            // pnlCentro
            // 
            this.pnlCentro.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlCentro.Controls.Add(this.btnPagina);
            this.pnlCentro.Controls.Add(this.btnYoutube);
            this.pnlCentro.Controls.Add(this.btnTwitter);
            this.pnlCentro.Controls.Add(this.btnFacebook);
            this.pnlCentro.Controls.Add(this.btnInstagram);
            this.pnlCentro.Controls.Add(this.panel1);
            this.pnlCentro.Controls.Add(this.panel2);
            this.pnlCentro.Controls.Add(this.label3);
            this.pnlCentro.Controls.Add(this.label2);
            this.pnlCentro.Controls.Add(this.lblSimulador);
            this.pnlCentro.Controls.Add(this.lblHora);
            this.pnlCentro.Controls.Add(this.lblFecha);
            this.pnlCentro.Controls.Add(this.ptbLogo);
            this.bunifuTransitionForm.SetDecoration(this.pnlCentro, BunifuAnimatorNS.DecorationType.None);
            this.pnlCentro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCentro.Location = new System.Drawing.Point(140, 52);
            this.pnlCentro.Name = "pnlCentro";
            this.pnlCentro.Size = new System.Drawing.Size(878, 496);
            this.pnlCentro.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.bunifuTransitionForm.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(575, 470);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 1);
            this.panel1.TabIndex = 29;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.bunifuTransitionForm.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Location = new System.Drawing.Point(16, 470);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(284, 1);
            this.panel2.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransitionForm.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(100)))), ((int)(((byte)(26)))));
            this.label3.Location = new System.Drawing.Point(438, 460);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "www.sena.edu.co";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransitionForm.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(87)))), ((int)(((byte)(86)))));
            this.label2.Location = new System.Drawing.Point(308, 460);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "@SENAcomunica";
            // 
            // lblSimulador
            // 
            this.lblSimulador.AutoSize = true;
            this.lblSimulador.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransitionForm.SetDecoration(this.lblSimulador, BunifuAnimatorNS.DecorationType.None);
            this.lblSimulador.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSimulador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(87)))), ((int)(((byte)(86)))));
            this.lblSimulador.Location = new System.Drawing.Point(371, 341);
            this.lblSimulador.Name = "lblSimulador";
            this.lblSimulador.Size = new System.Drawing.Size(137, 19);
            this.lblSimulador.TabIndex = 12;
            this.lblSimulador.Text = "Análisis de créditos";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.bunifuTransitionForm.SetDecoration(this.lblHora, BunifuAnimatorNS.DecorationType.None);
            this.lblHora.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(100)))), ((int)(((byte)(26)))));
            this.lblHora.Location = new System.Drawing.Point(826, 19);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(50, 16);
            this.lblHora.TabIndex = 11;
            this.lblHora.Text = "00:00:00";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.bunifuTransitionForm.SetDecoration(this.lblFecha, BunifuAnimatorNS.DecorationType.None);
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(100)))), ((int)(((byte)(26)))));
            this.lblFecha.Location = new System.Drawing.Point(803, 2);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(66, 16);
            this.lblFecha.TabIndex = 10;
            this.lblFecha.Text = "00/00/0000";
            // 
            // pnlIzquierdo
            // 
            this.pnlIzquierdo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.pnlIzquierdo.Controls.Add(this.lblLinkAcercaDe);
            this.pnlIzquierdo.Controls.Add(this.pnlFlecha);
            this.pnlIzquierdo.Controls.Add(this.btnCalculadora);
            this.pnlIzquierdo.Controls.Add(this.btnMicro);
            this.pnlIzquierdo.Controls.Add(this.btnVivienda);
            this.pnlIzquierdo.Controls.Add(this.btnConsumo);
            this.pnlIzquierdo.Controls.Add(this.btnComercial);
            this.pnlIzquierdo.Controls.Add(this.lblNombre);
            this.bunifuTransitionForm.SetDecoration(this.pnlIzquierdo, BunifuAnimatorNS.DecorationType.None);
            this.pnlIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlIzquierdo.Location = new System.Drawing.Point(0, 52);
            this.pnlIzquierdo.Name = "pnlIzquierdo";
            this.pnlIzquierdo.Size = new System.Drawing.Size(140, 496);
            this.pnlIzquierdo.TabIndex = 3;
            // 
            // lblLinkAcercaDe
            // 
            this.lblLinkAcercaDe.ActiveLinkColor = System.Drawing.Color.Teal;
            this.lblLinkAcercaDe.AutoSize = true;
            this.bunifuTransitionForm.SetDecoration(this.lblLinkAcercaDe, BunifuAnimatorNS.DecorationType.None);
            this.lblLinkAcercaDe.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinkAcercaDe.LinkColor = System.Drawing.Color.Cyan;
            this.lblLinkAcercaDe.Location = new System.Drawing.Point(27, 475);
            this.lblLinkAcercaDe.Name = "lblLinkAcercaDe";
            this.lblLinkAcercaDe.Size = new System.Drawing.Size(77, 16);
            this.lblLinkAcercaDe.TabIndex = 20;
            this.lblLinkAcercaDe.TabStop = true;
            this.lblLinkAcercaDe.Text = "Acerca de ...";
            // 
            // pnlFlecha
            // 
            this.pnlFlecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pnlFlecha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuTransitionForm.SetDecoration(this.pnlFlecha, BunifuAnimatorNS.DecorationType.None);
            this.pnlFlecha.Location = new System.Drawing.Point(0, 211);
            this.pnlFlecha.Name = "pnlFlecha";
            this.pnlFlecha.Size = new System.Drawing.Size(4, 25);
            this.pnlFlecha.TabIndex = 18;
            this.pnlFlecha.Visible = false;
            // 
            // lblNombre
            // 
            this.bunifuTransitionForm.SetDecoration(this.lblNombre, BunifuAnimatorNS.DecorationType.None);
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(3, 3);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(137, 32);
            this.lblNombre.TabIndex = 12;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timerFecha
            // 
            this.timerFecha.Enabled = true;
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
            this.dragForm.TargetControl = this.pnlSuperior;
            this.dragForm.Vertical = true;
            // 
            // elipseForm
            // 
            this.elipseForm.ElipseRadius = 7;
            this.elipseForm.TargetControl = this;
            // 
            // bunifuTransitionForm
            // 
            this.bunifuTransitionForm.AnimationType = BunifuAnimatorNS.AnimationType.Leaf;
            this.bunifuTransitionForm.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 1F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuTransitionForm.DefaultAnimation = animation1;
            // 
            // btnPagina
            // 
            this.btnPagina.BackgroundImage = global::Presentacion.Properties.Resources.website_48px;
            this.btnPagina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTransitionForm.SetDecoration(this.btnPagina, BunifuAnimatorNS.DecorationType.None);
            this.btnPagina.FlatAppearance.BorderSize = 0;
            this.btnPagina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagina.Location = new System.Drawing.Point(812, 410);
            this.btnPagina.Name = "btnPagina";
            this.btnPagina.Size = new System.Drawing.Size(33, 33);
            this.btnPagina.TabIndex = 34;
            this.btnPagina.UseVisualStyleBackColor = true;
            // 
            // btnYoutube
            // 
            this.btnYoutube.BackgroundImage = global::Presentacion.Properties.Resources.play_buttonLogo;
            this.btnYoutube.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTransitionForm.SetDecoration(this.btnYoutube, BunifuAnimatorNS.DecorationType.None);
            this.btnYoutube.FlatAppearance.BorderSize = 0;
            this.btnYoutube.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYoutube.Location = new System.Drawing.Point(775, 410);
            this.btnYoutube.Name = "btnYoutube";
            this.btnYoutube.Size = new System.Drawing.Size(33, 33);
            this.btnYoutube.TabIndex = 33;
            this.btnYoutube.UseVisualStyleBackColor = true;
            // 
            // btnTwitter
            // 
            this.btnTwitter.BackgroundImage = global::Presentacion.Properties.Resources.twitterLogo;
            this.btnTwitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTransitionForm.SetDecoration(this.btnTwitter, BunifuAnimatorNS.DecorationType.None);
            this.btnTwitter.FlatAppearance.BorderSize = 0;
            this.btnTwitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTwitter.Location = new System.Drawing.Point(739, 410);
            this.btnTwitter.Name = "btnTwitter";
            this.btnTwitter.Size = new System.Drawing.Size(33, 33);
            this.btnTwitter.TabIndex = 32;
            this.btnTwitter.UseVisualStyleBackColor = true;
            // 
            // btnFacebook
            // 
            this.btnFacebook.BackgroundImage = global::Presentacion.Properties.Resources.facebookLogo;
            this.btnFacebook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTransitionForm.SetDecoration(this.btnFacebook, BunifuAnimatorNS.DecorationType.None);
            this.btnFacebook.FlatAppearance.BorderSize = 0;
            this.btnFacebook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacebook.Location = new System.Drawing.Point(702, 410);
            this.btnFacebook.Name = "btnFacebook";
            this.btnFacebook.Size = new System.Drawing.Size(33, 33);
            this.btnFacebook.TabIndex = 31;
            this.btnFacebook.UseVisualStyleBackColor = true;
            // 
            // btnInstagram
            // 
            this.btnInstagram.BackgroundImage = global::Presentacion.Properties.Resources.instagramLogo;
            this.btnInstagram.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTransitionForm.SetDecoration(this.btnInstagram, BunifuAnimatorNS.DecorationType.None);
            this.btnInstagram.FlatAppearance.BorderSize = 0;
            this.btnInstagram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInstagram.Location = new System.Drawing.Point(666, 410);
            this.btnInstagram.Name = "btnInstagram";
            this.btnInstagram.Size = new System.Drawing.Size(33, 33);
            this.btnInstagram.TabIndex = 30;
            this.btnInstagram.UseVisualStyleBackColor = true;
            // 
            // ptbLogo
            // 
            this.ptbLogo.BackgroundImage = global::Presentacion.Properties.Resources.logo;
            this.ptbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTransitionForm.SetDecoration(this.ptbLogo, BunifuAnimatorNS.DecorationType.None);
            this.ptbLogo.Location = new System.Drawing.Point(337, 137);
            this.ptbLogo.Name = "ptbLogo";
            this.ptbLogo.Size = new System.Drawing.Size(200, 200);
            this.ptbLogo.TabIndex = 1;
            this.ptbLogo.TabStop = false;
            // 
            // btnCalculadora
            // 
            this.bunifuTransitionForm.SetDecoration(this.btnCalculadora, BunifuAnimatorNS.DecorationType.None);
            this.btnCalculadora.FlatAppearance.BorderSize = 0;
            this.btnCalculadora.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnCalculadora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculadora.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculadora.ForeColor = System.Drawing.Color.White;
            this.btnCalculadora.Image = global::Presentacion.Properties.Resources.calculadora__2_;
            this.btnCalculadora.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalculadora.Location = new System.Drawing.Point(0, 332);
            this.btnCalculadora.Name = "btnCalculadora";
            this.btnCalculadora.Size = new System.Drawing.Size(140, 30);
            this.btnCalculadora.TabIndex = 17;
            this.btnCalculadora.Text = "Calculadora";
            this.btnCalculadora.UseVisualStyleBackColor = true;
            // 
            // btnMicro
            // 
            this.bunifuTransitionForm.SetDecoration(this.btnMicro, BunifuAnimatorNS.DecorationType.None);
            this.btnMicro.FlatAppearance.BorderSize = 0;
            this.btnMicro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnMicro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMicro.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMicro.ForeColor = System.Drawing.Color.White;
            this.btnMicro.Image = global::Presentacion.Properties.Resources.Micro__1_;
            this.btnMicro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMicro.Location = new System.Drawing.Point(0, 300);
            this.btnMicro.Name = "btnMicro";
            this.btnMicro.Size = new System.Drawing.Size(140, 30);
            this.btnMicro.TabIndex = 16;
            this.btnMicro.Text = "Micro";
            this.btnMicro.UseVisualStyleBackColor = true;
            // 
            // btnVivienda
            // 
            this.bunifuTransitionForm.SetDecoration(this.btnVivienda, BunifuAnimatorNS.DecorationType.None);
            this.btnVivienda.FlatAppearance.BorderSize = 0;
            this.btnVivienda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnVivienda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVivienda.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVivienda.ForeColor = System.Drawing.Color.White;
            this.btnVivienda.Image = global::Presentacion.Properties.Resources.vivienda__1_;
            this.btnVivienda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVivienda.Location = new System.Drawing.Point(0, 268);
            this.btnVivienda.Name = "btnVivienda";
            this.btnVivienda.Size = new System.Drawing.Size(140, 30);
            this.btnVivienda.TabIndex = 15;
            this.btnVivienda.Text = "Vivienda";
            this.btnVivienda.UseVisualStyleBackColor = true;
            // 
            // btnConsumo
            // 
            this.bunifuTransitionForm.SetDecoration(this.btnConsumo, BunifuAnimatorNS.DecorationType.None);
            this.btnConsumo.FlatAppearance.BorderSize = 0;
            this.btnConsumo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnConsumo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsumo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsumo.ForeColor = System.Drawing.Color.White;
            this.btnConsumo.Image = global::Presentacion.Properties.Resources.consumo__1_;
            this.btnConsumo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsumo.Location = new System.Drawing.Point(0, 204);
            this.btnConsumo.Name = "btnConsumo";
            this.btnConsumo.Size = new System.Drawing.Size(140, 30);
            this.btnConsumo.TabIndex = 14;
            this.btnConsumo.Text = "Consumo";
            this.btnConsumo.UseVisualStyleBackColor = true;
            // 
            // btnComercial
            // 
            this.bunifuTransitionForm.SetDecoration(this.btnComercial, BunifuAnimatorNS.DecorationType.None);
            this.btnComercial.FlatAppearance.BorderSize = 0;
            this.btnComercial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnComercial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComercial.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComercial.ForeColor = System.Drawing.Color.White;
            this.btnComercial.Image = global::Presentacion.Properties.Resources.empresa__2_;
            this.btnComercial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComercial.Location = new System.Drawing.Point(0, 236);
            this.btnComercial.Name = "btnComercial";
            this.btnComercial.Size = new System.Drawing.Size(140, 30);
            this.btnComercial.TabIndex = 13;
            this.btnComercial.Text = "Comercial";
            this.btnComercial.UseVisualStyleBackColor = true;
            this.btnComercial.Click += new System.EventHandler(this.btnComercial_Click);
            // 
            // btnCerrarFormActivo
            // 
            this.btnCerrarFormActivo.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarFormActivo.BackgroundImage = global::Presentacion.Properties.Resources.logo_blanco;
            this.btnCerrarFormActivo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTransitionForm.SetDecoration(this.btnCerrarFormActivo, BunifuAnimatorNS.DecorationType.None);
            this.btnCerrarFormActivo.FlatAppearance.BorderSize = 0;
            this.btnCerrarFormActivo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnCerrarFormActivo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCerrarFormActivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarFormActivo.Location = new System.Drawing.Point(3, 5);
            this.btnCerrarFormActivo.Name = "btnCerrarFormActivo";
            this.btnCerrarFormActivo.Size = new System.Drawing.Size(33, 29);
            this.btnCerrarFormActivo.TabIndex = 13;
            this.btnCerrarFormActivo.UseVisualStyleBackColor = false;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.BackgroundImage = global::Presentacion.Properties.Resources.minimizar;
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTransitionForm.SetDecoration(this.btnMinimizar, BunifuAnimatorNS.DecorationType.None);
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Location = new System.Drawing.Point(972, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(22, 22);
            this.btnMinimizar.TabIndex = 4;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrar.BackgroundImage")));
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTransitionForm.SetDecoration(this.btnCerrar, BunifuAnimatorNS.DecorationType.None);
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(995, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(22, 22);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.UseVisualStyleBackColor = false;
            // 
            // FormVentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 548);
            this.Controls.Add(this.pnlCentro);
            this.Controls.Add(this.pnlIzquierdo);
            this.Controls.Add(this.pnlSuperior);
            this.bunifuTransitionForm.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormVentanaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormVentanaPrincipal";
            this.pnlSuperior.ResumeLayout(false);
            this.pnlCentro.ResumeLayout(false);
            this.pnlCentro.PerformLayout();
            this.pnlIzquierdo.ResumeLayout(false);
            this.pnlIzquierdo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlIzquierdo;
        public System.Windows.Forms.Button btnMinimizar;
        public System.Windows.Forms.Button btnCerrar;
        public System.Windows.Forms.Label lblHora;
        public System.Windows.Forms.Label lblFecha;
        public System.Windows.Forms.Label lblNombre;
        public System.Windows.Forms.Timer timerFecha;
        public System.Windows.Forms.Timer timerForm;
        private System.Windows.Forms.Button btnCalculadora;
        public System.Windows.Forms.Button btnMicro;
        public System.Windows.Forms.Button btnVivienda;
        public System.Windows.Forms.Button btnConsumo;
        public System.Windows.Forms.Button btnComercial;
        public System.Windows.Forms.Panel pnlFlecha;
        public System.Windows.Forms.Panel pnlCentro;
        public System.Windows.Forms.Button btnCerrarFormActivo;
        public System.Windows.Forms.PictureBox ptbLogo;
        public System.Windows.Forms.Panel pnlSuperior;
        public System.Windows.Forms.LinkLabel lblLinkAcercaDe;
        public System.Windows.Forms.Label lblSimulador;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuDragControl dragForm;
        private Bunifu.Framework.UI.BunifuElipse elipseForm;
        public BunifuAnimatorNS.BunifuTransition bunifuTransitionForm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button btnYoutube;
        public System.Windows.Forms.Button btnTwitter;
        public System.Windows.Forms.Button btnFacebook;
        public System.Windows.Forms.Button btnInstagram;
        public System.Windows.Forms.Button btnPagina;
    }
}
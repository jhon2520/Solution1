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
            this.pnlBotonesColores = new System.Windows.Forms.Panel();
            this.btnCerrarFormActivo = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.pnlCentro = new System.Windows.Forms.Panel();
            this.lblLinkAcercaDe = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLblSalario = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSenaCom = new System.Windows.Forms.Label();
            this.lblSenaComunica = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.ptbLogo = new System.Windows.Forms.PictureBox();
            this.btnPagina = new System.Windows.Forms.Button();
            this.btnYoutube = new System.Windows.Forms.Button();
            this.btnTwitter = new System.Windows.Forms.Button();
            this.btnFacebook = new System.Windows.Forms.Button();
            this.btnInstagram = new System.Windows.Forms.Button();
            this.pnlIzquierdo = new System.Windows.Forms.Panel();
            this.btnDocumentacion = new System.Windows.Forms.Button();
            this.pnlFlecha = new System.Windows.Forms.Panel();
            this.btnMicro = new System.Windows.Forms.Button();
            this.btnVivienda = new System.Windows.Forms.Button();
            this.btnConsumo = new System.Windows.Forms.Button();
            this.btnComercial = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.timerFecha = new System.Windows.Forms.Timer(this.components);
            this.timerForm = new System.Windows.Forms.Timer(this.components);
            this.dragForm = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.elipseForm = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuTransitionForm = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.elipseBtnSalario = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ttFormPrincipal = new System.Windows.Forms.ToolTip(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlSuperior.SuspendLayout();
            this.pnlBotonesColores.SuspendLayout();
            this.pnlCentro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).BeginInit();
            this.pnlIzquierdo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(100)))), ((int)(((byte)(26)))));
            this.pnlSuperior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlSuperior.Controls.Add(this.pnlBotonesColores);
            this.bunifuTransitionForm.SetDecoration(this.pnlSuperior, BunifuAnimatorNS.DecorationType.None);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(1043, 52);
            this.pnlSuperior.TabIndex = 2;
            // 
            // pnlBotonesColores
            // 
            this.pnlBotonesColores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(100)))), ((int)(((byte)(26)))));
            this.pnlBotonesColores.Controls.Add(this.btnCerrarFormActivo);
            this.pnlBotonesColores.Controls.Add(this.btnCerrar);
            this.pnlBotonesColores.Controls.Add(this.btnMinimizar);
            this.bunifuTransitionForm.SetDecoration(this.pnlBotonesColores, BunifuAnimatorNS.DecorationType.None);
            this.pnlBotonesColores.Location = new System.Drawing.Point(987, 2);
            this.pnlBotonesColores.Name = "pnlBotonesColores";
            this.pnlBotonesColores.Size = new System.Drawing.Size(54, 18);
            this.pnlBotonesColores.TabIndex = 3;
            // 
            // btnCerrarFormActivo
            // 
            this.btnCerrarFormActivo.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarFormActivo.BackgroundImage = global::Presentacion.Properties.Resources.circuloprincipal;
            this.btnCerrarFormActivo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrarFormActivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransitionForm.SetDecoration(this.btnCerrarFormActivo, BunifuAnimatorNS.DecorationType.None);
            this.btnCerrarFormActivo.FlatAppearance.BorderSize = 0;
            this.btnCerrarFormActivo.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnCerrarFormActivo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCerrarFormActivo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCerrarFormActivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarFormActivo.Location = new System.Drawing.Point(0, 0);
            this.btnCerrarFormActivo.Name = "btnCerrarFormActivo";
            this.btnCerrarFormActivo.Size = new System.Drawing.Size(18, 18);
            this.btnCerrarFormActivo.TabIndex = 0;
            this.btnCerrarFormActivo.UseVisualStyleBackColor = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.BackgroundImage = global::Presentacion.Properties.Resources.circulocerrar;
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransitionForm.SetDecoration(this.btnCerrar, BunifuAnimatorNS.DecorationType.None);
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(36, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(18, 18);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.UseVisualStyleBackColor = false;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.BackgroundImage = global::Presentacion.Properties.Resources.circulominimizar;
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransitionForm.SetDecoration(this.btnMinimizar, BunifuAnimatorNS.DecorationType.None);
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Location = new System.Drawing.Point(18, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(18, 18);
            this.btnMinimizar.TabIndex = 1;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            // 
            // pnlCentro
            // 
            this.pnlCentro.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlCentro.Controls.Add(this.lblLinkAcercaDe);
            this.pnlCentro.Controls.Add(this.panel1);
            this.pnlCentro.Controls.Add(this.linkLblSalario);
            this.pnlCentro.Controls.Add(this.panel2);
            this.pnlCentro.Controls.Add(this.lblSenaCom);
            this.pnlCentro.Controls.Add(this.lblSenaComunica);
            this.pnlCentro.Controls.Add(this.lblHora);
            this.pnlCentro.Controls.Add(this.lblFecha);
            this.pnlCentro.Controls.Add(this.ptbLogo);
            this.pnlCentro.Controls.Add(this.btnPagina);
            this.pnlCentro.Controls.Add(this.btnYoutube);
            this.pnlCentro.Controls.Add(this.btnTwitter);
            this.pnlCentro.Controls.Add(this.btnFacebook);
            this.pnlCentro.Controls.Add(this.btnInstagram);
            this.pnlCentro.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.bunifuTransitionForm.SetDecoration(this.pnlCentro, BunifuAnimatorNS.DecorationType.None);
            this.pnlCentro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCentro.Location = new System.Drawing.Point(140, 52);
            this.pnlCentro.Name = "pnlCentro";
            this.pnlCentro.Size = new System.Drawing.Size(903, 497);
            this.pnlCentro.TabIndex = 1;
            // 
            // lblLinkAcercaDe
            // 
            this.lblLinkAcercaDe.ActiveLinkColor = System.Drawing.Color.Teal;
            this.lblLinkAcercaDe.AutoSize = true;
            this.lblLinkAcercaDe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransitionForm.SetDecoration(this.lblLinkAcercaDe, BunifuAnimatorNS.DecorationType.None);
            this.lblLinkAcercaDe.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinkAcercaDe.LinkColor = System.Drawing.Color.DarkSlateGray;
            this.lblLinkAcercaDe.Location = new System.Drawing.Point(3, 479);
            this.lblLinkAcercaDe.Name = "lblLinkAcercaDe";
            this.lblLinkAcercaDe.Size = new System.Drawing.Size(77, 16);
            this.lblLinkAcercaDe.TabIndex = 1;
            this.lblLinkAcercaDe.TabStop = true;
            this.lblLinkAcercaDe.Text = "Acerca de ...";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.bunifuTransitionForm.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(591, 472);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 1);
            this.panel1.TabIndex = 0;
            // 
            // linkLblSalario
            // 
            this.linkLblSalario.ActiveLinkColor = System.Drawing.Color.Teal;
            this.linkLblSalario.AutoSize = true;
            this.linkLblSalario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransitionForm.SetDecoration(this.linkLblSalario, BunifuAnimatorNS.DecorationType.None);
            this.linkLblSalario.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLblSalario.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.linkLblSalario.LinkColor = System.Drawing.Color.DarkSlateGray;
            this.linkLblSalario.Location = new System.Drawing.Point(86, 479);
            this.linkLblSalario.Name = "linkLblSalario";
            this.linkLblSalario.Size = new System.Drawing.Size(93, 16);
            this.linkLblSalario.TabIndex = 2;
            this.linkLblSalario.TabStop = true;
            this.linkLblSalario.Text = "Cambiar salario";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.bunifuTransitionForm.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Location = new System.Drawing.Point(29, 472);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(284, 1);
            this.panel2.TabIndex = 6;
            // 
            // lblSenaCom
            // 
            this.lblSenaCom.AutoSize = true;
            this.lblSenaCom.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransitionForm.SetDecoration(this.lblSenaCom, BunifuAnimatorNS.DecorationType.None);
            this.lblSenaCom.Font = new System.Drawing.Font("Century Gothic", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenaCom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(100)))), ((int)(((byte)(26)))));
            this.lblSenaCom.Location = new System.Drawing.Point(456, 462);
            this.lblSenaCom.Name = "lblSenaCom";
            this.lblSenaCom.Size = new System.Drawing.Size(129, 17);
            this.lblSenaCom.TabIndex = 0;
            this.lblSenaCom.Text = "www.sena.edu.co";
            // 
            // lblSenaComunica
            // 
            this.lblSenaComunica.AutoSize = true;
            this.lblSenaComunica.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransitionForm.SetDecoration(this.lblSenaComunica, BunifuAnimatorNS.DecorationType.None);
            this.lblSenaComunica.Font = new System.Drawing.Font("Century Gothic", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenaComunica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(87)))), ((int)(((byte)(86)))));
            this.lblSenaComunica.Location = new System.Drawing.Point(332, 462);
            this.lblSenaComunica.Name = "lblSenaComunica";
            this.lblSenaComunica.Size = new System.Drawing.Size(122, 17);
            this.lblSenaComunica.TabIndex = 0;
            this.lblSenaComunica.Text = "@SENAcomunica";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.bunifuTransitionForm.SetDecoration(this.lblHora, BunifuAnimatorNS.DecorationType.None);
            this.lblHora.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(100)))), ((int)(((byte)(26)))));
            this.lblHora.Location = new System.Drawing.Point(756, 479);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(50, 16);
            this.lblHora.TabIndex = 0;
            this.lblHora.Text = "00:00:00";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.bunifuTransitionForm.SetDecoration(this.lblFecha, BunifuAnimatorNS.DecorationType.None);
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(100)))), ((int)(((byte)(26)))));
            this.lblFecha.Location = new System.Drawing.Point(809, 479);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(66, 16);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "00/00/0000";
            // 
            // ptbLogo
            // 
            this.ptbLogo.BackgroundImage = global::Presentacion.Properties.Resources.logo;
            this.ptbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTransitionForm.SetDecoration(this.ptbLogo, BunifuAnimatorNS.DecorationType.None);
            this.ptbLogo.Location = new System.Drawing.Point(351, 148);
            this.ptbLogo.Name = "ptbLogo";
            this.ptbLogo.Size = new System.Drawing.Size(200, 200);
            this.ptbLogo.TabIndex = 1;
            this.ptbLogo.TabStop = false;
            // 
            // btnPagina
            // 
            this.btnPagina.BackgroundImage = global::Presentacion.Properties.Resources.website_48px;
            this.btnPagina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPagina.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransitionForm.SetDecoration(this.btnPagina, BunifuAnimatorNS.DecorationType.None);
            this.btnPagina.FlatAppearance.BorderSize = 0;
            this.btnPagina.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnPagina.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPagina.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPagina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagina.Location = new System.Drawing.Point(851, 413);
            this.btnPagina.Name = "btnPagina";
            this.btnPagina.Size = new System.Drawing.Size(33, 33);
            this.btnPagina.TabIndex = 7;
            this.btnPagina.UseVisualStyleBackColor = true;
            // 
            // btnYoutube
            // 
            this.btnYoutube.BackgroundImage = global::Presentacion.Properties.Resources.play_buttonLogo;
            this.btnYoutube.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnYoutube.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransitionForm.SetDecoration(this.btnYoutube, BunifuAnimatorNS.DecorationType.None);
            this.btnYoutube.FlatAppearance.BorderSize = 0;
            this.btnYoutube.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnYoutube.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnYoutube.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnYoutube.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYoutube.Location = new System.Drawing.Point(814, 413);
            this.btnYoutube.Name = "btnYoutube";
            this.btnYoutube.Size = new System.Drawing.Size(33, 33);
            this.btnYoutube.TabIndex = 6;
            this.btnYoutube.UseVisualStyleBackColor = true;
            // 
            // btnTwitter
            // 
            this.btnTwitter.BackgroundImage = global::Presentacion.Properties.Resources.twitterLogo;
            this.btnTwitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTwitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransitionForm.SetDecoration(this.btnTwitter, BunifuAnimatorNS.DecorationType.None);
            this.btnTwitter.FlatAppearance.BorderSize = 0;
            this.btnTwitter.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnTwitter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnTwitter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnTwitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTwitter.Location = new System.Drawing.Point(778, 413);
            this.btnTwitter.Name = "btnTwitter";
            this.btnTwitter.Size = new System.Drawing.Size(33, 33);
            this.btnTwitter.TabIndex = 5;
            this.btnTwitter.UseVisualStyleBackColor = true;
            // 
            // btnFacebook
            // 
            this.btnFacebook.BackgroundImage = global::Presentacion.Properties.Resources.facebookLogo;
            this.btnFacebook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFacebook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransitionForm.SetDecoration(this.btnFacebook, BunifuAnimatorNS.DecorationType.None);
            this.btnFacebook.FlatAppearance.BorderSize = 0;
            this.btnFacebook.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnFacebook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnFacebook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnFacebook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacebook.Location = new System.Drawing.Point(741, 413);
            this.btnFacebook.Name = "btnFacebook";
            this.btnFacebook.Size = new System.Drawing.Size(33, 33);
            this.btnFacebook.TabIndex = 4;
            this.btnFacebook.UseVisualStyleBackColor = true;
            // 
            // btnInstagram
            // 
            this.btnInstagram.BackgroundImage = global::Presentacion.Properties.Resources.instagramLogo;
            this.btnInstagram.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInstagram.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransitionForm.SetDecoration(this.btnInstagram, BunifuAnimatorNS.DecorationType.None);
            this.btnInstagram.FlatAppearance.BorderSize = 0;
            this.btnInstagram.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnInstagram.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnInstagram.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnInstagram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInstagram.Location = new System.Drawing.Point(705, 413);
            this.btnInstagram.Name = "btnInstagram";
            this.btnInstagram.Size = new System.Drawing.Size(33, 33);
            this.btnInstagram.TabIndex = 3;
            this.btnInstagram.UseVisualStyleBackColor = true;
            // 
            // pnlIzquierdo
            // 
            this.pnlIzquierdo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.pnlIzquierdo.Controls.Add(this.btnDocumentacion);
            this.pnlIzquierdo.Controls.Add(this.pnlFlecha);
            this.pnlIzquierdo.Controls.Add(this.btnMicro);
            this.pnlIzquierdo.Controls.Add(this.btnVivienda);
            this.pnlIzquierdo.Controls.Add(this.btnConsumo);
            this.pnlIzquierdo.Controls.Add(this.btnComercial);
            this.pnlIzquierdo.Controls.Add(this.lblNombre);
            this.bunifuTransitionForm.SetDecoration(this.pnlIzquierdo, BunifuAnimatorNS.DecorationType.None);
            this.pnlIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlIzquierdo.Location = new System.Drawing.Point(0, 52);
            this.pnlIzquierdo.Name = "pnlIzquierdo";
            this.pnlIzquierdo.Size = new System.Drawing.Size(140, 497);
            this.pnlIzquierdo.TabIndex = 0;
            // 
            // btnDocumentacion
            // 
            this.btnDocumentacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransitionForm.SetDecoration(this.btnDocumentacion, BunifuAnimatorNS.DecorationType.None);
            this.btnDocumentacion.FlatAppearance.BorderSize = 0;
            this.btnDocumentacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnDocumentacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocumentacion.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocumentacion.ForeColor = System.Drawing.Color.White;
            this.btnDocumentacion.Image = global::Presentacion.Properties.Resources.documento;
            this.btnDocumentacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDocumentacion.Location = new System.Drawing.Point(0, 310);
            this.btnDocumentacion.Name = "btnDocumentacion";
            this.btnDocumentacion.Size = new System.Drawing.Size(140, 30);
            this.btnDocumentacion.TabIndex = 5;
            this.btnDocumentacion.Text = "Guía";
            this.btnDocumentacion.UseVisualStyleBackColor = true;
            // 
            // pnlFlecha
            // 
            this.pnlFlecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pnlFlecha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuTransitionForm.SetDecoration(this.pnlFlecha, BunifuAnimatorNS.DecorationType.None);
            this.pnlFlecha.Location = new System.Drawing.Point(0, 211);
            this.pnlFlecha.Name = "pnlFlecha";
            this.pnlFlecha.Size = new System.Drawing.Size(4, 25);
            this.pnlFlecha.TabIndex = 2;
            this.pnlFlecha.Visible = false;
            // 
            // btnMicro
            // 
            this.btnMicro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransitionForm.SetDecoration(this.btnMicro, BunifuAnimatorNS.DecorationType.None);
            this.btnMicro.FlatAppearance.BorderSize = 0;
            this.btnMicro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnMicro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMicro.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMicro.ForeColor = System.Drawing.Color.White;
            this.btnMicro.Image = global::Presentacion.Properties.Resources.Micro__1_;
            this.btnMicro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMicro.Location = new System.Drawing.Point(0, 277);
            this.btnMicro.Name = "btnMicro";
            this.btnMicro.Size = new System.Drawing.Size(140, 30);
            this.btnMicro.TabIndex = 4;
            this.btnMicro.Text = " Micro";
            this.btnMicro.UseVisualStyleBackColor = true;
            // 
            // btnVivienda
            // 
            this.btnVivienda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransitionForm.SetDecoration(this.btnVivienda, BunifuAnimatorNS.DecorationType.None);
            this.btnVivienda.FlatAppearance.BorderSize = 0;
            this.btnVivienda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnVivienda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVivienda.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVivienda.ForeColor = System.Drawing.Color.White;
            this.btnVivienda.Image = global::Presentacion.Properties.Resources.vivienda__1_;
            this.btnVivienda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVivienda.Location = new System.Drawing.Point(0, 245);
            this.btnVivienda.Name = "btnVivienda";
            this.btnVivienda.Size = new System.Drawing.Size(140, 30);
            this.btnVivienda.TabIndex = 3;
            this.btnVivienda.Text = "      Vivienda";
            this.btnVivienda.UseVisualStyleBackColor = true;
            // 
            // btnConsumo
            // 
            this.btnConsumo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransitionForm.SetDecoration(this.btnConsumo, BunifuAnimatorNS.DecorationType.None);
            this.btnConsumo.FlatAppearance.BorderSize = 0;
            this.btnConsumo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnConsumo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsumo.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsumo.ForeColor = System.Drawing.Color.White;
            this.btnConsumo.Image = global::Presentacion.Properties.Resources.consumo__1_;
            this.btnConsumo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsumo.Location = new System.Drawing.Point(0, 181);
            this.btnConsumo.Name = "btnConsumo";
            this.btnConsumo.Size = new System.Drawing.Size(140, 30);
            this.btnConsumo.TabIndex = 1;
            this.btnConsumo.Text = "       Consumo";
            this.btnConsumo.UseVisualStyleBackColor = true;
            // 
            // btnComercial
            // 
            this.btnComercial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransitionForm.SetDecoration(this.btnComercial, BunifuAnimatorNS.DecorationType.None);
            this.btnComercial.FlatAppearance.BorderSize = 0;
            this.btnComercial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnComercial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComercial.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComercial.ForeColor = System.Drawing.Color.White;
            this.btnComercial.Image = global::Presentacion.Properties.Resources.empresa__2_;
            this.btnComercial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComercial.Location = new System.Drawing.Point(0, 213);
            this.btnComercial.Name = "btnComercial";
            this.btnComercial.Size = new System.Drawing.Size(140, 30);
            this.btnComercial.TabIndex = 2;
            this.btnComercial.Text = "         Comercial";
            this.btnComercial.UseVisualStyleBackColor = true;
            this.btnComercial.Click += new System.EventHandler(this.btnComercial_Click);
            // 
            // lblNombre
            // 
            this.bunifuTransitionForm.SetDecoration(this.lblNombre, BunifuAnimatorNS.DecorationType.None);
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(3, 3);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(137, 33);
            this.lblNombre.TabIndex = 0;
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
            this.elipseForm.ElipseRadius = 4;
            this.elipseForm.TargetControl = this;
            // 
            // bunifuTransitionForm
            // 
            this.bunifuTransitionForm.AnimationType = BunifuAnimatorNS.AnimationType.Mosaic;
            this.bunifuTransitionForm.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 20;
            animation1.Padding = new System.Windows.Forms.Padding(30);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuTransitionForm.DefaultAnimation = animation1;
            this.bunifuTransitionForm.MaxAnimationTime = 2500;
            // 
            // elipseBtnSalario
            // 
            this.elipseBtnSalario.ElipseRadius = 6;
            this.elipseBtnSalario.TargetControl = this;
            // 
            // ttFormPrincipal
            // 
            this.ttFormPrincipal.ForeColor = System.Drawing.Color.Gray;
            this.ttFormPrincipal.IsBalloon = true;
            this.ttFormPrincipal.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttFormPrincipal.ToolTipTitle = "Información:";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this.pnlBotonesColores;
            // 
            // FormVentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1043, 549);
            this.Controls.Add(this.pnlCentro);
            this.Controls.Add(this.pnlIzquierdo);
            this.Controls.Add(this.pnlSuperior);
            this.bunifuTransitionForm.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(1043, 549);
            this.MinimumSize = new System.Drawing.Size(1043, 549);
            this.Name = "FormVentanaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlSuperior.ResumeLayout(false);
            this.pnlBotonesColores.ResumeLayout(false);
            this.pnlCentro.ResumeLayout(false);
            this.pnlCentro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).EndInit();
            this.pnlIzquierdo.ResumeLayout(false);
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
        public System.Windows.Forms.Label lblSenaCom;
        public System.Windows.Forms.Label lblSenaComunica;
        private Bunifu.Framework.UI.BunifuDragControl dragForm;
        private Bunifu.Framework.UI.BunifuElipse elipseForm;
        public BunifuAnimatorNS.BunifuTransition bunifuTransitionForm;
        public System.Windows.Forms.Button btnYoutube;
        public System.Windows.Forms.Button btnTwitter;
        public System.Windows.Forms.Button btnFacebook;
        public System.Windows.Forms.Button btnInstagram;
        public System.Windows.Forms.Button btnPagina;
        private Bunifu.Framework.UI.BunifuElipse elipseBtnSalario;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.LinkLabel linkLblSalario;
        public System.Windows.Forms.ToolTip ttFormPrincipal;
        public System.Windows.Forms.Button btnDocumentacion;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        public System.Windows.Forms.Panel pnlBotonesColores;
    }
}
namespace Presentacion.Ventanas.VentanaAviso
{
    partial class FormAviso
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
            this.elipseFormAviso = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnListo = new System.Windows.Forms.Button();
            this.elipseBtnListo = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlCentro = new System.Windows.Forms.Panel();
            this.lblSimulador = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dragForm = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.timerForm = new System.Windows.Forms.Timer(this.components);
            this.dragPnlSuperior = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.dragLblTitulo = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.draglblMensaje = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlCentro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // elipseFormAviso
            // 
            this.elipseFormAviso.ElipseRadius = 7;
            this.elipseFormAviso.TargetControl = this;
            // 
            // lblMensaje
            // 
            this.lblMensaje.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblMensaje.Location = new System.Drawing.Point(91, 27);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(294, 63);
            this.lblMensaje.TabIndex = 1;
            this.lblMensaje.Text = "Mensaje";
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnListo
            // 
            this.btnListo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(183)))), ((int)(((byte)(211)))));
            this.btnListo.FlatAppearance.BorderSize = 0;
            this.btnListo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListo.ForeColor = System.Drawing.Color.White;
            this.btnListo.Location = new System.Drawing.Point(222, 109);
            this.btnListo.Name = "btnListo";
            this.btnListo.Size = new System.Drawing.Size(113, 26);
            this.btnListo.TabIndex = 2;
            this.btnListo.Text = "Listo";
            this.btnListo.UseVisualStyleBackColor = false;
            // 
            // elipseBtnListo
            // 
            this.elipseBtnListo.ElipseRadius = 7;
            this.elipseBtnListo.TargetControl = this.btnListo;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(155, 4);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(87, 25);
            this.lblTitulo.TabIndex = 17;
            this.lblTitulo.Text = "CORRECTO";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.Controls.Add(this.pictureBox1);
            this.pnlSuperior.Controls.Add(this.lblTitulo);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(397, 33);
            this.pnlSuperior.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Presentacion.Properties.Resources.ok;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(135, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 22);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlCentro
            // 
            this.pnlCentro.BackColor = System.Drawing.Color.Ivory;
            this.pnlCentro.Controls.Add(this.lblSimulador);
            this.pnlCentro.Controls.Add(this.lblMensaje);
            this.pnlCentro.Controls.Add(this.btnListo);
            this.pnlCentro.Controls.Add(this.pictureBox2);
            this.pnlCentro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCentro.Location = new System.Drawing.Point(0, 33);
            this.pnlCentro.Name = "pnlCentro";
            this.pnlCentro.Size = new System.Drawing.Size(397, 156);
            this.pnlCentro.TabIndex = 19;
            // 
            // lblSimulador
            // 
            this.lblSimulador.AutoSize = true;
            this.lblSimulador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(183)))), ((int)(((byte)(211)))));
            this.lblSimulador.Font = new System.Drawing.Font("Century Gothic", 6F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSimulador.ForeColor = System.Drawing.Color.White;
            this.lblSimulador.Location = new System.Drawing.Point(6, 122);
            this.lblSimulador.Name = "lblSimulador";
            this.lblSimulador.Size = new System.Drawing.Size(89, 24);
            this.lblSimulador.TabIndex = 25;
            this.lblSimulador.Text = "Simulador de créditos\r\nSENA";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Presentacion.Properties.Resources.diseñoFondoAzul;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(-2, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(163, 140);
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // dragForm
            // 
            this.dragForm.Fixed = true;
            this.dragForm.Horizontal = true;
            this.dragForm.TargetControl = this.pnlCentro;
            this.dragForm.Vertical = true;
            // 
            // timerForm
            // 
            this.timerForm.Enabled = true;
            this.timerForm.Interval = 2;
            // 
            // dragPnlSuperior
            // 
            this.dragPnlSuperior.Fixed = true;
            this.dragPnlSuperior.Horizontal = true;
            this.dragPnlSuperior.TargetControl = this.pnlSuperior;
            this.dragPnlSuperior.Vertical = true;
            // 
            // dragLblTitulo
            // 
            this.dragLblTitulo.Fixed = true;
            this.dragLblTitulo.Horizontal = true;
            this.dragLblTitulo.TargetControl = this.lblTitulo;
            this.dragLblTitulo.Vertical = true;
            // 
            // draglblMensaje
            // 
            this.draglblMensaje.Fixed = true;
            this.draglblMensaje.Horizontal = true;
            this.draglblMensaje.TargetControl = this.lblMensaje;
            this.draglblMensaje.Vertical = true;
            // 
            // FormAviso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(183)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(397, 189);
            this.Controls.Add(this.pnlCentro);
            this.Controls.Add(this.pnlSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAviso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAviso";
            this.pnlSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlCentro.ResumeLayout(false);
            this.pnlCentro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse elipseFormAviso;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label lblTitulo;
        private Bunifu.Framework.UI.BunifuElipse elipseBtnListo;
        public System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Panel pnlCentro;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuDragControl dragForm;
        public System.Windows.Forms.Timer timerForm;
        public System.Windows.Forms.Label lblSimulador;
        public System.Windows.Forms.Button btnListo;
        private Bunifu.Framework.UI.BunifuDragControl dragPnlSuperior;
        private Bunifu.Framework.UI.BunifuDragControl dragLblTitulo;
        private Bunifu.Framework.UI.BunifuDragControl draglblMensaje;
    }
}
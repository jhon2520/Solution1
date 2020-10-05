namespace Presentacion.Ventanas.VentanaError
{
    partial class FormError
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
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnListo = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.elipseFormError = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.timerForm = new System.Windows.Forms.Timer(this.components);
            this.elipseBtnListo = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.elipsePnl = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lblSimulador = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dragForm = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.dragPnlSuperior = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.dragLblMensaje = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.dragLblTitulo = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMensaje
            // 
            this.lblMensaje.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblMensaje.Location = new System.Drawing.Point(91, 61);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(294, 63);
            this.lblMensaje.TabIndex = 19;
            this.lblMensaje.Text = "Mensaje";
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnListo
            // 
            this.btnListo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(93)))), ((int)(((byte)(78)))));
            this.btnListo.FlatAppearance.BorderSize = 0;
            this.btnListo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListo.ForeColor = System.Drawing.Color.White;
            this.btnListo.Location = new System.Drawing.Point(222, 142);
            this.btnListo.Name = "btnListo";
            this.btnListo.Size = new System.Drawing.Size(113, 26);
            this.btnListo.TabIndex = 20;
            this.btnListo.Text = "Listo";
            this.btnListo.UseVisualStyleBackColor = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(166, 4);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(65, 25);
            this.lblTitulo.TabIndex = 21;
            this.lblTitulo.Text = "ERROR";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(93)))), ((int)(((byte)(78)))));
            this.pnlTitulo.Controls.Add(this.pictureBox1);
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(397, 33);
            this.pnlTitulo.TabIndex = 23;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Presentacion.Properties.Resources.cerrarVentana;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(150, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 22);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // elipseFormError
            // 
            this.elipseFormError.ElipseRadius = 7;
            this.elipseFormError.TargetControl = this;
            // 
            // timerForm
            // 
            this.timerForm.Enabled = true;
            this.timerForm.Interval = 2;
            // 
            // elipseBtnListo
            // 
            this.elipseBtnListo.ElipseRadius = 7;
            this.elipseBtnListo.TargetControl = this.btnListo;
            // 
            // elipsePnl
            // 
            this.elipsePnl.ElipseRadius = 7;
            this.elipsePnl.TargetControl = this.pnlTitulo;
            // 
            // lblSimulador
            // 
            this.lblSimulador.AutoSize = true;
            this.lblSimulador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(93)))), ((int)(((byte)(78)))));
            this.lblSimulador.Font = new System.Drawing.Font("Century Gothic", 6F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSimulador.ForeColor = System.Drawing.Color.White;
            this.lblSimulador.Location = new System.Drawing.Point(5, 156);
            this.lblSimulador.Name = "lblSimulador";
            this.lblSimulador.Size = new System.Drawing.Size(89, 24);
            this.lblSimulador.TabIndex = 24;
            this.lblSimulador.Text = "Simulador de créditos\r\nSENA";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Presentacion.Properties.Resources.diseñoFondoRojo;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(-3, 61);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(163, 140);
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // dragForm
            // 
            this.dragForm.Fixed = true;
            this.dragForm.Horizontal = true;
            this.dragForm.TargetControl = this;
            this.dragForm.Vertical = true;
            // 
            // dragPnlSuperior
            // 
            this.dragPnlSuperior.Fixed = true;
            this.dragPnlSuperior.Horizontal = true;
            this.dragPnlSuperior.TargetControl = this.pnlTitulo;
            this.dragPnlSuperior.Vertical = true;
            // 
            // dragLblMensaje
            // 
            this.dragLblMensaje.Fixed = true;
            this.dragLblMensaje.Horizontal = true;
            this.dragLblMensaje.TargetControl = this.lblMensaje;
            this.dragLblMensaje.Vertical = true;
            // 
            // dragLblTitulo
            // 
            this.dragLblTitulo.Fixed = true;
            this.dragLblTitulo.Horizontal = true;
            this.dragLblTitulo.TargetControl = this.lblTitulo;
            this.dragLblTitulo.Vertical = true;
            // 
            // FormError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(397, 189);
            this.Controls.Add(this.lblSimulador);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnListo);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormError";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormError";
            this.pnlTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuElipse elipseFormError;
        public System.Windows.Forms.Timer timerForm;
        private Bunifu.Framework.UI.BunifuElipse elipseBtnListo;
        private Bunifu.Framework.UI.BunifuElipse elipsePnl;
        public System.Windows.Forms.Label lblSimulador;
        public System.Windows.Forms.Button btnListo;
        private Bunifu.Framework.UI.BunifuDragControl dragForm;
        private Bunifu.Framework.UI.BunifuDragControl dragPnlSuperior;
        private Bunifu.Framework.UI.BunifuDragControl dragLblMensaje;
        private Bunifu.Framework.UI.BunifuDragControl dragLblTitulo;
    }
}
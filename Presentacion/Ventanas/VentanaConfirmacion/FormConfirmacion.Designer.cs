namespace Presentacion.Ventanas.VentanaConfirmacion
{
    partial class FormConfirmacion
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
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnListo = new System.Windows.Forms.Button();
            this.elipseBtnListo = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lblSimulador = new System.Windows.Forms.Label();
            this.btnNo = new System.Windows.Forms.Button();
            this.elipseBtnNo = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.elipseForm = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.timerForm = new System.Windows.Forms.Timer(this.components);
            this.dragPnlSuperior = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.dragLblTitulo = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.dragLblMensaje = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.dragForm = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pnlSuperior.Controls.Add(this.pictureBox3);
            this.pnlSuperior.Controls.Add(this.pictureBox1);
            this.pnlSuperior.Controls.Add(this.lblTitulo);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(397, 33);
            this.pnlSuperior.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::Presentacion.Properties.Resources.pregunta1;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(128, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(22, 22);
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Presentacion.Properties.Resources.pregunta;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(145, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 22);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(165, 4);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(98, 25);
            this.lblTitulo.TabIndex = 19;
            this.lblTitulo.Text = "CONFIRMAR";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMensaje
            // 
            this.lblMensaje.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblMensaje.Location = new System.Drawing.Point(91, 61);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(294, 63);
            this.lblMensaje.TabIndex = 20;
            this.lblMensaje.Text = "Mensaje";
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnListo
            // 
            this.btnListo.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnListo.FlatAppearance.BorderSize = 0;
            this.btnListo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListo.ForeColor = System.Drawing.Color.White;
            this.btnListo.Location = new System.Drawing.Point(147, 145);
            this.btnListo.Name = "btnListo";
            this.btnListo.Size = new System.Drawing.Size(113, 26);
            this.btnListo.TabIndex = 21;
            this.btnListo.Text = "SI";
            this.btnListo.UseVisualStyleBackColor = false;
            // 
            // elipseBtnListo
            // 
            this.elipseBtnListo.ElipseRadius = 7;
            this.elipseBtnListo.TargetControl = this.btnListo;
            // 
            // lblSimulador
            // 
            this.lblSimulador.AutoSize = true;
            this.lblSimulador.BackColor = System.Drawing.Color.LightSeaGreen;
            this.lblSimulador.Font = new System.Drawing.Font("Century Gothic", 6F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSimulador.ForeColor = System.Drawing.Color.White;
            this.lblSimulador.Location = new System.Drawing.Point(7, 156);
            this.lblSimulador.Name = "lblSimulador";
            this.lblSimulador.Size = new System.Drawing.Size(89, 24);
            this.lblSimulador.TabIndex = 26;
            this.lblSimulador.Text = "Simulador de créditos\r\nSENA";
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(93)))), ((int)(((byte)(78)))));
            this.btnNo.FlatAppearance.BorderSize = 0;
            this.btnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo.ForeColor = System.Drawing.Color.White;
            this.btnNo.Location = new System.Drawing.Point(270, 145);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(113, 26);
            this.btnNo.TabIndex = 27;
            this.btnNo.Text = "NO";
            this.btnNo.UseVisualStyleBackColor = false;
            // 
            // elipseBtnNo
            // 
            this.elipseBtnNo.ElipseRadius = 7;
            this.elipseBtnNo.TargetControl = this.btnNo;
            // 
            // elipseForm
            // 
            this.elipseForm.ElipseRadius = 7;
            this.elipseForm.TargetControl = this;
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
            // dragLblMensaje
            // 
            this.dragLblMensaje.Fixed = true;
            this.dragLblMensaje.Horizontal = true;
            this.dragLblMensaje.TargetControl = this.lblMensaje;
            this.dragLblMensaje.Vertical = true;
            // 
            // dragForm
            // 
            this.dragForm.Fixed = true;
            this.dragForm.Horizontal = true;
            this.dragForm.TargetControl = this;
            this.dragForm.Vertical = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Presentacion.Properties.Resources.diseñoFondoVerde;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(-2, 61);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(163, 140);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // FormConfirmacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(397, 189);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.lblSimulador);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnListo);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pnlSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormConfirmacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormConfirmacion";
            this.pnlSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Label lblMensaje;
        public System.Windows.Forms.Button btnListo;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label lblTitulo;
        private Bunifu.Framework.UI.BunifuElipse elipseBtnListo;
        public System.Windows.Forms.Label lblSimulador;
        public System.Windows.Forms.Button btnNo;
        private Bunifu.Framework.UI.BunifuElipse elipseBtnNo;
        private Bunifu.Framework.UI.BunifuElipse elipseForm;
        public System.Windows.Forms.Timer timerForm;
        private Bunifu.Framework.UI.BunifuDragControl dragPnlSuperior;
        private Bunifu.Framework.UI.BunifuDragControl dragLblTitulo;
        private Bunifu.Framework.UI.BunifuDragControl dragLblMensaje;
        private Bunifu.Framework.UI.BunifuDragControl dragForm;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
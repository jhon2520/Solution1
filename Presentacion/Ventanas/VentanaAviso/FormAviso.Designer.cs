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
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnListo = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.pnlCentro = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timerForm = new System.Windows.Forms.Timer(this.components);
            this.dragForm = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.elipseForm = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.elipseBtnListo = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlSuperior.SuspendLayout();
            this.pnlCentro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMensaje
            // 
            this.lblMensaje.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblMensaje.Location = new System.Drawing.Point(12, 7);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(373, 78);
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
            this.btnListo.Location = new System.Drawing.Point(142, 91);
            this.btnListo.Name = "btnListo";
            this.btnListo.Size = new System.Drawing.Size(113, 26);
            this.btnListo.TabIndex = 2;
            this.btnListo.Text = "Listo";
            this.btnListo.UseVisualStyleBackColor = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(155, 2);
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
            this.pnlSuperior.Controls.Add(this.pictureBox2);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(397, 33);
            this.pnlSuperior.TabIndex = 18;
            // 
            // pnlCentro
            // 
            this.pnlCentro.BackColor = System.Drawing.Color.AliceBlue;
            this.pnlCentro.Controls.Add(this.label3);
            this.pnlCentro.Controls.Add(this.label2);
            this.pnlCentro.Controls.Add(this.lblMensaje);
            this.pnlCentro.Controls.Add(this.btnListo);
            this.pnlCentro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCentro.Location = new System.Drawing.Point(0, 33);
            this.pnlCentro.Name = "pnlCentro";
            this.pnlCentro.Size = new System.Drawing.Size(397, 156);
            this.pnlCentro.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(100)))), ((int)(((byte)(26)))));
            this.label3.Location = new System.Drawing.Point(197, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "www.sena.edu.co";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(87)))), ((int)(((byte)(86)))));
            this.label2.Location = new System.Drawing.Point(91, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "@SENAcomunica";
            // 
            // timerForm
            // 
            this.timerForm.Enabled = true;
            this.timerForm.Interval = 2;
            // 
            // dragForm
            // 
            this.dragForm.Fixed = true;
            this.dragForm.Horizontal = true;
            this.dragForm.TargetControl = this.pictureBox2;
            this.dragForm.Vertical = true;
            // 
            // elipseForm
            // 
            this.elipseForm.ElipseRadius = 7;
            this.elipseForm.TargetControl = this;
            // 
            // elipseBtnListo
            // 
            this.elipseBtnListo.ElipseRadius = 7;
            this.elipseBtnListo.TargetControl = this.btnListo;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Presentacion.Properties.Resources.ok;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(134, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 22);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Presentacion.Properties.Resources.diseñoFondoAzul;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(-3, -107);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(455, 155);
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
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
            this.pnlCentro.ResumeLayout(false);
            this.pnlCentro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label lblTitulo;
        public System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Panel pnlCentro;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Timer timerForm;
        public System.Windows.Forms.Button btnListo;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuDragControl dragForm;
        private Bunifu.Framework.UI.BunifuElipse elipseForm;
        private Bunifu.Framework.UI.BunifuElipse elipseBtnListo;
    }
}
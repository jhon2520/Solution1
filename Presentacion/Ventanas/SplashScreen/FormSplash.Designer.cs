
namespace Presentacion.Ventanas.SplashScreen
{
    partial class FormSplash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSplash));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlBarra = new System.Windows.Forms.Panel();
            this.lblCargando = new System.Windows.Forms.Label();
            this.lblMensajeInferior = new System.Windows.Forms.Label();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.timerLbl = new System.Windows.Forms.Timer(this.components);
            this.dragForm = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.LblCantidadDeCarga = new System.Windows.Forms.Label();
            this.timerForm = new System.Windows.Forms.Timer(this.components);
            this.timerEstiloLogin = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlBarra);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 300);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 35);
            this.panel1.TabIndex = 0;
            // 
            // pnlBarra
            // 
            this.pnlBarra.BackColor = System.Drawing.Color.Teal;
            this.pnlBarra.Location = new System.Drawing.Point(0, 1);
            this.pnlBarra.Name = "pnlBarra";
            this.pnlBarra.Size = new System.Drawing.Size(10, 34);
            this.pnlBarra.TabIndex = 1;
            // 
            // lblCargando
            // 
            this.lblCargando.AutoSize = true;
            this.lblCargando.Font = new System.Drawing.Font("mononoki Nerd Font", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargando.Location = new System.Drawing.Point(212, 124);
            this.lblCargando.Name = "lblCargando";
            this.lblCargando.Size = new System.Drawing.Size(226, 38);
            this.lblCargando.TabIndex = 1;
            this.lblCargando.Text = "Cargando...";
            // 
            // lblMensajeInferior
            // 
            this.lblMensajeInferior.AutoSize = true;
            this.lblMensajeInferior.Font = new System.Drawing.Font("mononoki Nerd Font", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajeInferior.Location = new System.Drawing.Point(3, 285);
            this.lblMensajeInferior.Name = "lblMensajeInferior";
            this.lblMensajeInferior.Size = new System.Drawing.Size(49, 13);
            this.lblMensajeInferior.TabIndex = 2;
            this.lblMensajeInferior.Text = "Mensaje";
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMensaje.Font = new System.Drawing.Font("mononoki Nerd Font", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(242, 177);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(155, 27);
            this.lblMensaje.TabIndex = 2;
            this.lblMensaje.Text = "Bienvenido ";
            // 
            // timerLbl
            // 
            this.timerLbl.Enabled = true;
            this.timerLbl.Interval = 380;
            // 
            // dragForm
            // 
            this.dragForm.Fixed = true;
            this.dragForm.Horizontal = true;
            this.dragForm.TargetControl = this;
            this.dragForm.Vertical = true;
            // 
            // LblCantidadDeCarga
            // 
            this.LblCantidadDeCarga.AutoSize = true;
            this.LblCantidadDeCarga.Font = new System.Drawing.Font("mononoki Nerd Font", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantidadDeCarga.Location = new System.Drawing.Point(615, 281);
            this.LblCantidadDeCarga.Name = "LblCantidadDeCarga";
            this.LblCantidadDeCarga.Size = new System.Drawing.Size(17, 18);
            this.LblCantidadDeCarga.TabIndex = 3;
            this.LblCantidadDeCarga.Text = "0";
            // 
            // timerForm
            // 
            this.timerForm.Enabled = true;
            this.timerForm.Interval = 2;
            // 
            // timerEstiloLogin
            // 
            this.timerEstiloLogin.Enabled = true;
            this.timerEstiloLogin.Interval = 10;
            // 
            // FormSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(650, 335);
            this.Controls.Add(this.LblCantidadDeCarga);
            this.Controls.Add(this.lblMensajeInferior);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.lblCargando);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSplash";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel pnlBarra;
        public System.Windows.Forms.Label lblMensaje;
        public System.Windows.Forms.Label lblCargando;
        public System.Windows.Forms.Timer timerLbl;
        public System.Windows.Forms.Label lblMensajeInferior;
        private Bunifu.Framework.UI.BunifuDragControl dragForm;
        public System.Windows.Forms.Label LblCantidadDeCarga;
        public System.Windows.Forms.Timer timerForm;
        public System.Windows.Forms.Timer timerEstiloLogin;
    }
}
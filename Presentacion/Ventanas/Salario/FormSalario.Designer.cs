namespace Presentacion.Ventanas.Salario
{
    partial class FormSalario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSalario));
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxSalario = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGuardarSalario = new System.Windows.Forms.Button();
            this.elipseBtnGuardar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dragForm = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.elipseForm = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.timerForm = new System.Windows.Forms.Timer(this.components);
            this.ttSalario = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            resources.ApplyResources(this.btnCerrar, "btnCerrar");
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            // 
            // tbxSalario
            // 
            this.tbxSalario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.tbxSalario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.tbxSalario, "tbxSalario");
            this.tbxSalario.ForeColor = System.Drawing.Color.White;
            this.tbxSalario.Name = "tbxSalario";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // btnGuardarSalario
            // 
            this.btnGuardarSalario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarSalario.FlatAppearance.BorderSize = 0;
            this.btnGuardarSalario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnGuardarSalario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            resources.ApplyResources(this.btnGuardarSalario, "btnGuardarSalario");
            this.btnGuardarSalario.ForeColor = System.Drawing.Color.White;
            this.btnGuardarSalario.Name = "btnGuardarSalario";
            this.btnGuardarSalario.UseVisualStyleBackColor = true;
            // 
            // elipseBtnGuardar
            // 
            this.elipseBtnGuardar.ElipseRadius = 4;
            this.elipseBtnGuardar.TargetControl = this.btnGuardarSalario;
            // 
            // dragForm
            // 
            this.dragForm.Fixed = true;
            this.dragForm.Horizontal = true;
            this.dragForm.TargetControl = this;
            this.dragForm.Vertical = true;
            // 
            // elipseForm
            // 
            this.elipseForm.ElipseRadius = 5;
            this.elipseForm.TargetControl = this;
            // 
            // timerForm
            // 
            this.timerForm.Enabled = true;
            this.timerForm.Interval = 2;
            // 
            // ttSalario
            // 
            this.ttSalario.IsBalloon = true;
            this.ttSalario.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttSalario.ToolTipTitle = "Información:";
            // 
            // FormSalario
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.Controls.Add(this.btnGuardarSalario);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbxSalario);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSalario";
            this.ShowInTaskbar = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btnGuardarSalario;
        private Bunifu.Framework.UI.BunifuElipse elipseBtnGuardar;
        private Bunifu.Framework.UI.BunifuDragControl dragForm;
        private Bunifu.Framework.UI.BunifuElipse elipseForm;
        public System.Windows.Forms.TextBox tbxSalario;
        public System.Windows.Forms.Timer timerForm;
        public System.Windows.Forms.ToolTip ttSalario;
    }
}
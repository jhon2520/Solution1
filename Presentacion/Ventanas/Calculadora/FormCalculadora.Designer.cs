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
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pnlLinea1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.tbxAConvertir = new System.Windows.Forms.TextBox();
            this.rbtTasaNominal1 = new System.Windows.Forms.RadioButton();
            this.rbtTasaEfectiva1 = new System.Windows.Forms.RadioButton();
            this.rbtTasaEfectiva2 = new System.Windows.Forms.RadioButton();
            this.rbtTasaNominal2 = new System.Windows.Forms.RadioButton();
            this.pnlLinea2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxConvertida = new System.Windows.Forms.TextBox();
            this.btnConvertirTasa = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.timerForm = new System.Windows.Forms.Timer(this.components);
            this.elipseForm = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.elipseBtnConvertir = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.elipseBtnNuevo = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.DragForm = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ttCalculadora = new System.Windows.Forms.ToolTip(this.components);
            this.pnlSuperiorForm.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSuperiorForm
            // 
            this.pnlSuperiorForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(100)))), ((int)(((byte)(26)))));
            this.pnlSuperiorForm.Controls.Add(this.btnCerrar);
            this.pnlSuperiorForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperiorForm.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperiorForm.Name = "pnlSuperiorForm";
            this.pnlSuperiorForm.Size = new System.Drawing.Size(417, 36);
            this.pnlSuperiorForm.TabIndex = 2;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrar.BackgroundImage")));
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(397, 1);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(18, 18);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.UseVisualStyleBackColor = false;
            // 
            // pnlLinea1
            // 
            this.pnlLinea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pnlLinea1.Location = new System.Drawing.Point(186, 104);
            this.pnlLinea1.Name = "pnlLinea1";
            this.pnlLinea1.Size = new System.Drawing.Size(75, 1);
            this.pnlLinea1.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DimGray;
            this.label12.Location = new System.Drawing.Point(79, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 16);
            this.label12.TabIndex = 14;
            this.label12.Text = "Tasa a convertir";
            // 
            // tbxAConvertir
            // 
            this.tbxAConvertir.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxAConvertir.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxAConvertir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAConvertir.ForeColor = System.Drawing.Color.DimGray;
            this.tbxAConvertir.Location = new System.Drawing.Point(186, 85);
            this.tbxAConvertir.Multiline = true;
            this.tbxAConvertir.Name = "tbxAConvertir";
            this.tbxAConvertir.Size = new System.Drawing.Size(75, 20);
            this.tbxAConvertir.TabIndex = 12;
            this.tbxAConvertir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rbtTasaNominal1
            // 
            this.rbtTasaNominal1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtTasaNominal1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtTasaNominal1.ForeColor = System.Drawing.Color.DimGray;
            this.rbtTasaNominal1.Location = new System.Drawing.Point(11, 11);
            this.rbtTasaNominal1.Name = "rbtTasaNominal1";
            this.rbtTasaNominal1.Size = new System.Drawing.Size(55, 24);
            this.rbtTasaNominal1.TabIndex = 15;
            this.rbtTasaNominal1.TabStop = true;
            this.rbtTasaNominal1.Text = "NM";
            this.rbtTasaNominal1.UseVisualStyleBackColor = true;
            // 
            // rbtTasaEfectiva1
            // 
            this.rbtTasaEfectiva1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtTasaEfectiva1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtTasaEfectiva1.ForeColor = System.Drawing.Color.DimGray;
            this.rbtTasaEfectiva1.Location = new System.Drawing.Point(11, 37);
            this.rbtTasaEfectiva1.Name = "rbtTasaEfectiva1";
            this.rbtTasaEfectiva1.Size = new System.Drawing.Size(55, 24);
            this.rbtTasaEfectiva1.TabIndex = 16;
            this.rbtTasaEfectiva1.TabStop = true;
            this.rbtTasaEfectiva1.Text = "EA";
            this.rbtTasaEfectiva1.UseVisualStyleBackColor = true;
            // 
            // rbtTasaEfectiva2
            // 
            this.rbtTasaEfectiva2.Enabled = false;
            this.rbtTasaEfectiva2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtTasaEfectiva2.ForeColor = System.Drawing.Color.DimGray;
            this.rbtTasaEfectiva2.Location = new System.Drawing.Point(11, 32);
            this.rbtTasaEfectiva2.Name = "rbtTasaEfectiva2";
            this.rbtTasaEfectiva2.Size = new System.Drawing.Size(55, 24);
            this.rbtTasaEfectiva2.TabIndex = 21;
            this.rbtTasaEfectiva2.TabStop = true;
            this.rbtTasaEfectiva2.Text = "EA";
            this.rbtTasaEfectiva2.UseVisualStyleBackColor = true;
            // 
            // rbtTasaNominal2
            // 
            this.rbtTasaNominal2.Enabled = false;
            this.rbtTasaNominal2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtTasaNominal2.ForeColor = System.Drawing.Color.DimGray;
            this.rbtTasaNominal2.Location = new System.Drawing.Point(11, 6);
            this.rbtTasaNominal2.Name = "rbtTasaNominal2";
            this.rbtTasaNominal2.Size = new System.Drawing.Size(55, 24);
            this.rbtTasaNominal2.TabIndex = 20;
            this.rbtTasaNominal2.TabStop = true;
            this.rbtTasaNominal2.Text = "NM";
            this.rbtTasaNominal2.UseVisualStyleBackColor = true;
            // 
            // pnlLinea2
            // 
            this.pnlLinea2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pnlLinea2.Location = new System.Drawing.Point(186, 170);
            this.pnlLinea2.Name = "pnlLinea2";
            this.pnlLinea2.Size = new System.Drawing.Size(75, 1);
            this.pnlLinea2.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(79, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Tasa convertida";
            // 
            // tbxConvertida
            // 
            this.tbxConvertida.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxConvertida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxConvertida.Enabled = false;
            this.tbxConvertida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxConvertida.ForeColor = System.Drawing.Color.DimGray;
            this.tbxConvertida.Location = new System.Drawing.Point(186, 151);
            this.tbxConvertida.Multiline = true;
            this.tbxConvertida.Name = "tbxConvertida";
            this.tbxConvertida.Size = new System.Drawing.Size(75, 20);
            this.tbxConvertida.TabIndex = 17;
            this.tbxConvertida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnConvertirTasa
            // 
            this.btnConvertirTasa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(100)))), ((int)(((byte)(26)))));
            this.btnConvertirTasa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConvertirTasa.FlatAppearance.BorderSize = 0;
            this.btnConvertirTasa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvertirTasa.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertirTasa.ForeColor = System.Drawing.Color.White;
            this.btnConvertirTasa.Location = new System.Drawing.Point(156, 223);
            this.btnConvertirTasa.Name = "btnConvertirTasa";
            this.btnConvertirTasa.Size = new System.Drawing.Size(104, 26);
            this.btnConvertirTasa.TabIndex = 23;
            this.btnConvertirTasa.Text = "Convertir";
            this.btnConvertirTasa.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbtTasaNominal1);
            this.panel2.Controls.Add(this.rbtTasaEfectiva1);
            this.panel2.Location = new System.Drawing.Point(261, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(77, 71);
            this.panel2.TabIndex = 28;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rbtTasaEfectiva2);
            this.panel3.Controls.Add(this.rbtTasaNominal2);
            this.panel3.Location = new System.Drawing.Point(261, 140);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(76, 62);
            this.panel3.TabIndex = 29;
            // 
            // timerForm
            // 
            this.timerForm.Enabled = true;
            this.timerForm.Interval = 10;
            // 
            // elipseForm
            // 
            this.elipseForm.ElipseRadius = 5;
            this.elipseForm.TargetControl = this;
            // 
            // elipseBtnConvertir
            // 
            this.elipseBtnConvertir.ElipseRadius = 4;
            this.elipseBtnConvertir.TargetControl = this.btnConvertirTasa;
            // 
            // elipseBtnNuevo
            // 
            this.elipseBtnNuevo.ElipseRadius = 5;
            this.elipseBtnNuevo.TargetControl = this;
            // 
            // DragForm
            // 
            this.DragForm.Fixed = true;
            this.DragForm.Horizontal = true;
            this.DragForm.TargetControl = this.pnlSuperiorForm;
            this.DragForm.Vertical = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Presentacion.Properties.Resources.Flecha;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(108, 111);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 40);
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // ttCalculadora
            // 
            this.ttCalculadora.IsBalloon = true;
            this.ttCalculadora.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttCalculadora.ToolTipTitle = "Información:";
            // 
            // FormCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(417, 277);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnConvertirTasa);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pnlLinea2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxConvertida);
            this.Controls.Add(this.pnlLinea1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbxAConvertir);
            this.Controls.Add(this.pnlSuperiorForm);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCalculadora";
            this.pnlSuperiorForm.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.Button btnConvertirTasa;
        public System.Windows.Forms.RadioButton rbtTasaEfectiva2;
        public System.Windows.Forms.RadioButton rbtTasaNominal2;
        public System.Windows.Forms.Panel pnlLinea2;
        public System.Windows.Forms.TextBox tbxConvertida;
        public System.Windows.Forms.RadioButton rbtTasaEfectiva1;
        public System.Windows.Forms.RadioButton rbtTasaNominal1;
        public System.Windows.Forms.Panel pnlLinea1;
        public System.Windows.Forms.TextBox tbxAConvertir;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Timer timerForm;
        private Bunifu.Framework.UI.BunifuElipse elipseForm;
        private Bunifu.Framework.UI.BunifuElipse elipseBtnConvertir;
        private Bunifu.Framework.UI.BunifuElipse elipseBtnNuevo;
        private Bunifu.Framework.UI.BunifuDragControl DragForm;
        public Panel pnlSuperiorForm;
        public ToolTip ttCalculadora;
    }
}
using Presentacion.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Ventanas.VentanaEmergente
{
    public partial class FormVentanaEmergente : Form
    {
        private int x, y;
        private enmAccion accion;

        public FormVentanaEmergente()
        {
            InitializeComponent();
        }
        public enum enmAccion
        {
            esperar,
            iniciar,
            cerrar
        }
        public enum enmTipo
        {
            exito,
            error,
            info
        }


        private void timerForm_Tick(object sender, EventArgs e)
        {
            switch(this.accion)
            {
                case enmAccion.esperar:
                    timerForm.Interval = 5000;
                    accion = enmAccion.cerrar;
                    break;
                case enmAccion.iniciar:
                    this.Opacity += 0.1;
                    if(this.x < this.Location.X)
                    {
                        this.Left--;
                    }
                    else
                    {
                        if(this.Opacity == 1.0)
                        {
                            accion = enmAccion.esperar;
                        }
                    }
                    break;
                case enmAccion.cerrar:
                    timerForm.Interval = 1;
                    this.Opacity -= 0.1;
                    this.Left -= 3;
                    if(base.Opacity == 0.0)
                    {
                        base.Close();
                    }
                    break;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            timerForm.Interval = 1;
            accion = enmAccion.cerrar;
        }

        public void MostrarAlerta(string mensaje, enmTipo tipo)
        {
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;
            string formName;

            for (int i = 1; i < 10; i++)
            {
                formName = "Alerta" + i.ToString();
                FormVentanaEmergente formAlerta = (FormVentanaEmergente)Application.OpenForms[formName];

                if (formAlerta == null)
                {
                    this.Name = formName;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                    this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i - 5 * i;
                    this.Location = new Point(this.x, this.y);
                    break;
                }

            }
            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;

            switch(tipo)
            {
                case enmTipo.exito:
                    this.pictureBox1.Image = Resources.ok1;
                    this.BackColor = Color.LightSeaGreen;
                    break;
                case enmTipo.error:
                    this.pictureBox1.Image = Resources.error;
                    this.BackColor = Color.FromArgb(215, 93, 78);
                    break;
                case enmTipo.info:
                    this.pictureBox1.Image = Resources.ask_question_60px;
                    this.BackColor = Color.FromArgb(72, 183, 211);
                    break;

            }

            this.lblMensaje.Text = mensaje;

            this.Show();
            this.accion = enmAccion.iniciar;
            this.timerForm.Interval = 1;
            this.timerForm.Start();
            

        }

   
    }
}

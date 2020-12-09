using Presentacion.CodigoCompartido;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Ventanas.SplashScreen
{
    class ControladorFormSplash
    {
        FormSplash formSplash;

        public ControladorFormSplash(FormSplash formSplash)
        {
            this.formSplash = formSplash;
            this.formSplash.Opacity = 0.0;
            this.formSplash.timerForm.Tick += new EventHandler(TimerBarra);
            this.formSplash.timerLbl.Tick += new EventHandler(LabelEstilo);
            this.formSplash.timerEstiloLogin.Tick += new EventHandler(EfectoLogin);
            this.formSplash.MouseDown += new MouseEventHandler(VolverTransparente);
            this.formSplash.MouseUp += new MouseEventHandler(RetornarOpacidad);
            //this.formSplash.Opacity = 0.8;

        }
        private void TimerBarra(object sende, EventArgs args)
        {
            LabelMensajeInferior();
            this.formSplash.pnlBarra.Width += 2;
            this.formSplash.LblCantidadDeCarga.Text = ((this.formSplash.pnlBarra.Width / 6.5)/100).ToString("0%");

            if (this.formSplash.pnlBarra.Width >= 650)
            {
                this.formSplash.timerForm.Stop();
                this.formSplash.Close();
                
            }
        }

        private void LabelEstilo(object sender, EventArgs args)
        {
            if (this.formSplash.lblCargando.Text == "Cargando...") this.formSplash.lblCargando.Text = "Cargando";
            else if (this.formSplash.lblCargando.Text == "Cargando") this.formSplash.lblCargando.Text = "Cargando.";
            else if (this.formSplash.lblCargando.Text == "Cargando.") this.formSplash.lblCargando.Text = "Cargando..";
            else if (this.formSplash.lblCargando.Text == "Cargando..") this.formSplash.lblCargando.Text = "Cargando...";
        }

        private void LabelMensajeInferior()
        {
            if (this.formSplash.pnlBarra.Width < 160)
            {
                this.formSplash.lblMensajeInferior.Text = "Cargando la configuaración inicial del sistema..";
                this.formSplash.pnlBarra.BackColor = Color.FromArgb(37,220,247);
            }
            else if (this.formSplash.pnlBarra.Width >= 160 && this.formSplash.pnlBarra.Width <= 320)
            {
                this.formSplash.lblMensajeInferior.Text = "Cargando politicas internas y generando caché... ";
                this.formSplash.pnlBarra.BackColor = Color.FromArgb(0, 209, 240);
            }
            else if (this.formSplash.pnlBarra.Width >= 320 && this.formSplash.pnlBarra.Width <= 480)
            {
                this.formSplash.lblMensajeInferior.Text = "Generando interfaz de usuario...";
                this.formSplash.pnlBarra.BackColor = Color.FromArgb(0, 190, 247);
            }
            else if (this.formSplash.pnlBarra.Width >= 480)
            {
                this.formSplash.lblMensajeInferior.Text = "Ante cualquier duda, consulte el manual de usuario.";
                this.formSplash.pnlBarra.BackColor = Color.FromArgb(0, 153, 213);
            }
        }
        private void EfectoLogin(object sender, EventArgs args)
        {
            CodigoComun.Timer(this.formSplash, this.formSplash.timerEstiloLogin);
        }
        private void VolverTransparente(object sender, EventArgs args)
        {
            this.formSplash.Opacity = 0.6;
        }
        private void RetornarOpacidad(object sender, EventArgs args)
        {
            this.formSplash.Opacity = 1;
        }
    }
}

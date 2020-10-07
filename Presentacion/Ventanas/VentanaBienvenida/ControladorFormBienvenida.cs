using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentacion.CodigoCompartido;
using SoporteUsuario.CacheUsuario;
using Presentacion.Ventanas.VentanaAviso;
using Presentacion.Ventanas.VentanaError;
using Presentacion.Ventanas.VentanaConfirmacion;
using Presentacion.Ventanas.VentanaPrincipal;

namespace Presentacion.Ventanas.VentanaBienvenida
{
    public class ControladorFormBienvenida
    {
        private FormBienvenida formBienvenida;
        private CodigoComun codigoComun = new CodigoComun();
        private FormAviso formAviso;
        private FormError formError;
        private FormConfirmacion formConfirmacion;
        private FormVentanaPrincipal formVentanaPrincipal;
        public ControladorFormBienvenida(FormBienvenida formBienvenida)
        {
            this.formBienvenida = formBienvenida;

            this.formBienvenida.Opacity = 0.0;
            this.formBienvenida.timerFechaHora.Tick += new EventHandler(TimerFechaHora);
            this.formBienvenida.btnCerrar.Click += new EventHandler(CerrarForm);
            this.formBienvenida.btnMinimizar.Click += new EventHandler(MinimizarForm);
            this.formBienvenida.tbxNombre.Click += new EventHandler(CambiosTbx);
            this.formBienvenida.btnIngresar.Click += new EventHandler(Ingresar);
            this.formBienvenida.timerForm.Tick += new EventHandler(EfectoLogin);
        }

        private void TimerFechaHora(object sender, EventArgs args)
        {
            this.formBienvenida.lblHora.Text = DateTime.Now.ToString("h:mm:ss");
            this.formBienvenida.lblFecha.Text = DateTime.Today.ToString("d");
        }

        private void CerrarForm(object sender, EventArgs args)
        {
            formConfirmacion = new FormConfirmacion("¿Desea salir del simulador?");
            DialogResult resultado = formConfirmacion.ShowDialog();

            if(resultado == DialogResult.OK)
            {
                codigoComun.BtnCerrar(this.formBienvenida);
            }
            
        }

        private void MinimizarForm(object sender, EventArgs args)
        {
            codigoComun.BtnMinimizar(this.formBienvenida);
        }

        private void CambiosTbx(object sender, EventArgs args)
        {
            codigoComun.CambiosTbx(this.formBienvenida.tbxNombre, "Ingrese su nombre", 248, 100, 26);
        }

        private void Ingresar(object sender, EventArgs args)
        {
            if(this.formBienvenida.tbxNombre.Text != "Ingrese su nombre" && this.formBienvenida.tbxNombre.Text != string.Empty)
            { 
                Cache.Nombre = this.formBienvenida.tbxNombre.Text;
                formAviso = new FormAviso("Bienvenido, " + Cache.Nombre + " al sistema de análisis de crédito SENA");
                this.formBienvenida.Hide();
                formAviso.ShowDialog();
                formVentanaPrincipal = new FormVentanaPrincipal();
                formVentanaPrincipal.ShowDialog();
            }
            else
            {
                formError = new FormError("Ingrese su nombre si desea ingresar al simulador.");
                formError.ShowDialog();
            }
        }

        private void EfectoLogin(object sender, EventArgs args)
        {
            codigoComun.Timer(this.formBienvenida, this.formBienvenida.timerForm);
        }
    }
}

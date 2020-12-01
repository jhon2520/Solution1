using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentacion.CodigoCompartido;

namespace Presentacion.Ventanas.VentanaError
{
    class ControladorFormError
    {
        private FormError formError;

        public ControladorFormError(FormError formError)
        {
            this.formError = formError;
            this.formError.Opacity = 0.0;
            this.formError.timerForm.Tick += new EventHandler(EfectoLogin);
            this.formError.btnListo.Click += new EventHandler(Cerrar);
            this.formError.pnlTitulo.MouseDown += new MouseEventHandler(VolverTransparente);
            this.formError.pnlTitulo.MouseUp += new MouseEventHandler(RetornarOpacidad);
        }

        public void EfectoLogin(object sender, EventArgs args)
        {
            CodigoComun.Timer(this.formError, this.formError.timerForm);
        }

        public void Cerrar(object sender, EventArgs args)
        {
            CodigoComun.BtnCerrar(this.formError);
        }

        private void VolverTransparente(object sender, EventArgs args)
        {
            this.formError.Opacity = 0.6;
        }
        private void RetornarOpacidad(object sender, EventArgs args)
        {
            this.formError.Opacity = 1;
        }
    }
}

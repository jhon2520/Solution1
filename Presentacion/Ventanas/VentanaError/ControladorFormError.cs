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
        private CodigoComun codigoComun = new CodigoComun();

        public ControladorFormError(FormError formError)
        {
            this.formError = formError;
            this.formError.Opacity = 0.0;
            this.formError.timerForm.Tick += new EventHandler(EfectoLogin);
            this.formError.btnListo.Click += new EventHandler(Cerrar);
        }

        public void EfectoLogin(object sender, EventArgs args)
        {
            codigoComun.Timer(this.formError, this.formError.timerForm);
        }

        public void Cerrar(object sender, EventArgs args)
        {
            codigoComun.BtnCerrar(this.formError);
        }
    }
}

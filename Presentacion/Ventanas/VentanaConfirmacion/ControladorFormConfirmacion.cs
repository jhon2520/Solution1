using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentacion.CodigoCompartido;

namespace Presentacion.Ventanas.VentanaConfirmacion
{
    class ControladorFormConfirmacion
    {
        private FormConfirmacion formConfirmacion;

        public ControladorFormConfirmacion(FormConfirmacion formConfirmacion)
        {
            this.formConfirmacion = formConfirmacion;
            this.formConfirmacion.Opacity = 0.0;
            this.formConfirmacion.btnListo.Click += new EventHandler(BtnConfirmar);
            this.formConfirmacion.btnNo.Click += new EventHandler(BtnNegar);
            this.formConfirmacion.timerForm.Tick += new EventHandler(EfectoLogin);
            this.formConfirmacion.pnlSuperior.MouseDown += new MouseEventHandler(VolverTransparente);
            this.formConfirmacion.pnlSuperior.MouseUp += new MouseEventHandler(RetornarOpacidad);
        }

        private void BtnConfirmar(object sender, EventArgs args)
        {
            this.formConfirmacion.DialogResult = DialogResult.OK;
        }
        private void BtnNegar(object sender, EventArgs args)
        {
            this.formConfirmacion.DialogResult = DialogResult.Cancel;
        }

        private void EfectoLogin(object sender, EventArgs args)
        {
            CodigoComun.Timer(this.formConfirmacion, this.formConfirmacion.timerForm);
        }
        private void VolverTransparente(object sender, EventArgs args)
        {
            this.formConfirmacion.Opacity = 0.6;
        }
        private void RetornarOpacidad(object sender, EventArgs args)
        {
            this.formConfirmacion.Opacity = 1;
        }
    }
}

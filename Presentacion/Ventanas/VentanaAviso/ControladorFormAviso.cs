using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentacion.Ventanas;
using Presentacion.CodigoCompartido;

namespace Presentacion.Ventanas.VentanaAviso
{
    public class ControladorFormAviso
    {
        public FormAviso formAviso;

        public ControladorFormAviso(FormAviso formAviso)
        {
            this.formAviso = formAviso;
            this.formAviso.Opacity = 0.0;
            this.formAviso.timerForm.Tick += new EventHandler(EfectoLogin);
            this.formAviso.btnListo.Click += new EventHandler(Cerrar);
            this.formAviso.pnlSuperior.MouseDown += new MouseEventHandler(VolverTransparente);
            this.formAviso.pnlSuperior.MouseUp += new MouseEventHandler(RetornarOpacidad);
        }

        public void EfectoLogin(object sender, EventArgs args)
        {
            CodigoComun.Timer(this.formAviso, this.formAviso.timerForm);
        }
        public void Cerrar(object sender, EventArgs args)
        {
            CodigoComun.BtnCerrar(this.formAviso);
        }
        private void VolverTransparente(object sender, EventArgs args)
        {
            this.formAviso.Opacity = 0.6;
        }
        private void RetornarOpacidad(object sender, EventArgs args)
        {
            this.formAviso.Opacity = 1;
        }

    }
}

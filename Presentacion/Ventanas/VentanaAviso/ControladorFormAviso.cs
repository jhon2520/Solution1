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
        public CodigoComun codigoComun = new CodigoComun();

        public ControladorFormAviso(FormAviso formAviso)
        {
            this.formAviso = formAviso;
            this.formAviso.Opacity = 0.0;
            this.formAviso.timerForm.Tick += new EventHandler(EfectoLogin);
            this.formAviso.btnListo.Click += new EventHandler(Cerrar);
        }

        public void EfectoLogin(object sender, EventArgs args)
        {
            codigoComun.Timer(this.formAviso, this.formAviso.timerForm);
        }
        public void Cerrar(object sender, EventArgs args)
        {
            codigoComun.BtnCerrar(this.formAviso);
        }

    }
}

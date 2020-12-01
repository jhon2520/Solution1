using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presentacion.CodigoCompartido;

namespace Presentacion.Ventanas.AcercaDe
{
    class ControladorFormAcercaDE
    {
        private FormAcercaDE formAcercaDe;


        public ControladorFormAcercaDE(FormAcercaDE formAcercaDE)
        {
            this.formAcercaDe = formAcercaDE;
            this.formAcercaDe.btnCerrar.Click += new EventHandler(CerrarForm);
        }

        private void CerrarForm(object sender, EventArgs args)
        {
            CodigoComun.BtnCerrar(this.formAcercaDe);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentacion.CodigoCompartido;

namespace Presentacion.Ventanas.AcercaDe
{
    class ControladorFormAcercaDE
    {
        private FormAcercaDE formAcercaDe;


        public ControladorFormAcercaDE(FormAcercaDE formAcercaDE)
        {
            this.formAcercaDe = formAcercaDE;
            this.formAcercaDe.Opacity = 0.0;
            this.formAcercaDe.timerForm.Tick += new EventHandler(EfectoLogin);
            this.formAcercaDe.btnCerrar.Click += new EventHandler(CerrarForm);
            this.formAcercaDe.MouseDown += new MouseEventHandler(VolverTransparente);
            this.formAcercaDe.MouseUp += new MouseEventHandler(RetornarOpacidad);
        }

        private void CerrarForm(object sender, EventArgs args)
        {
            CodigoComun.BtnCerrar(this.formAcercaDe);
        }
        private void VolverTransparente(object sender, EventArgs args)
        {
            this.formAcercaDe.Opacity = 0.6;
        }
        private void RetornarOpacidad(object sender, EventArgs args)
        {
            this.formAcercaDe.Opacity = 1;
        }
        public void EfectoLogin(object sender, EventArgs args)
        {
            CodigoComun.Timer(this.formAcercaDe, this.formAcercaDe.timerForm);
        }
    }
}

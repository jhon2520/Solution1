using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presentacion.FormsCarteras.Comercial;
using Presentacion.FormsCarteras.Consumo.VarialblesAnalisis;
using Presentacion.CodigoCompartido;

namespace Presentacion.FormsCarteras.Consumo
{
    class ControladorFormConsumo
    {
        private FormConsumo formConsumo;
        private FormVariablesAnalisis formVariablesAnalisis = new FormVariablesAnalisis();
        private CodigoComun codigoComun = new CodigoComun();

        public ControladorFormConsumo(FormConsumo formConsumo)
        {
            this.formConsumo = formConsumo;
            this.formConsumo.btnAnalisis.Click += new EventHandler(AbrirFormAnalisis);
        }

        private void AbrirFormAnalisis(object sender, EventArgs args)
        {
            if (codigoComun.ActiveForm == null)
            {
                this.formConsumo.pnlCentro.Visible = false;
                this.formConsumo.dgvPlanPagoComercial.Visible = false;
                
                this.formConsumo.trancisionFormAnalisis.Show(this.formConsumo.pnlCentro);
                codigoComun.AbrirFormHijo(formVariablesAnalisis, this.formConsumo.pnlCentro);
            }
        }
    }
}

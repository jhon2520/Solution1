using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentacion.CodigoCompartido;
using Presentacion.Ventanas.Calculadora;
using Presentacion.Ventanas.VentanaError;

namespace Presentacion.FormsCarteras.Comercial
{
    class ControladorFormComercial
    {
        private FormComercial formComercial;
        private CodigoComun codigoComun = new CodigoComun();
        private double Cuota;
        private FormError formError;
        
        public ControladorFormComercial(FormComercial formComercial)
        {
            this.formComercial = formComercial;
            this.formComercial.Load += new EventHandler(CargarForm);
            this.formComercial.btnCalculadora.Click += new EventHandler(BotonCalculadora);
            this.formComercial.tbxMonto.TextChanged += new EventHandler(CalcularCuota);
            this.formComercial.contadorPlazo.ValueChanged += new EventHandler(CalcularCuota);
            this.formComercial.contadorTasa.ValueChanged += new EventHandler(CalcularCuota);
            this.formComercial.btnPlanCuotas.Click += new EventHandler(PlanDeCuotas);
        }

        private void CargarForm(object sender, EventArgs args)
        {
            codigoComun.EstiloDataGrid(this.formComercial.dgvPlanPagoComercial);
        }

        private void BotonCalculadora(object sender, EventArgs args)
        {
            FormCalculadora formCalculadora = new FormCalculadora();
            formCalculadora.Show();
        }

        private void CalcularCuota(object sender, EventArgs args)
        {
            try
            {
                this.Cuota = codigoComun.CalcularCuota(Convert.ToDouble(this.formComercial.tbxMonto.Text), Convert.ToDouble(this.formComercial.contadorTasa.Value), Convert.ToInt32(this.formComercial.contadorPlazo.Value));
                this.formComercial.tbxCuota.Text = this.Cuota.ToString("N2");
            }
            catch (Exception ex)
            {
                formError = new FormError("Error: No ha seleccionado una formato adecuado o un valor para el monto del crédito");
                formError.ShowDialog();
            }
          
        }
        private void PlanDeCuotas(object sender, EventArgs args)
        {
            if (this.formComercial.tbxMonto.Text != string.Empty && this.formComercial.contadorPlazo.Value !=0 && this.formComercial.contadorTasa.Value !=0)
            {
                this.formComercial.dgvPlanPagoComercial.Rows.Clear();
                codigoComun.PlanDeCuotas(this.formComercial.dgvPlanPagoComercial, Convert.ToDouble(this.formComercial.tbxMonto.Text)
                , Convert.ToInt32(this.formComercial.contadorPlazo.Value), Convert.ToDouble(this.formComercial.contadorTasa.Value)
                , Convert.ToDouble(this.formComercial.tbxCuota.Text));
            }
            else
            {
                formError = new FormError("Ingrese el valor del monto, plazo y cuota del crédito antes de simular el plan de pago");
                formError.ShowDialog();
            }

        }
    }
}

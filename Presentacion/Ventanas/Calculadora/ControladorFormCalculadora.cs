using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentacion.CodigoCompartido;
using Presentacion.Ventanas.VentanaAviso;
using Presentacion.Ventanas.VentanaConfirmacion;
using Presentacion.Ventanas.VentanaError;

namespace Presentacion.Ventanas.Calculadora
{
    class ControladorFormCalculadora
    {
        private FormCalculadora formCalculadora;
        private CodigoComun codigoComun = new CodigoComun();
        private FormConfirmacion formConfirmacion;
        private FormError formError;
        public ControladorFormCalculadora(FormCalculadora formCalculadora)
        {
            this.formCalculadora = formCalculadora;
            this.formCalculadora.Opacity = 0.0;
            this.formCalculadora.rbtTasaNominal1.Click += new EventHandler(RadioBtnTasas);
            this.formCalculadora.rbtTasaEfectiva1.Click += new EventHandler(RadioBtnTasas);
            this.formCalculadora.btnConvertirTasa.Click += new EventHandler(ConvertirTasa);
            this.formCalculadora.timerForm.Tick += new EventHandler(EfectoLogin);
            this.formCalculadora.btnCerrar.Click += new EventHandler(CerrarForm);
            this.formCalculadora.btnMinimizar.Click += new EventHandler(MinimizarForm);
        }

        private void RadioBtnTasas(object sender, EventArgs args)
        {
            if(this.formCalculadora.rbtTasaNominal1.Checked == true)
            {
                this.formCalculadora.rbtTasaEfectiva2.Checked = true;
            }
            else if (this.formCalculadora.rbtTasaEfectiva1.Checked == true)
            {
                this.formCalculadora.rbtTasaNominal2.Checked = true;
            }
        }

        private void ConvertirTasa(object sender, EventArgs args)
        {
            formError = new FormError("Debe agregar un valor y tipo de tasa antes de simular");
            double valorTasa;

            if(this.formCalculadora.tbxAConvertir.Text != string.Empty && (this.formCalculadora.rbtTasaEfectiva1.Checked == true 
                || this.formCalculadora.rbtTasaNominal1.Checked == true))
            {
                if (this.formCalculadora.rbtTasaNominal1.Checked == true)
                {
                    valorTasa = (codigoComun.NominalAEfectiva(Convert.ToDouble(this.formCalculadora.tbxAConvertir.Text)));
                }
                else if (this.formCalculadora.rbtTasaEfectiva1.Checked == true)
                {
                    valorTasa = (codigoComun.EfectivaANominal(Convert.ToDouble(this.formCalculadora.tbxAConvertir.Text)));
                }
                else
                {
                    valorTasa = 0;
                }

                this.formCalculadora.tbxConvertida.Text = valorTasa.ToString("N3") + "%";
            }
            else
            {
                formError.ShowDialog();
            }

           
        }

        private void EfectoLogin(object sender, EventArgs args)
        {
            codigoComun.Timer(this.formCalculadora, this.formCalculadora.timerForm);
        }

        private void CerrarForm(object sender, EventArgs args)
        {
            formConfirmacion = new FormConfirmacion("¿Desea cerrar la calculadora de tasas?");
            DialogResult resultado = formConfirmacion.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                codigoComun.BtnCerrar(this.formCalculadora);
            }

        }
        private void MinimizarForm(object sender, EventArgs args)
        {
            codigoComun.BtnMinimizar(this.formCalculadora);
        }
    }
}

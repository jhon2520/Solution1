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
using Presentacion.Ventanas.VentanaEmergente;
using Presentacion.Ventanas.VentanaError;
using SoporteUsuario.CacheUsuario;

namespace Presentacion.Ventanas.Calculadora
{
    class ControladorFormCalculadora
    {
        private FormCalculadora formCalculadora;
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
            this.formCalculadora.pnlSuperiorForm.MouseDown += new MouseEventHandler(VolverTransparente);
            this.formCalculadora.pnlSuperiorForm.MouseUp += new MouseEventHandler(RetornarOpacidad);
         
           
            CargarForm();
            MensajesTooltip();
         
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

        private void CargarForm()
        {
            this.formCalculadora.pnlSuperiorForm.BackColor = Cache.ColorInicio;
            this.formCalculadora.btnConvertirTasa.BackColor = Cache.ColorInicio;
            this.formCalculadora.btnCerrar.BackColor = Cache.ColorInicio;
            this.formCalculadora.pnlLinea1.BackColor = Cache.ColorInicio;
            this.formCalculadora.pnlLinea2.BackColor = Cache.ColorInicio;
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
                    CodigoComun.Alerta("Correcto", FormVentanaEmergente.enmTipo.exito);
                    valorTasa = (CodigoComun.NominalAEfectiva(Convert.ToDouble(this.formCalculadora.tbxAConvertir.Text)));
                }
                else if (this.formCalculadora.rbtTasaEfectiva1.Checked == true)
                {
                    CodigoComun.Alerta("Correcto", FormVentanaEmergente.enmTipo.exito);
                    valorTasa = (CodigoComun.EfectivaANominal(Convert.ToDouble(this.formCalculadora.tbxAConvertir.Text)));
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
            CodigoComun.Timer(this.formCalculadora, this.formCalculadora.timerForm);
        }

        private void CerrarForm(object sender, EventArgs args)
        {
            CodigoComun.BtnCerrar(this.formCalculadora);
        }
     
        private void VolverTransparente(object sender, EventArgs args)
        {
            this.formCalculadora.Opacity = 0.6;
        }
        private void RetornarOpacidad(object sender, EventArgs args)
        {
            this.formCalculadora.Opacity = 1;
        }

        private void MensajesTooltip()
        {
            this.formCalculadora.ttCalculadora.SetToolTip(this.formCalculadora.rbtTasaNominal1, "Seleccione si la tasa es Nominal Mensual.");
            this.formCalculadora.ttCalculadora.SetToolTip(this.formCalculadora.btnConvertirTasa, "Convertir la tasa seleccionada.");
            this.formCalculadora.ttCalculadora.SetToolTip(this.formCalculadora.btnCerrar, "Cerrar calculadora.");
            this.formCalculadora.ttCalculadora.SetToolTip(this.formCalculadora.rbtTasaEfectiva1, "Seleccione si la tasa es Efectiva Anual.");
                 
        }

    
    }
}

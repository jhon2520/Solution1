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
            this.formCalculadora.btnConvertir2.Click += new EventHandler(ConvertirTasaDos);

            CargarForm();
            MensajesTooltip();

        }

        private void RadioBtnTasas(object sender, EventArgs args)
        {
            if (this.formCalculadora.rbtTasaNominal1.Checked == true)
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
            this.formCalculadora.btnConvertir2.BackColor = Cache.ColorInicio;
            this.formCalculadora.btnCerrar.BackColor = Cache.ColorInicio;
            this.formCalculadora.pnlLinea1.BackColor = Cache.ColorInicio;
            this.formCalculadora.pnlLinea2.BackColor = Cache.ColorInicio;
            this.formCalculadora.pnl4.BackColor = Cache.ColorInicio;
            this.formCalculadora.pnl5.BackColor = Cache.ColorInicio;
            this.formCalculadora.pnl6.BackColor = Cache.ColorInicio;
            this.formCalculadora.pnl7.BackColor = Cache.ColorInicio;
            ValidacionSoloNumerosTextBox();

        }

        private void ConvertirTasa(object sender, EventArgs args)
        {
            formError = new FormError("Debe agregar un valor y tipo de tasa antes de simular");
            double valorTasa;

            if (this.formCalculadora.tbxAConvertir.Text != string.Empty && (this.formCalculadora.rbtTasaEfectiva1.Checked == true
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

            this.formCalculadora.ttCalculadora.SetToolTip(this.formCalculadora.tbxDTF, "Ingrese el valor de la DTF actual, sin símbolos ni porcentajes (ejemplo: 4.53).");
            this.formCalculadora.ttCalculadora.SetToolTip(this.formCalculadora.tbxPuntos, "Ingrese la cantidad de puntos que se van a sumar a la DTF.");
            this.formCalculadora.ttCalculadora.SetToolTip(this.formCalculadora.btnConvertir2, "Convertir la DTF más los puntos seleccionados");

        }

        private double CalcularTasaEA(double DTF, int puntos) => (DTF + puntos);
        private double CalcularTasaMensual(double tasaEA) => (CodigoComun.EfectivaANominal(tasaEA));

        private void ConvertirTasaDos(object sender, EventArgs args)
        {

            try
            {
                formError = new FormError("Debe agregar la DTF y los puntos a sumar antes de simular.");

                if (this.formCalculadora.tbxDTF.Text != string.Empty && !string.IsNullOrEmpty(this.formCalculadora.tbxPuntos.Text))
                {
                    double TasaEA = CalcularTasaEA(Convert.ToDouble(this.formCalculadora.tbxDTF.Text), Convert.ToInt32(this.formCalculadora.tbxPuntos.Text));
                    double TasaMensual = CalcularTasaMensual(TasaEA); 
                    this.formCalculadora.tbxTasaEA.Text = (TasaEA / 100).ToString("0.00%");
                    this.formCalculadora.tbxTasaMensual.Text = (TasaMensual / 100).ToString("0.00%");
                    CodigoComun.Alerta("Correcto", FormVentanaEmergente.enmTipo.exito);
                }
                else
                {
                    formError.ShowDialog();
                }
                
            }
            catch (Exception)
            {

                using (formError = new FormError("La información no tiene el formato correcto "))
                {
                    formError.ShowDialog();
                }
            }
        }
        private void ValidacionSoloNumerosTextBox()
        {
            this.formCalculadora.tbxAConvertir.KeyPress += new KeyPressEventHandler(ValidarEntradaDeNumeros);
            this.formCalculadora.tbxConvertida.KeyPress += new KeyPressEventHandler(ValidarEntradaDeNumeros);
            this.formCalculadora.tbxDTF.KeyPress += new KeyPressEventHandler(ValidarEntradaDeNumeros);
            this.formCalculadora.tbxPuntos.KeyPress += new KeyPressEventHandler(ValidarEntradaDeNumeros);

        }
        private void ValidarEntradaDeNumeros(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else if (e.KeyChar.Equals('.') || e.KeyChar.Equals(',')) //permitir teclas punto y la coma
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }
    }
}
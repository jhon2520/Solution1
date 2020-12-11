using Presentacion.CodigoCompartido;
using Presentacion.Ventanas.VentanaError;
using SoporteUsuario.CacheUsuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Ventanas.VentanaCodeudor
{
    class ControladorFormCodeudor
    {
        private FormCodeudor formCodeudor;
        public TextBox[] textBoxesNumeros;
        private FormError formError;
        private IndicadoresConsumoNomina indicadoresConsumoNomina;
        private IndicadoresCaja indicadoresCaja;

        public ControladorFormCodeudor(FormCodeudor formCodeudor)
        {
            this.formCodeudor = formCodeudor;
            CrearListaDeTexBoxesNumericos();
            this.formCodeudor.Opacity = 0.0;
            this.formCodeudor.btnCerrar.Click += new EventHandler(CerrarForm);
            this.formCodeudor.timerForm.Tick += new EventHandler(EfectoLogin);
            this.formCodeudor.pnlSuperior.MouseDown += new MouseEventHandler(VolverTransparente);
            this.formCodeudor.pnlSuperior.MouseUp += new MouseEventHandler(RetornarOpacidad);
            this.formCodeudor.pbx.MouseDown += new MouseEventHandler(VolverTransparente);
            this.formCodeudor.pbx.MouseUp += new MouseEventHandler(RetornarOpacidad);
            this.formCodeudor.tbxIngresos.TextChanged += new EventHandler(RetornarTotalIngresos);
            this.formCodeudor.tbxOtrosIngresos.TextChanged += new EventHandler(RetornarTotalIngresos);
            this.formCodeudor.tbxDeduccionesDeSeguridadSocial.TextChanged += new EventHandler(RetornarTotalDeducciones);
            this.formCodeudor.tbxOtrasDeduccionesColilla.TextChanged += new EventHandler(RetornarTotalDeducciones);
            this.formCodeudor.btnCalcularDisponible.Click += new EventHandler(RetornarIndicadoresSegunCartera);
            CargarForm();
            RetornarFormatoTextBox();
            ValidacionSoloNumerosTextBox();
        }
        private void CrearListaDeTexBoxesNumericos()
        {
            textBoxesNumeros = new TextBox[]
            {
                this.formCodeudor.tbxCuota,this.formCodeudor.tbxIngresos,this.formCodeudor.tbxOtrosIngresos,this.formCodeudor.tbxCuota,this.formCodeudor.tbxDeduccionesDeSeguridadSocial,
                this.formCodeudor.tbxOtrasDeduccionesColilla, this.formCodeudor.tbxCuotasCentralesDeRiesgo,this.formCodeudor.tbxValorCuotaLibranza
            };
        }
        private void FormatoNumeroTexBox(object sender, EventArgs args)
        {
            CodigoComun.RetornarFormatoNumero(textBoxesNumeros);
        }
        private void RetornarFormatoTextBox()
        {

            foreach (TextBox textBox in textBoxesNumeros)
            {
                textBox.Leave += new EventHandler(FormatoNumeroTexBox);
            }
        }
        public void CargarForm()
        {
            this.formCodeudor.pnlSuperior.BackColor = Cache.ColorInicio;
            this.formCodeudor.panelColor1.BackColor = Cache.ColorInicio;
            this.formCodeudor.panelColor2.BackColor = Cache.ColorInicio;
            this.formCodeudor.panelColor3.BackColor = Cache.ColorInicio;
            this.formCodeudor.panelColor4.BackColor = Cache.ColorInicio;
            ValidacionAlCargarForm();
        }
        private void CerrarForm(object sender, EventArgs args)
        {
            CodigoComun.BtnCerrar(this.formCodeudor);
        }
        private void EfectoLogin(object sender, EventArgs args)
        {
            CodigoComun.Timer(this.formCodeudor, this.formCodeudor.timerForm);
        }
        private void VolverTransparente(object sender, EventArgs args)
        {
            this.formCodeudor.Opacity = 0.6;
        }
        private void RetornarOpacidad(object sender, EventArgs args)
        {
            this.formCodeudor.Opacity = 1;
        }
        private void ValidacionSoloNumerosTextBox()
        {
            this.formCodeudor.tbxIngresos.KeyPress += new KeyPressEventHandler(CodigoComun.ValidarTextBoxNumero);
            this.formCodeudor.tbxOtrosIngresos.KeyPress += new KeyPressEventHandler(CodigoComun.ValidarTextBoxNumero);
            this.formCodeudor.tbxDeduccionesColilla.KeyPress += new KeyPressEventHandler(CodigoComun.ValidarTextBoxNumero); ;
            this.formCodeudor.tbxValorCuotaLibranza.KeyPress += new KeyPressEventHandler(CodigoComun.ValidarTextBoxNumero);
            this.formCodeudor.tbxDeduccionesDeSeguridadSocial.KeyPress += new KeyPressEventHandler(CodigoComun.ValidarTextBoxNumero);
            this.formCodeudor.tbxOtrasDeduccionesColilla.KeyPress += new KeyPressEventHandler(CodigoComun.ValidarTextBoxNumero);
            this.formCodeudor.tbxCuotasCentralesDeRiesgo.KeyPress += new KeyPressEventHandler(CodigoComun.ValidarTextBoxNumero);

        }
        private void RetornarTotalIngresos(Object sender, EventArgs args)
        {
            try
            {
                if (this.formCodeudor.tbxIngresos.Text != string.Empty && this.formCodeudor.tbxOtrosIngresos.Text != string.Empty)
                {
                    double ingresos = Convert.ToDouble(this.formCodeudor.tbxIngresos.Text);
                    double otrosIngresos = Convert.ToDouble(this.formCodeudor.tbxOtrosIngresos.Text);

                    double totalIngresos = CodigoComun.CalcularTotalIngresos(ingresos, otrosIngresos, 1);
                    this.formCodeudor.tbxTotalIngresos.Text = totalIngresos.ToString("N2");
                }
            }
            catch
            {
                formError = new FormError("El Valor de los ingresos no debe ser cero o un valor inválido");
                formError.ShowDialog();
            }
        }
        private void RetornarTotalDeducciones(object sender, EventArgs args)
        {
            try
            {
                if (this.formCodeudor.tbxDeduccionesDeSeguridadSocial.Text != string.Empty && this.formCodeudor.tbxOtrasDeduccionesColilla.Text != string.Empty)
                {

                    double totalDeduccionesColilla;
                    totalDeduccionesColilla = CodigoComun.RetornarTotalDeducciones(Convert.ToDouble(this.formCodeudor.tbxDeduccionesDeSeguridadSocial.Text), Convert.ToDouble(this.formCodeudor.tbxOtrasDeduccionesColilla.Text));
                    this.formCodeudor.tbxDeduccionesColilla.Text = totalDeduccionesColilla.ToString("N2");
                }
            }
            catch
            {
                formError = new FormError("El Valor de de las deducciones no debe ser cero o un valor inválido");
                formError.ShowDialog();
            }

        }

        private void RetornarIndicadoresConsumo()
        {
            if (this.formCodeudor.cbxFormaDePago.Text == "Nomina")
            {

                indicadoresConsumoNomina = new IndicadoresConsumoNomina(Convert.ToDouble(this.formCodeudor.tbxIngresos.Text), Convert.ToDouble(this.formCodeudor.tbxDeduccionesDeSeguridadSocial.Text), Convert.ToDouble(this.formCodeudor.tbxOtrasDeduccionesColilla.Text),
                Convert.ToDouble(this.formCodeudor.tbxDeduccionesColilla.Text), Convert.ToDouble(this.formCodeudor.tbxCuota.Text), Convert.ToDouble(this.formCodeudor.tbxCuotasCentralesDeRiesgo.Text), Convert.ToDouble(this.formCodeudor.tbxValorCuotaLibranza.Text),
                Convert.ToDouble(this.formCodeudor.tbxTotalIngresos.Text));

                //disponible
                if (this.formCodeudor.cbxLeyLibranza.Checked == true)
                {
                    this.formCodeudor.tbxDisponible.Text = indicadoresConsumoNomina.RetornarDisponibleConLibranza().ToString("N2");
                }
                else
                {
                    this.formCodeudor.tbxDisponible.Text = indicadoresConsumoNomina.RetornarDisponibleSinLibranza().ToString("N2");
                }
                //Afectacion colilla

                this.formCodeudor.tbxAfectacionColilla.Text = indicadoresConsumoNomina.RetornarAfectacionColilla().ToString("0.00%");

                //Endeudamiento global

                this.formCodeudor.tbxEndeudamientoGlobal.Text = indicadoresConsumoNomina.RetornarEndeudamientoGlobal().ToString("0.00%");
            }

            else if (this.formCodeudor.cbxFormaDePago.Text == "Caja")
            {
                RetornarIndicadoresCaja();
            }

        }

        private void RetornarIndicadoresCaja()
        {
            indicadoresCaja = new IndicadoresCaja(Convert.ToDouble(this.formCodeudor.tbxDeduccionesColilla.Text), Convert.ToDouble(this.formCodeudor.tbxCuotasCentralesDeRiesgo.Text),
                   Convert.ToDouble(this.formCodeudor.tbxCuota.Text), Convert.ToDouble(this.formCodeudor.tbxCuotasACancelar.Text), Convert.ToDouble(this.formCodeudor.tbxIngresos.Text),
                   Convert.ToDouble(this.formCodeudor.tbxOtrosIngresos.Text), this.formCodeudor.rbtnCiudad, this.formCodeudor.cbxVivienda);

            this.formCodeudor.tbxEndeudamientoGlobal.Text = indicadoresCaja.RetornarEndeudamientoGlobal().ToString("0.00%");
            this.formCodeudor.tbxDisponible.Text = indicadoresCaja.RetornarDisponible().ToString("N2");

        }

        private void RetornarIndicadoresSegunCartera(object sender, EventArgs args)
        {
            switch (Cache.TipoDeCredito)
            {
                case 1:
                    RetornarIndicadoresConsumo();
                    break;
                case 2: case 3: case 4:
                    RetornarIndicadoresCaja();
                    break;
            }
        }
        private void ValidacionAlCargarForm()
        {
            if (Cache.TipoDeCredito != 1)
            {
                this.formCodeudor.cbxFormaDePago.Text = "Caja";
                this.formCodeudor.cbxLeyLibranza.Visible = false;
                this.formCodeudor.tbxAfectacionColilla.Text = "N/A";
                this.formCodeudor.tbxAfectacionColilla.Enabled = false;
            }
        }
    }
}

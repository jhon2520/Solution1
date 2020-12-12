﻿using Presentacion.CodigoCompartido;
using Presentacion.Ventanas.VentanaEmergente;
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
            this.formCodeudor.Load += new EventHandler(CargarForm);
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
            this.formCodeudor.btnCalcularIndicadores.Click += new EventHandler(RetornarIndicadoresSegunCartera);
            CargarColoresForm();
            MensajesToolTip();
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
        public void CargarColoresForm()
        {
            this.formCodeudor.pnlSuperior.BackColor = Cache.ColorInicio;
            this.formCodeudor.panelColor1.BackColor = Cache.ColorInicio;
            this.formCodeudor.panelColor2.BackColor = Cache.ColorInicio;
            this.formCodeudor.panelColor3.BackColor = Cache.ColorInicio;
            this.formCodeudor.panelColor4.BackColor = Cache.ColorInicio;
            this.formCodeudor.pnlColor1.BackColor = Cache.ColorInicio;
            this.formCodeudor.pnlColor2.BackColor = Cache.ColorInicio;
            this.formCodeudor.pnlColor3.BackColor = Cache.ColorInicio;
            this.formCodeudor.pnlColor4.BackColor = Cache.ColorInicio;
            this.formCodeudor.pnlColor5.BackColor = Cache.ColorInicio;
            this.formCodeudor.pnlColor6.BackColor = Cache.ColorInicio;
            this.formCodeudor.pnlColor7.BackColor = Cache.ColorInicio;
            this.formCodeudor.pnlColor8.BackColor = Cache.ColorInicio;
            this.formCodeudor.pnlColor9.BackColor = Cache.ColorInicio;
            this.formCodeudor.pnlColor10.BackColor = Cache.ColorInicio;
            this.formCodeudor.pnlColor12.BackColor = Cache.ColorInicio;
            this.formCodeudor.pnlColor13.BackColor = Cache.ColorInicio;
            this.formCodeudor.pnlColor14.BackColor = Cache.ColorInicio;
            this.formCodeudor.pnlColor15.BackColor = Cache.ColorInicio;
            this.formCodeudor.pnlColor16.BackColor = Cache.ColorInicio;
            this.formCodeudor.btnAlmacenarInformacion.BackColor = Cache.ColorInicio;
            this.formCodeudor.btnCalcularIndicadores.BackColor = Cache.ColorInicio;
            ValidacionAlCargarForm();
        }
        private void CargarForm(object sender, EventArgs args)
        {
            this.formCodeudor.tbxIngresos.Focus();
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

            if (ValidarInformación())
            {
                
                if (this.formCodeudor.cbxFormaDePago.Text == "Nomina")
                {
                    CodigoComun.Alerta("Correcto", FormVentanaEmergente.enmTipo.exito);
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
            else
            {
                using (formError = new FormError("Datos insuficientes para calcular los indicadores"))
                {
                    formError.ShowDialog();
                }
            }



        }
        private bool ValidarInformación()
        {
            bool validacionCorrecta;

            if (!string.IsNullOrEmpty(this.formCodeudor.tbxIngresos.Text) && !string.IsNullOrEmpty(this.formCodeudor.tbxOtrosIngresos.Text) && !string.IsNullOrEmpty(this.formCodeudor.cbxVivienda.Text) &&
                (this.formCodeudor.rbtnCiudad.Checked == true || this.formCodeudor.rbtnMunicipio.Checked == true) && !string.IsNullOrEmpty(this.formCodeudor.tbxDeduccionesDeSeguridadSocial.Text)
                && !string.IsNullOrEmpty(this.formCodeudor.tbxOtrasDeduccionesColilla.Text) && !string.IsNullOrEmpty(this.formCodeudor.tbxCuotasCentralesDeRiesgo.Text) &&
                !string.IsNullOrEmpty(this.formCodeudor.tbxValorCuotaLibranza.Text) && !string.IsNullOrEmpty(this.formCodeudor.tbxCuotasACancelar.Text))
                validacionCorrecta = true;
            else validacionCorrecta = false;

            return validacionCorrecta;
        }
        private void RetornarIndicadoresCaja()
        {
            if (ValidarInformación())
            {
                CodigoComun.Alerta("Correcto", FormVentanaEmergente.enmTipo.exito);
                using (indicadoresCaja = new IndicadoresCaja(Convert.ToDouble(this.formCodeudor.tbxDeduccionesColilla.Text), Convert.ToDouble(this.formCodeudor.tbxCuotasCentralesDeRiesgo.Text),
                Convert.ToDouble(this.formCodeudor.tbxCuota.Text), Convert.ToDouble(this.formCodeudor.tbxCuotasACancelar.Text), Convert.ToDouble(this.formCodeudor.tbxIngresos.Text),
                Convert.ToDouble(this.formCodeudor.tbxOtrosIngresos.Text), this.formCodeudor.rbtnCiudad, this.formCodeudor.cbxVivienda))
                {
                    this.formCodeudor.tbxEndeudamientoGlobal.Text = indicadoresCaja.RetornarEndeudamientoGlobal().ToString("0.00%");
                    this.formCodeudor.tbxDisponible.Text = indicadoresCaja.RetornarDisponible().ToString("N2");

                }
            }
            else
            {
                using (formError = new FormError("Datos insuficientes para calcular los indicadores"))
                {
                    formError.ShowDialog();
                }
            }




        }
        private void RetornarIndicadoresSegunCartera(object sender, EventArgs args)
        {
            switch (Cache.TipoDeCredito)
            {
                case 1:
                    RetornarIndicadoresConsumo();
                    break;
                case 2:
                case 3:
                case 4:
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
        private void MensajesToolTip()
        {
      
            this.formCodeudor.ttFormCodeudor.SetToolTip(this.formCodeudor.cbxFormaDePago, "Ingrese si el pago será por nómina o caja.");
            this.formCodeudor.ttFormCodeudor.SetToolTip(this.formCodeudor.cbxVivienda, "Ingrese el tipo de vivienda del codeudor.");
            this.formCodeudor.ttFormCodeudor.SetToolTip(this.formCodeudor.rbtnCiudad, "El codeudor vive actualmente en una zona urbana.");
            this.formCodeudor.ttFormCodeudor.SetToolTip(this.formCodeudor.rbtnMunicipio, "El codeudor vive actualmente en una zona rural.");
            this.formCodeudor.ttFormCodeudor.SetToolTip(this.formCodeudor.tbxIngresos, "Ingresos mensuales actuales del codeudor.");
            this.formCodeudor.ttFormCodeudor.SetToolTip(this.formCodeudor.tbxOtrosIngresos, "Otros ingresos mensuales actuales del codeudor.");
            this.formCodeudor.ttFormCodeudor.SetToolTip(this.formCodeudor.tbxDeduccionesColilla, "Total deducciones registradas en la colilla de pago.");
            this.formCodeudor.ttFormCodeudor.SetToolTip(this.formCodeudor.tbxCuotasCentralesDeRiesgo, "Total cuotas mensuales registradas en las centrales.");
            this.formCodeudor.ttFormCodeudor.SetToolTip(this.formCodeudor.tbxCuotasACancelar, "Cuotas a cancelar mediante el crédito solicitado.");
            this.formCodeudor.ttFormCodeudor.SetToolTip(this.formCodeudor.tbxValorCuotaLibranza, "Valor a compensar de la cuota registrada en colilla.");
            this.formCodeudor.ttFormCodeudor.SetToolTip(this.formCodeudor.tbxDeduccionesDeSeguridadSocial, "Valor de las deducciones asociadas a la seguridad social.");
            this.formCodeudor.ttFormCodeudor.SetToolTip(this.formCodeudor.tbxOtrasDeduccionesColilla, "Otras deducciones asociadas a la colilla.");
            this.formCodeudor.ttFormCodeudor.SetToolTip(this.formCodeudor.btnCalcularIndicadores, "Calcular los indicadores de capacidad para el codeudor.");
            this.formCodeudor.ttFormCodeudor.SetToolTip(this.formCodeudor.btnAlmacenarInformacion, "Almacenar la información del codeudor para ser exportada.");
            this.formCodeudor.ttFormCodeudor.SetToolTip(this.formCodeudor.btnCerrar, "Cerrar");
            this.formCodeudor.ttFormCodeudor.SetToolTip(this.formCodeudor.cbxLeyLibranza, "Seleccione en caso de que le aplique ley de libranza.");
        }
    }
}

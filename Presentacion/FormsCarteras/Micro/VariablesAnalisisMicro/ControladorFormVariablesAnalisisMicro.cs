﻿using Presentacion.CodigoCompartido;
using Presentacion.Ventanas.VentanaAnalisisDeCredito;
using Presentacion.Ventanas.VentanaEmergente;
using Presentacion.Ventanas.VentanaError;
using SoporteUsuario.CacheUsuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.FormsCarteras.Micro.VariablesAnalisisMicro
{
    
    class ControladorFormVariablesAnalisisMicro
    {
        private FormVarialblesAnalisisMicro formVarialblesAnalisisMicro;
        private FormAnalisisDeCredito formAnalisisDeCredito = new FormAnalisisDeCredito();
        private FormError formError;
        public TextBox[] textBoxesNumeros;
        public TextBox[] textBoxesLetras;

        public ControladorFormVariablesAnalisisMicro(FormVarialblesAnalisisMicro formVarialblesAnalisisMicro)
        {
            this.formVarialblesAnalisisMicro = formVarialblesAnalisisMicro;
            textBoxesNumeros = new TextBox[] { this.formVarialblesAnalisisMicro.tbxVentasMicro, this.formVarialblesAnalisisMicro.tbxCostosDeVentasMicro, this.formVarialblesAnalisisMicro.tbxIngresos,
            this.formVarialblesAnalisisMicro.tbxOtrosIngresos,this.formVarialblesAnalisisMicro.tbxCuotasCentralesDeRiesgo,this.formVarialblesAnalisisMicro.tbxUtilidadBrutaMicro,this.formVarialblesAnalisisMicro.tbxGastosDelNegocio,
            this.formVarialblesAnalisisMicro.tbxUtilidadOPerdidaOperativa,this.formVarialblesAnalisisMicro.tbxIngresosFamiliaresYOtros,this.formVarialblesAnalisisMicro.tbxGastosFamiliaresYOtros,this.formVarialblesAnalisisMicro.tbxUtilidadOPerdidaNeta,
            this.formVarialblesAnalisisMicro.tbxCuotaCreditoARefinanciarMicro,this.formVarialblesAnalisisMicro.tbxUtilidadDisponible,
            this.formVarialblesAnalisisMicro.tbxIngresosCodeudor,this.formVarialblesAnalisisMicro.tbxEgresosCodeudor};
            textBoxesLetras = new TextBox[] { this.formVarialblesAnalisisMicro.tbxNombres, this.formVarialblesAnalisisMicro.tbxApellidos, this.formVarialblesAnalisisMicro.tbxProfesion,
            this.formVarialblesAnalisisMicro.tbxCargo,this.formVarialblesAnalisisMicro.tbxOcupacion,this.formVarialblesAnalisisMicro.tbxEmpresa,this.formVarialblesAnalisisMicro.tbxActividadEconomica};
            this.formVarialblesAnalisisMicro.Load += new EventHandler(CargarForm);
            MensajesTooltip();
            RetornarFormatoTextBox();
            ValidacionSoloNumerosTextBox();
            ValidacionSoloLetrasTextbox();
            EventoBotones();
        }
        private void CargarForm(object sender, EventArgs args)
        {
            this.formVarialblesAnalisisMicro.tbxCedula.Text = Cache.Cedula;
            this.formVarialblesAnalisisMicro.tbxMonto.Text = Cache.Monto.ToString("N2");
            this.formVarialblesAnalisisMicro.tbxCuota.Text = Cache.Cuota.ToString("N2");
            this.formVarialblesAnalisisMicro.contadorPlazo.Value = Cache.Plazo;
            this.formVarialblesAnalisisMicro.contadorTasa.Value = Cache.Tasa;
            this.formVarialblesAnalisisMicro.tbxNombres.Focus();
        }
        private void EventoBotones()
        {
            this.formVarialblesAnalisisMicro.tbxIngresos.TextChanged += new EventHandler(RetornarTotalIngresos);
            this.formVarialblesAnalisisMicro.tbxOtrosIngresos.TextChanged += new EventHandler(RetornarTotalIngresos);
            this.formVarialblesAnalisisMicro.cbxDiasMora.TextChanged += new EventHandler(RetornarTotalMora);
            this.formVarialblesAnalisisMicro.cbxCantidadDeMoras.TextChanged += new EventHandler(RetornarTotalMora);
            this.formVarialblesAnalisisMicro.cbxDiasMora.Leave += new EventHandler(RetornarTotalMora);
            this.formVarialblesAnalisisMicro.cbxCantidadDeMoras.Leave += new EventHandler(RetornarTotalMora);
            this.formVarialblesAnalisisMicro.dtpEdad.ValueChanged += new EventHandler(RetornarEdad);
            this.formVarialblesAnalisisMicro.btnAnalizar.Click += new EventHandler(AbrirFormAnalisisCredito);
            this.formVarialblesAnalisisMicro.btnEstadoDeResultados.Click += new EventHandler(RetornarEstadosDeResultados);
            this.formVarialblesAnalisisMicro.tbxIngresosCodeudor.TextChanged += new EventHandler(RetornarEndeudamientoDirectoCodeudor);
            this.formVarialblesAnalisisMicro.tbxEgresosCodeudor.TextChanged += new EventHandler(RetornarEndeudamientoDirectoCodeudor);
            this.formVarialblesAnalisisMicro.tbxIngresos.Enter += new EventHandler(CambiarScroll);
            this.formVarialblesAnalisisMicro.tbxIngresosCodeudor.Enter += new EventHandler(CambiarScroll);
            this.formVarialblesAnalisisMicro.tbxNombres.Enter += new EventHandler(CambiarScroll);
            this.formVarialblesAnalisisMicro.tbxIngresos.Click += new EventHandler(SeleccionarFinalDeTextoIngresos);
            this.formVarialblesAnalisisMicro.tbxOtrosIngresos.Click += new EventHandler(SeleccionarFinalDeTextoIngresos);
            this.formVarialblesAnalisisMicro.tbxVentasMicro.Click += new EventHandler(SeleccionarFinalDeTextoEgresos);
            this.formVarialblesAnalisisMicro.tbxGastosDelNegocio.Click += new EventHandler(SeleccionarFinalDeTextoEgresos);
            this.formVarialblesAnalisisMicro.tbxGastosFamiliaresYOtros.Click += new EventHandler(SeleccionarFinalDeTextoEgresos);
            this.formVarialblesAnalisisMicro.tbxCuotasCentralesDeRiesgo.Click += new EventHandler(SeleccionarFinalDeTextoEgresos);
            this.formVarialblesAnalisisMicro.tbxCostosDeVentasMicro.Click += new EventHandler(SeleccionarFinalDeTextoEgresos);
            this.formVarialblesAnalisisMicro.tbxIngresosFamiliaresYOtros.Click += new EventHandler(SeleccionarFinalDeTextoEgresos);
            this.formVarialblesAnalisisMicro.tbxCuotaCreditoARefinanciarMicro.Click += new EventHandler(SeleccionarFinalDeTextoEgresos);
            this.formVarialblesAnalisisMicro.tbxIngresosCodeudor.Click += new EventHandler(SeleccionarFinalDeTextoEgresos);
            this.formVarialblesAnalisisMicro.tbxEgresosCodeudor.Click += new EventHandler(SeleccionarFinalDeTextoEgresos);
            this.formVarialblesAnalisisMicro.cbxGarantia.TextChanged += new EventHandler(AplicarCodeudor);
            this.formVarialblesAnalisisMicro.cbxGarantia.Leave += new EventHandler(AplicarCodeudor);
            this.formVarialblesAnalisisMicro.cbxGarantia.MouseWheel += new MouseEventHandler(AplicarCodeudor);

        }
        private void MensajesTooltip()
        {
            this.formVarialblesAnalisisMicro.ttMensajesFormMicro.SetToolTip(this.formVarialblesAnalisisMicro.tbxNombres, "Ingrese los nombres del solicitante.");
            this.formVarialblesAnalisisMicro.ttMensajesFormMicro.SetToolTip(this.formVarialblesAnalisisMicro.tbxApellidos, "Ingrese los apellidos del solicitante.");
            this.formVarialblesAnalisisMicro.ttMensajesFormMicro.SetToolTip(this.formVarialblesAnalisisMicro.cbxDestinoDelCredito, "Ingrese el destino del crédito simulado.");
            this.formVarialblesAnalisisMicro.ttMensajesFormMicro.SetToolTip(this.formVarialblesAnalisisMicro.cbxGarantia, "Ingrese La garantía del crédito a analizar.");
            this.formVarialblesAnalisisMicro.ttMensajesFormMicro.SetToolTip(this.formVarialblesAnalisisMicro.dtpEdad, "Ingrese la fecha de nacimiento del solicitante.");
            this.formVarialblesAnalisisMicro.ttMensajesFormMicro.SetToolTip(this.formVarialblesAnalisisMicro.tbxProfesion, "Ingrese La profesión del solicitante.");
            this.formVarialblesAnalisisMicro.ttMensajesFormMicro.SetToolTip(this.formVarialblesAnalisisMicro.tbxCargo, "Ingrese el cargo actual del solicitante.");
            this.formVarialblesAnalisisMicro.ttMensajesFormMicro.SetToolTip(this.formVarialblesAnalisisMicro.tbxOcupacion, "Ingrese la ocupación actual del solicitante.");
            this.formVarialblesAnalisisMicro.ttMensajesFormMicro.SetToolTip(this.formVarialblesAnalisisMicro.cbxEstadoCivil, "Ingrese el estado civil actual solicitante.");
            this.formVarialblesAnalisisMicro.ttMensajesFormMicro.SetToolTip(this.formVarialblesAnalisisMicro.contadorEdad, "Ingrese la edad en años del solicitante.");
            this.formVarialblesAnalisisMicro.ttMensajesFormMicro.SetToolTip(this.formVarialblesAnalisisMicro.contadorPersonasACargo, "Ingrese la cantidad de personas a cargo del solicitante.");
            this.formVarialblesAnalisisMicro.ttMensajesFormMicro.SetToolTip(this.formVarialblesAnalisisMicro.contadorTiempoUnidadProductiva, "Ingrese la cantidad de meses desde que la unidad productiva fue constituída.");
            this.formVarialblesAnalisisMicro.ttMensajesFormMicro.SetToolTip(this.formVarialblesAnalisisMicro.cbxVivienda, "Ingrese el tipo de vivienda del solicitante.");
            this.formVarialblesAnalisisMicro.ttMensajesFormMicro.SetToolTip(this.formVarialblesAnalisisMicro.contadorEstrato, "Ingrese el estrato económico del solicitante.");
            this.formVarialblesAnalisisMicro.ttMensajesFormMicro.SetToolTip(this.formVarialblesAnalisisMicro.rbtnCiudad, "El solicitante vive actualmente en una zona urbana.");
            this.formVarialblesAnalisisMicro.ttMensajesFormMicro.SetToolTip(this.formVarialblesAnalisisMicro.rbtnMunicipio, "El solicitante vive actualmente en una zona rural.");
            this.formVarialblesAnalisisMicro.ttMensajesFormMicro.SetToolTip(this.formVarialblesAnalisisMicro.tbxIngresos, "ingresos mensuales actuales del solicitante; sin puntos ni comas.");
            this.formVarialblesAnalisisMicro.ttMensajesFormMicro.SetToolTip(this.formVarialblesAnalisisMicro.tbxOtrosIngresos, "Otros ingresos mensuales actuales del solicitante; sin puntos ni comas.");
            this.formVarialblesAnalisisMicro.ttMensajesFormMicro.SetToolTip(this.formVarialblesAnalisisMicro.tbxEmpresa, "Nombre de la empresa donde trabaja el solicitante.");
            this.formVarialblesAnalisisMicro.ttMensajesFormMicro.SetToolTip(this.formVarialblesAnalisisMicro.tbxActividadEconomica, "Actividad económica de la emprea.");
            this.formVarialblesAnalisisMicro.ttMensajesFormMicro.SetToolTip(this.formVarialblesAnalisisMicro.cbxTipoDeContrato, "Tipo de contrato laboral del solicitante.");
            this.formVarialblesAnalisisMicro.ttMensajesFormMicro.SetToolTip(this.formVarialblesAnalisisMicro.contadorAntLaboral, "Antigüedad laboral en meses.");

            this.formVarialblesAnalisisMicro.ttMensajesFormMicro.SetToolTip(this.formVarialblesAnalisisMicro.contadorScore, "Ingrese el score del solicitante.");
            this.formVarialblesAnalisisMicro.ttMensajesFormMicro.SetToolTip(this.formVarialblesAnalisisMicro.cbxCalificacion, "Ingrese la calificación del solicitante.");
            this.formVarialblesAnalisisMicro.ttMensajesFormMicro.SetToolTip(this.formVarialblesAnalisisMicro.btnAnalizar, "Analizar crédito según cumplimiento de políticas internas.");
            this.formVarialblesAnalisisMicro.ttMensajesFormMicro.SetToolTip(this.formVarialblesAnalisisMicro.cbxCantidadDeMoras, "Ingrese el número mayor de moras que registra el solicitante.");
            this.formVarialblesAnalisisMicro.ttMensajesFormMicro.SetToolTip(this.formVarialblesAnalisisMicro.cbxDiasMora, "Ingrese los días de mora que registra el solicitante.");

        }
        private void RetornarFormatoTextBox()
        {

            foreach (TextBox textBox in textBoxesNumeros)
            {
                textBox.Leave += new EventHandler(FormatoNumeroTexBox);
            }

        }
        private void FormatoNumeroTexBox(object sender, EventArgs args)
        {
            CodigoComun.RetornarFormatoNumero(textBoxesNumeros);
        }
        private void ValidacionSoloNumerosTextBox()
        {

            foreach (TextBox textBox in textBoxesNumeros)
            {
                textBox.KeyPress += new KeyPressEventHandler(CodigoComun.ValidarTextBoxNumero);
            }
        }
        private void ValidacionSoloLetrasTextbox()
        {

            foreach (TextBox textBox in textBoxesLetras)
            {
                textBox.KeyPress += new KeyPressEventHandler(CodigoComun.ValidarTextBoxLetras);
            }

        }
        private void GeneracionDatosCache()
        {

            if (this.formVarialblesAnalisisMicro.rbtnCiudad.Checked == true) Cache.CiudadMunicipio = "Ciudad";
            else if (this.formVarialblesAnalisisMicro.rbtnMunicipio.Checked == true) Cache.CiudadMunicipio = "Municipio";

            Cache.TotalIngresos = Convert.ToDouble(this.formVarialblesAnalisisMicro.tbxTotalIngresos.Text);
            Cache.Score = (double)this.formVarialblesAnalisisMicro.contadorScore.Value;
            Cache.AntLaboral = (double)this.formVarialblesAnalisisMicro.contadorAntLaboral.Value;
            Cache.TipoDeContrato = this.formVarialblesAnalisisMicro.cbxTipoDeContrato.Text;
            Cache.Edad = (int)this.formVarialblesAnalisisMicro.contadorEdad.Value;
            Cache.Nombre = this.formVarialblesAnalisisMicro.tbxNombres.Text;
            Cache.Apellido = this.formVarialblesAnalisisMicro.tbxApellidos.Text;
            Cache.FechaDeNaciento = (this.formVarialblesAnalisisMicro.dtpEdad.Value.Date).ToString();
            Cache.Profesion = this.formVarialblesAnalisisMicro.tbxProfesion.Text;
            Cache.Cargo = this.formVarialblesAnalisisMicro.tbxCargo.Text;
            Cache.Ocupacion = this.formVarialblesAnalisisMicro.tbxOcupacion.Text;
            Cache.PersonasAcargo = (int)this.formVarialblesAnalisisMicro.contadorPersonasACargo.Value;
            Cache.Estrato = (int)this.formVarialblesAnalisisMicro.contadorEstrato.Value;
            Cache.Empresa = this.formVarialblesAnalisisMicro.tbxEmpresa.Text;
            Cache.ActividadEconomica = this.formVarialblesAnalisisMicro.tbxActividadEconomica.Text;
            Cache.NumeroDemoras = Convert.ToInt32(this.formVarialblesAnalisisMicro.cbxCantidadDeMoras.Text);
            Cache.DiasDeMora = Convert.ToInt32(this.formVarialblesAnalisisMicro.cbxDiasMora.Text);
            Cache.IngresoBasico = Convert.ToDouble(this.formVarialblesAnalisisMicro.tbxIngresos.Text);
            Cache.OtrosIngresos = Convert.ToDouble(this.formVarialblesAnalisisMicro.tbxOtrosIngresos.Text);
            Cache.TipoDePersona = "Persona natural";
            Cache.TiempoUnidadProductiva = (int)this.formVarialblesAnalisisMicro.contadorTiempoUnidadProductiva.Value;
            Cache.IngresosCodeudor = Convert.ToDouble(this.formVarialblesAnalisisMicro.tbxIngresosCodeudor.Text);
            Cache.EgresosCodeudorMicro = Convert.ToDouble(this.formVarialblesAnalisisMicro.tbxEgresosCodeudor.Text);
            Cache.VentasMicro = Convert.ToDouble(this.formVarialblesAnalisisMicro.tbxVentasMicro.Text);
            Cache.CostosDeVentasMicro = Convert.ToDouble(this.formVarialblesAnalisisMicro.tbxCostosDeVentasMicro.Text);
            Cache.GastosDelNegocioMicro = Convert.ToDouble(this.formVarialblesAnalisisMicro.tbxGastosDelNegocio.Text);
            Cache.IngresosFamiliarYOtrosMicro = Convert.ToDouble(this.formVarialblesAnalisisMicro.tbxIngresosFamiliaresYOtros.Text);
            Cache.GastosFamiliaresYOtrosMicro = Convert.ToDouble(this.formVarialblesAnalisisMicro.tbxGastosFamiliaresYOtros.Text);
            Cache.CuotaDelCreditoARefinancierMicro = Convert.ToDouble(this.formVarialblesAnalisisMicro.tbxCuotaCreditoARefinanciarMicro.Text);
            Cache.CuotaCentralesDeRiesgoMicro = Convert.ToDouble(this.formVarialblesAnalisisMicro.tbxCuotasCentralesDeRiesgo.Text);
            Cache.UtilidadBrutaMicro = Convert.ToDouble(this.formVarialblesAnalisisMicro.tbxUtilidadBrutaMicro.Text);
            Cache.UtilidadOPerdidaOperativaMicro = Convert.ToDouble(this.formVarialblesAnalisisMicro.tbxUtilidadOPerdidaOperativa.Text);
            Cache.UtilidadOPerdiaNeta = Convert.ToDouble(this.formVarialblesAnalisisMicro.tbxUtilidadOPerdidaNeta.Text);
            Cache.UtildiadDisponibleMicro = Convert.ToDouble(this.formVarialblesAnalisisMicro.tbxUtilidadDisponible.Text);
            Cache.FormaDePago = "Caja";
            Cache.DestinoDelCredito = this.formVarialblesAnalisisMicro.cbxDestinoDelCredito.Text;
            Cache.Vivienda = this.formVarialblesAnalisisMicro.cbxVivienda.Text;
            Cache.Garantia = this.formVarialblesAnalisisMicro.cbxGarantia.Text;
            Cache.Periodicidad = this.formVarialblesAnalisisMicro.cbxPeriodicidad.Text;
            Cache.EstadoCivil = this.formVarialblesAnalisisMicro.cbxEstadoCivil.Text;
            Cache.Calificacion = this.formVarialblesAnalisisMicro.cbxCalificacion.Text;
            Cache.ComportamientoDePagos = this.formVarialblesAnalisisMicro.tbxComportamientoDePagos.Text;



        }
        private void RetornarTotalIngresos(Object sender, EventArgs args)
        {
            try
            {
                if (this.formVarialblesAnalisisMicro.tbxIngresos.Text != string.Empty && this.formVarialblesAnalisisMicro.tbxOtrosIngresos.Text != string.Empty)
                {
                    double ingresos = Convert.ToDouble(this.formVarialblesAnalisisMicro.tbxIngresos.Text);
                    double otrosIngresos = Convert.ToDouble(this.formVarialblesAnalisisMicro.tbxOtrosIngresos.Text);

                    double totalIngresos = CodigoComun.CalcularTotalIngresos(ingresos, otrosIngresos, 0.8);
                    this.formVarialblesAnalisisMicro.tbxTotalIngresos.Text = totalIngresos.ToString("N2");
                }
            }
            catch
            {
                formError = new FormError("El Valor de los ingresos no debe ser cero o un valor inválido");
                formError.ShowDialog();
            }
        }
        private void RetornarTotalMora(object sender, EventArgs args)
        {
            if (this.formVarialblesAnalisisMicro.cbxCantidadDeMoras.Text != string.Empty && this.formVarialblesAnalisisMicro.cbxDiasMora.Text != string.Empty)
                this.formVarialblesAnalisisMicro.tbxComportamientoDePagos.Text = CodigoComun.RetornarMorasTotales(this.formVarialblesAnalisisMicro.cbxCantidadDeMoras, this.formVarialblesAnalisisMicro.cbxDiasMora);
        }
        private void RetornarEdad(object sender, EventArgs args)
        {
            
            try
            {
                this.formVarialblesAnalisisMicro.contadorEdad.Value = CodigoComun.CalcularEdad(this.formVarialblesAnalisisMicro.dtpEdad);
            }
            catch
            {

                using (formError = new FormError("Seleccione una fecha de nacimiendo válida, no puede ser superior a la fecha actual"))
                {
                    formError.ShowDialog();
                }
            }
        }
        private void AbrirFormAnalisisCredito(object sender, EventArgs args)
        {
            if (this.formVarialblesAnalisisMicro.tbxNombres.Text != string.Empty
                && this.formVarialblesAnalisisMicro.cbxPeriodicidad.Text != string.Empty && this.formVarialblesAnalisisMicro.cbxGarantia.Text != string.Empty
                && this.formVarialblesAnalisisMicro.tbxProfesion.Text != string.Empty
                && this.formVarialblesAnalisisMicro.tbxCargo.Text != string.Empty && this.formVarialblesAnalisisMicro.tbxOcupacion.Text != string.Empty
                && this.formVarialblesAnalisisMicro.cbxEstadoCivil.Text != string.Empty && this.formVarialblesAnalisisMicro.contadorEdad.Value != 0
                && this.formVarialblesAnalisisMicro.cbxVivienda.Text != string.Empty
                && this.formVarialblesAnalisisMicro.contadorEstrato.Value != 0 && (this.formVarialblesAnalisisMicro.rbtnCiudad.Checked == true ||
                this.formVarialblesAnalisisMicro.rbtnMunicipio.Checked == true) && this.formVarialblesAnalisisMicro.tbxEmpresa.Text != string.Empty
                && this.formVarialblesAnalisisMicro.tbxActividadEconomica.Text != string.Empty && this.formVarialblesAnalisisMicro.cbxTipoDeContrato.Text != string.Empty
                && this.formVarialblesAnalisisMicro.contadorAntLaboral.Value != 0 && this.formVarialblesAnalisisMicro.tbxIngresos.Text != string.Empty
                && this.formVarialblesAnalisisMicro.tbxOtrosIngresos.Text != string.Empty
                && this.formVarialblesAnalisisMicro.contadorScore.Value != 0
                && this.formVarialblesAnalisisMicro.cbxCalificacion.Text != string.Empty && this.formVarialblesAnalisisMicro.tbxIngresosCodeudor.Text != string.Empty
                 && this.formVarialblesAnalisisMicro.tbxEgresosCodeudor.Text != string.Empty && this.formVarialblesAnalisisMicro.tbxEndeudamientoDirectoCodeudor.Text != string.Empty)
            {
                GeneracionDatosCache();
                formAnalisisDeCredito = new FormAnalisisDeCredito();
                formAnalisisDeCredito.ShowDialog();
            }
            else
            {
                formError = new FormError("Ingrese el valor de todas las variables de entrada iniciales para la validación de políticas internas del crédito");
                formError.ShowDialog();
            }
        }
        private void RetornarUtilidadBruta()
        {
            try
            {
                this.formVarialblesAnalisisMicro.tbxUtilidadBrutaMicro.Text = (Convert.ToDouble(this.formVarialblesAnalisisMicro.tbxVentasMicro.Text) -
                Convert.ToDouble(this.formVarialblesAnalisisMicro.tbxCostosDeVentasMicro.Text)).ToString("N2");
            }
            catch
            {
                formError = new FormError("Valor de ventas o costo de ventas en formato incorrecto");
                formError.ShowDialog();
            }
        }
        private void RetornarUtilidadOPerdidaOperativa()
        {
            try
            {
                this.formVarialblesAnalisisMicro.tbxUtilidadOPerdidaOperativa.Text = (Convert.ToDouble(this.formVarialblesAnalisisMicro.tbxUtilidadBrutaMicro.Text) -
                Convert.ToDouble(this.formVarialblesAnalisisMicro.tbxGastosDelNegocio.Text)).ToString("N2");
            }
            catch
            {
                formError = new FormError("Los valores de entrada no poseen un formato correcto");
                formError.ShowDialog();
            }
        }
        private void RetornarUtilidadOPerdidaneta()
        {
            try
            {
                this.formVarialblesAnalisisMicro.tbxUtilidadOPerdidaNeta.Text = (Convert.ToDouble(this.formVarialblesAnalisisMicro.tbxUtilidadOPerdidaOperativa.Text) +
                Convert.ToDouble(this.formVarialblesAnalisisMicro.tbxIngresosFamiliaresYOtros.Text) - Convert.ToDouble(this.formVarialblesAnalisisMicro.tbxGastosFamiliaresYOtros.Text)).ToString("N2");
            }
            catch
            {
                formError = new FormError("Los valores de entrada no poseen un formato correcto");
                formError.ShowDialog();
            }
        }
        private void RetornarUtilidadDisponible()
        {
            try
            {

                this.formVarialblesAnalisisMicro.tbxUtilidadDisponible.Text = (Convert.ToDouble(this.formVarialblesAnalisisMicro.tbxUtilidadOPerdidaNeta.Text) +
                Convert.ToDouble(this.formVarialblesAnalisisMicro.tbxCuotaCreditoARefinanciarMicro.Text)).ToString("N2");
                RetornarMargenDeConfianza();
                RetornarCapacidadDePagoConCuota();
            }
            catch
            {
                formError = new FormError("Los valores de entrada no poseen un formato correcto");
                formError.ShowDialog();
            }
        }
        private void RetornarMargenDeConfianza()
        {
            try
            {
                this.formVarialblesAnalisisMicro.tbxMargenDeConfianza.Text = (Convert.ToDouble(this.formVarialblesAnalisisMicro.tbxCuota.Text) /
                Convert.ToDouble(this.formVarialblesAnalisisMicro.tbxUtilidadDisponible.Text)).ToString("0.00%");
                Cache.MargenDeConfianzaMicro = (Convert.ToDouble(this.formVarialblesAnalisisMicro.tbxCuota.Text) /
                Convert.ToDouble(this.formVarialblesAnalisisMicro.tbxUtilidadDisponible.Text));
            }
            catch
            {
                formError = new FormError("Los valores de entrada no poseen un formato correcto");
                formError.ShowDialog();
            }
        }
        private void RetornarCapacidadDePagoConCuota()
        {
            try
            {
                this.formVarialblesAnalisisMicro.tbxCapacidadDePagoConCuota.Text = ((Convert.ToDouble(this.formVarialblesAnalisisMicro.tbxGastosDelNegocio.Text) +
                Convert.ToDouble(this.formVarialblesAnalisisMicro.tbxGastosFamiliaresYOtros.Text) +
                Convert.ToDouble(this.formVarialblesAnalisisMicro.tbxCuota.Text)) / (
                Convert.ToDouble(this.formVarialblesAnalisisMicro.tbxUtilidadBrutaMicro.Text) +
                Convert.ToDouble(this.formVarialblesAnalisisMicro.tbxIngresosFamiliaresYOtros.Text))).ToString("0.00%");
                Cache.CapaciodadDePagoConCuotaMicro = ((Convert.ToDouble(this.formVarialblesAnalisisMicro.tbxGastosDelNegocio.Text) +
                Convert.ToDouble(this.formVarialblesAnalisisMicro.tbxGastosFamiliaresYOtros.Text) +
                Convert.ToDouble(this.formVarialblesAnalisisMicro.tbxCuota.Text)) / (
                Convert.ToDouble(this.formVarialblesAnalisisMicro.tbxUtilidadBrutaMicro.Text) +
                Convert.ToDouble(this.formVarialblesAnalisisMicro.tbxIngresosFamiliaresYOtros.Text)));
            }
            catch
            {
                formError = new FormError("Los valores de entrada no poseen un formato correcto");
                formError.ShowDialog();
            }
        }
        private void RetornarEndeudamientoDirecto()
        {
            try
            {
                double endeudamientoDirecto;
                endeudamientoDirecto = ((Convert.ToDouble(this.formVarialblesAnalisisMicro.tbxCuotasCentralesDeRiesgo.Text) +
                Convert.ToDouble(this.formVarialblesAnalisisMicro.tbxCuota.Text)) / (
                Convert.ToDouble(this.formVarialblesAnalisisMicro.tbxUtilidadBrutaMicro.Text) +
                Convert.ToDouble(this.formVarialblesAnalisisMicro.tbxIngresosFamiliaresYOtros.Text) -
                Convert.ToDouble(this.formVarialblesAnalisisMicro.tbxGastosDelNegocio.Text) +
                Convert.ToDouble(this.formVarialblesAnalisisMicro.tbxGastosFamiliaresYOtros.Text)));
                this.formVarialblesAnalisisMicro.tbxEndeudamientoDirectoDeudor.Text = endeudamientoDirecto.ToString("0.00%");
                Cache.EndeudamientoDirectodeudorMicro = endeudamientoDirecto;
            }
            catch
            {
                formError = new FormError("Los valores de entrada no poseen un formato correcto");
                formError.ShowDialog();
            }
        }
        private void RetornarEstadosDeResultados(object sender, EventArgs args)
        {
            try
            {
                if (this.formVarialblesAnalisisMicro.tbxVentasMicro.Text != string.Empty && this.formVarialblesAnalisisMicro.tbxCostosDeVentasMicro.Text != string.Empty
                    && this.formVarialblesAnalisisMicro.tbxGastosDelNegocio.Text != string.Empty && this.formVarialblesAnalisisMicro.tbxIngresosFamiliaresYOtros.Text != string.Empty
                    && this.formVarialblesAnalisisMicro.tbxGastosFamiliaresYOtros.Text != string.Empty && this.formVarialblesAnalisisMicro.tbxCuotaCreditoARefinanciarMicro.Text != string.Empty)
                {
                    CodigoComun.Alerta("Correcto", FormVentanaEmergente.enmTipo.exito);
                    RetornarUtilidadBruta();
                    RetornarUtilidadOPerdidaOperativa();
                    RetornarUtilidadOPerdidaneta();
                    RetornarUtilidadDisponible();
                    RetornarMargenDeConfianza();
                    RetornarCapacidadDePagoConCuota();
                    RetornarEndeudamientoDirecto();
                }
                else
                {
                    formError = new FormError("Ingrese las varialbes de entrada en el  estado de resultados para calcular las utilidades");
                    formError.ShowDialog();
                }
            }
            catch
            {
                formError = new FormError("Error en el formato numérico de las variables de entrada");
                formError.ShowDialog();
            }
        }
        private void RetornarEndeudamientoDirectoCodeudor(object sender, EventArgs args)
        {
            try
            {
                if (this.formVarialblesAnalisisMicro.tbxIngresosCodeudor.Text != string.Empty && this.formVarialblesAnalisisMicro.tbxEgresosCodeudor.Text != string.Empty &&
                    this.formVarialblesAnalisisMicro.tbxCuotasCentralesDeRiesgo.Text != string.Empty && this.formVarialblesAnalisisMicro.tbxUtilidadBrutaMicro.Text != string.Empty &&
                    this.formVarialblesAnalisisMicro.tbxIngresosFamiliaresYOtros.Text != string.Empty && this.formVarialblesAnalisisMicro.tbxGastosDelNegocio.Text != string.Empty &&
                    this.formVarialblesAnalisisMicro.tbxGastosFamiliaresYOtros.Text != string.Empty)

                {
                    double endeudamientoDirectoCodeudor;
                 
                    endeudamientoDirectoCodeudor = ((Convert.ToDouble(this.formVarialblesAnalisisMicro.tbxEgresosCodeudor.Text) +
                    Convert.ToDouble(this.formVarialblesAnalisisMicro.tbxCuota.Text)) / Convert.ToDouble(this.formVarialblesAnalisisMicro.tbxIngresosCodeudor.Text));
                    this.formVarialblesAnalisisMicro.tbxEndeudamientoDirectoCodeudor.Text = endeudamientoDirectoCodeudor.ToString("0.00%");

               
                    Cache.EndeudamientoDirectoCodeudorMicro = endeudamientoDirectoCodeudor;
                }
            }
            catch 
            {
                using (formError = new FormError("Error en el formato numérico de las variables de entrada"))
                {
                    formError.ShowDialog();
                }
            }
        }
        private void CambiarScroll(object sender, EventArgs args)
        {
            if (((TextBox)sender).Name == this.formVarialblesAnalisisMicro.tbxIngresos.Name) CodigoComun.SetScroll(this.formVarialblesAnalisisMicro, 300);
            else if (((TextBox)sender).Name == this.formVarialblesAnalisisMicro.tbxIngresosCodeudor.Name) CodigoComun.SetScroll(this.formVarialblesAnalisisMicro, 950);
            else if (((TextBox)sender).Name == this.formVarialblesAnalisisMicro.tbxNombres.Name) CodigoComun.SetScroll(this.formVarialblesAnalisisMicro, 0);
        }
        private void SeleccionarFinalDeTextoIngresos(object sender, EventArgs args)
        {
            foreach (Control control in this.formVarialblesAnalisisMicro.pnlIngresos.Controls)
            {
                if (control is TextBox) { CodigoComun.TextoFinalTextbox((TextBox)control); }
            }
        }
        private void SeleccionarFinalDeTextoEgresos(object sender, EventArgs args)
        {
            foreach (Control control in this.formVarialblesAnalisisMicro.pnlEstadoResultados.Controls)
            {
                if (control is TextBox) { CodigoComun.TextoFinalTextbox((TextBox)control); }
            }
        }
        private void AplicarCodeudor(object sender, EventArgs eventArgs)
        {
            if(this.formVarialblesAnalisisMicro.cbxGarantia.Text != "Codeudor")
            {
                this.formVarialblesAnalisisMicro.tbxIngresosCodeudor.Text = "0";
                this.formVarialblesAnalisisMicro.tbxEgresosCodeudor.Text = "0";
                this.formVarialblesAnalisisMicro.tbxEndeudamientoDirectoCodeudor.Text = "0";
                this.formVarialblesAnalisisMicro.tbxIngresosCodeudor.Enabled = false;
                this.formVarialblesAnalisisMicro.tbxEgresosCodeudor.Enabled = false;
                this.formVarialblesAnalisisMicro.tbxEndeudamientoDirectoCodeudor.Enabled = false;
            }
            else
            {
                this.formVarialblesAnalisisMicro.tbxIngresosCodeudor.Text = string.Empty;
                this.formVarialblesAnalisisMicro.tbxEgresosCodeudor.Text = string.Empty;
                this.formVarialblesAnalisisMicro.tbxEndeudamientoDirectoCodeudor.Text = string.Empty;
                this.formVarialblesAnalisisMicro.tbxIngresosCodeudor.Enabled = true;
                this.formVarialblesAnalisisMicro.tbxEgresosCodeudor.Enabled = true;
                this.formVarialblesAnalisisMicro.tbxEndeudamientoDirectoCodeudor.Enabled = true;
            }
        }
    }
}

using Presentacion.CodigoCompartido;
using Presentacion.Ventanas.VentanaAnalisisDeCredito;
using Presentacion.Ventanas.VentanaAviso;
using Presentacion.Ventanas.VentanaCodeudor;
using Presentacion.Ventanas.VentanaEmergente;
using Presentacion.Ventanas.VentanaError;
using SoporteUsuario.CacheUsuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.FormsCarteras.Vivienda.VariablesAnalisisVivienda
{
    class ControladorFormVariablesAnalisisVivienda
    {
        private FormVariablesAnalisisVivienda formVariablesAnalisisVivienda;
        private FormAnalisisDeCredito formAnalisisDeCredito = new FormAnalisisDeCredito();
        private FormError formError;
        private FormCodeudor formCodeudor;


        public ControladorFormVariablesAnalisisVivienda(FormVariablesAnalisisVivienda formVariablesAnalisisVivienda)
        {
            this.formVariablesAnalisisVivienda = formVariablesAnalisisVivienda;
            this.formVariablesAnalisisVivienda.Load += new EventHandler(CargarForm);
            MensajesTooltip();
            RetornarFormatoTextBox();
            ValidacionSoloNumerosTextBox();
            ValidacionSoloLetrasTextbox();
            EventoBotones();
        }
        private void CargarForm(object sender, EventArgs args)
        {
            this.formVariablesAnalisisVivienda.tbxCedula.Text = Cache.Cedula;
            this.formVariablesAnalisisVivienda.tbxMonto.Text = Cache.Monto.ToString("N2");
            this.formVariablesAnalisisVivienda.tbxCuota.Text = Cache.Cuota.ToString("N2");
            this.formVariablesAnalisisVivienda.contadorPlazo.Value = Cache.Plazo;
            this.formVariablesAnalisisVivienda.contadorTasa.Value = Cache.Tasa;

        }
        private void EventoBotones()
        {
            this.formVariablesAnalisisVivienda.tbxIngresos.TextChanged += new EventHandler(RetornarTotalIngresos);
            this.formVariablesAnalisisVivienda.tbxOtrosIngresos.TextChanged += new EventHandler(RetornarTotalIngresos);
            this.formVariablesAnalisisVivienda.btnCalcularEndeudamientoGlobal.Click += new EventHandler(RetornarEndeudamientoGlobal);
            this.formVariablesAnalisisVivienda.btnCalcularDisponible.Click += new EventHandler(RetornarDisponible);
            this.formVariablesAnalisisVivienda.cbxDiasMora.TextChanged += new EventHandler(RetornarTotalMora);
            this.formVariablesAnalisisVivienda.cbxCantidadDeMoras.TextChanged += new EventHandler(RetornarTotalMora);
            this.formVariablesAnalisisVivienda.dtpEdad.ValueChanged += new EventHandler(RetornarEdad);
            this.formVariablesAnalisisVivienda.btnAnalizar.Click += new EventHandler(AbrirFormAnalisisCredito);
            this.formVariablesAnalisisVivienda.tbxDeduccionesDeSeguridadSocial.TextChanged += new EventHandler(RetornarTotalDeducciones);
            this.formVariablesAnalisisVivienda.tbxOtrasDeduccionesColilla.TextChanged += new EventHandler(RetornarTotalDeducciones);
            this.formVariablesAnalisisVivienda.btnCodeudor.Click += new EventHandler(AbrirFormCodeudor);
        }
        private void MensajesTooltip()
        {
            this.formVariablesAnalisisVivienda.ttMensajesFormVivienda.SetToolTip(this.formVariablesAnalisisVivienda.tbxNombres, "Ingrese los nombres del solicitante.");
            this.formVariablesAnalisisVivienda.ttMensajesFormVivienda.SetToolTip(this.formVariablesAnalisisVivienda.tbxApellidos, "Ingrese los apellidos del solicitante.");
            this.formVariablesAnalisisVivienda.ttMensajesFormVivienda.SetToolTip(this.formVariablesAnalisisVivienda.cbxPeriodicidad, "Ingrese la peridicidad de pago del crédito.");
            this.formVariablesAnalisisVivienda.ttMensajesFormVivienda.SetToolTip(this.formVariablesAnalisisVivienda.cbxGarantia, "Ingrese La garantía del crédito a analizar.");
            this.formVariablesAnalisisVivienda.ttMensajesFormVivienda.SetToolTip(this.formVariablesAnalisisVivienda.cbxTipoDeCredito, "Ingrese el tipo de crédito de vivienda.");
            this.formVariablesAnalisisVivienda.ttMensajesFormVivienda.SetToolTip(this.formVariablesAnalisisVivienda.dtpEdad, "Ingrese la fecha de nacimiento del solicitante.");
            this.formVariablesAnalisisVivienda.ttMensajesFormVivienda.SetToolTip(this.formVariablesAnalisisVivienda.tbxProfesion, "Ingrese La profesión del solicitante.");
            this.formVariablesAnalisisVivienda.ttMensajesFormVivienda.SetToolTip(this.formVariablesAnalisisVivienda.tbxCargo, "Ingrese el cargo actual del solicitante.");
            this.formVariablesAnalisisVivienda.ttMensajesFormVivienda.SetToolTip(this.formVariablesAnalisisVivienda.tbxOcupacion, "Ingrese la ocupación actual del solicitante.");
            this.formVariablesAnalisisVivienda.ttMensajesFormVivienda.SetToolTip(this.formVariablesAnalisisVivienda.cbxEstadoCivil, "Ingrese el estado civil actual solicitante.");
            this.formVariablesAnalisisVivienda.ttMensajesFormVivienda.SetToolTip(this.formVariablesAnalisisVivienda.contadorEdad, "Ingrese la edad en años del solicitante.");
            this.formVariablesAnalisisVivienda.ttMensajesFormVivienda.SetToolTip(this.formVariablesAnalisisVivienda.contadorPersonasACargo, "Ingrese la cantidad de personas a cargo del solicitante.");
            this.formVariablesAnalisisVivienda.ttMensajesFormVivienda.SetToolTip(this.formVariablesAnalisisVivienda.cbxVivienda, "Ingrese el tipo de vivienda del solicitante.");
            this.formVariablesAnalisisVivienda.ttMensajesFormVivienda.SetToolTip(this.formVariablesAnalisisVivienda.contadorEstrato, "Ingrese el estrato económico del solicitante.");
            this.formVariablesAnalisisVivienda.ttMensajesFormVivienda.SetToolTip(this.formVariablesAnalisisVivienda.rbtnCiudad, "El solicitante vive actualmente en una zona urbana.");
            this.formVariablesAnalisisVivienda.ttMensajesFormVivienda.SetToolTip(this.formVariablesAnalisisVivienda.rbtnMunicipio, "El solicitante vive actualmente en una zona rural.");
            this.formVariablesAnalisisVivienda.ttMensajesFormVivienda.SetToolTip(this.formVariablesAnalisisVivienda.tbxIngresos, "ingresos mensuales actuales del solicitante; sin puntos ni comas.");
            this.formVariablesAnalisisVivienda.ttMensajesFormVivienda.SetToolTip(this.formVariablesAnalisisVivienda.tbxOtrosIngresos, "Otros ingresos mensuales actuales del solicitante; sin puntos ni comas.");
            this.formVariablesAnalisisVivienda.ttMensajesFormVivienda.SetToolTip(this.formVariablesAnalisisVivienda.tbxEmpresa, "Nombre de la empresa donde trabaja el solicitante.");
            this.formVariablesAnalisisVivienda.ttMensajesFormVivienda.SetToolTip(this.formVariablesAnalisisVivienda.tbxActividadEconomica, "Actividad económica de la emprea.");
            this.formVariablesAnalisisVivienda.ttMensajesFormVivienda.SetToolTip(this.formVariablesAnalisisVivienda.cbxTipoDeContrato, "Tipo de contrato laboral del solicitante.");
            this.formVariablesAnalisisVivienda.ttMensajesFormVivienda.SetToolTip(this.formVariablesAnalisisVivienda.contadorAntLaboral, "Antigüedad laboral en meses.");

            this.formVariablesAnalisisVivienda.ttMensajesFormVivienda.SetToolTip(this.formVariablesAnalisisVivienda.tbxDeduccionesColilla, "Total deducciones registradas en la colilla de pago.");
            this.formVariablesAnalisisVivienda.ttMensajesFormVivienda.SetToolTip(this.formVariablesAnalisisVivienda.tbxCuotaCentrales, "Total cuotas mensuales registradas en las centrales.");
            this.formVariablesAnalisisVivienda.ttMensajesFormVivienda.SetToolTip(this.formVariablesAnalisisVivienda.tbxCuotasACancelar, "Cuotas a cancelar mediante el crédito solicitado.");
            this.formVariablesAnalisisVivienda.ttMensajesFormVivienda.SetToolTip(this.formVariablesAnalisisVivienda.tbxCupoRotativo, "Estimación de la cuota del cupo rotativo.");
            this.formVariablesAnalisisVivienda.ttMensajesFormVivienda.SetToolTip(this.formVariablesAnalisisVivienda.tbxValorCuotaLibranza, "Valor a compensar de la cuota registrada en colilla.");
            this.formVariablesAnalisisVivienda.ttMensajesFormVivienda.SetToolTip(this.formVariablesAnalisisVivienda.tbxCuotasCreditoCacelarNomina, "Cuota del crédito a refinanciar por nómina.");
            this.formVariablesAnalisisVivienda.ttMensajesFormVivienda.SetToolTip(this.formVariablesAnalisisVivienda.tbxEstimacionTarjetasCredito, "Estimación de la cuota del cupo de la tarjeta de crédito.");
            this.formVariablesAnalisisVivienda.ttMensajesFormVivienda.SetToolTip(this.formVariablesAnalisisVivienda.tbxDeduccionesDeSeguridadSocial, "Valor de las deducciones asociadas a la seguridad social.");
            this.formVariablesAnalisisVivienda.ttMensajesFormVivienda.SetToolTip(this.formVariablesAnalisisVivienda.tbxOtrasDeduccionesColilla, "Otras deducciones asociadas a la colilla.");

            this.formVariablesAnalisisVivienda.ttMensajesFormVivienda.SetToolTip(this.formVariablesAnalisisVivienda.contadorScore, "Ingrese el score del solicitante.");
            this.formVariablesAnalisisVivienda.ttMensajesFormVivienda.SetToolTip(this.formVariablesAnalisisVivienda.cbxCalificacion, "Ingrese la calificación del solicitante.");
            this.formVariablesAnalisisVivienda.ttMensajesFormVivienda.SetToolTip(this.formVariablesAnalisisVivienda.btnAnalizar, "Analizar crédito según cumplimiento de políticas internas.");
            this.formVariablesAnalisisVivienda.ttMensajesFormVivienda.SetToolTip(this.formVariablesAnalisisVivienda.cbxCantidadDeMoras, "Ingrese el número mayor de moras que registra el solicitante.");
            this.formVariablesAnalisisVivienda.ttMensajesFormVivienda.SetToolTip(this.formVariablesAnalisisVivienda.cbxDiasMora, "Ingrese los días de mora que registra el solicitante.");

        }
        private void RetornarFormatoTextBox()
        {
            this.formVariablesAnalisisVivienda.tbxIngresos.Leave += new EventHandler(FormatoNumeroTexBox);
            this.formVariablesAnalisisVivienda.tbxOtrosIngresos.Leave += new EventHandler(FormatoNumeroTexBox);
            this.formVariablesAnalisisVivienda.tbxDeduccionesColilla.Leave += new EventHandler(FormatoNumeroTexBox);
            this.formVariablesAnalisisVivienda.tbxCuotaCentrales.Leave += new EventHandler(FormatoNumeroTexBox);
            this.formVariablesAnalisisVivienda.tbxCuotasACancelar.Leave += new EventHandler(FormatoNumeroTexBox);
            this.formVariablesAnalisisVivienda.tbxCupoRotativo.Leave += new EventHandler(FormatoNumeroTexBox);
            this.formVariablesAnalisisVivienda.tbxValorCuotaLibranza.Leave += new EventHandler(FormatoNumeroTexBox);
            this.formVariablesAnalisisVivienda.tbxCuotasCreditoCacelarNomina.Leave += new EventHandler(FormatoNumeroTexBox);
            this.formVariablesAnalisisVivienda.tbxEstimacionTarjetasCredito.Leave += new EventHandler(FormatoNumeroTexBox);
            this.formVariablesAnalisisVivienda.tbxDeduccionesDeSeguridadSocial.Leave += new EventHandler(FormatoNumeroTexBox);
            this.formVariablesAnalisisVivienda.tbxOtrasDeduccionesColilla.Leave += new EventHandler(FormatoNumeroTexBox);

        }
        private void FormatoNumeroTexBox(object sender, EventArgs args)
        {
            if (((TextBox)sender).Name == this.formVariablesAnalisisVivienda.tbxIngresos.Name && this.formVariablesAnalisisVivienda.tbxIngresos.Text != string.Empty)
                this.formVariablesAnalisisVivienda.tbxIngresos.Text = string.Format("{0:n0}", double.Parse(this.formVariablesAnalisisVivienda.tbxIngresos.Text));
            else if (((TextBox)sender).Name == this.formVariablesAnalisisVivienda.tbxOtrosIngresos.Name && this.formVariablesAnalisisVivienda.tbxOtrosIngresos.Text != string.Empty)
                this.formVariablesAnalisisVivienda.tbxOtrosIngresos.Text = string.Format("{0:n0}", double.Parse(this.formVariablesAnalisisVivienda.tbxOtrosIngresos.Text));
            else if (((TextBox)sender).Name == this.formVariablesAnalisisVivienda.tbxDeduccionesColilla.Name && this.formVariablesAnalisisVivienda.tbxDeduccionesColilla.Text != string.Empty)
                this.formVariablesAnalisisVivienda.tbxDeduccionesColilla.Text = string.Format("{0:n0}", double.Parse(this.formVariablesAnalisisVivienda.tbxDeduccionesColilla.Text));
            else if (((TextBox)sender).Name == this.formVariablesAnalisisVivienda.tbxCuotaCentrales.Name && this.formVariablesAnalisisVivienda.tbxCuotaCentrales.Text != string.Empty)
                this.formVariablesAnalisisVivienda.tbxCuotaCentrales.Text = string.Format("{0:n0}", double.Parse(this.formVariablesAnalisisVivienda.tbxCuotaCentrales.Text));
            else if (((TextBox)sender).Name == this.formVariablesAnalisisVivienda.tbxCupoRotativo.Name && this.formVariablesAnalisisVivienda.tbxCupoRotativo.Text != string.Empty)
                this.formVariablesAnalisisVivienda.tbxCupoRotativo.Text = string.Format("{0:n0}", double.Parse(this.formVariablesAnalisisVivienda.tbxCupoRotativo.Text));
            else if (((TextBox)sender).Name == this.formVariablesAnalisisVivienda.tbxCuotasACancelar.Name && this.formVariablesAnalisisVivienda.tbxCuotasACancelar.Text != string.Empty)
                this.formVariablesAnalisisVivienda.tbxCuotasACancelar.Text = string.Format("{0:n0}", double.Parse(this.formVariablesAnalisisVivienda.tbxCuotasACancelar.Text));
            else if (((TextBox)sender).Name == this.formVariablesAnalisisVivienda.tbxValorCuotaLibranza.Name && this.formVariablesAnalisisVivienda.tbxValorCuotaLibranza.Text != string.Empty)
                this.formVariablesAnalisisVivienda.tbxValorCuotaLibranza.Text = string.Format("{0:n0}", double.Parse(this.formVariablesAnalisisVivienda.tbxValorCuotaLibranza.Text));
            else if (((TextBox)sender).Name == this.formVariablesAnalisisVivienda.tbxCuotasCreditoCacelarNomina.Name && this.formVariablesAnalisisVivienda.tbxCuotasCreditoCacelarNomina.Text != string.Empty)
                this.formVariablesAnalisisVivienda.tbxCuotasCreditoCacelarNomina.Text = string.Format("{0:n0}", double.Parse(this.formVariablesAnalisisVivienda.tbxCuotasCreditoCacelarNomina.Text));
            else if (((TextBox)sender).Name == this.formVariablesAnalisisVivienda.tbxEstimacionTarjetasCredito.Name && this.formVariablesAnalisisVivienda.tbxEstimacionTarjetasCredito.Text != string.Empty)
                this.formVariablesAnalisisVivienda.tbxEstimacionTarjetasCredito.Text = string.Format("{0:n0}", double.Parse(this.formVariablesAnalisisVivienda.tbxEstimacionTarjetasCredito.Text));
            else if (((TextBox)sender).Name == this.formVariablesAnalisisVivienda.tbxDeduccionesDeSeguridadSocial.Name && this.formVariablesAnalisisVivienda.tbxDeduccionesDeSeguridadSocial.Text != string.Empty)
                this.formVariablesAnalisisVivienda.tbxDeduccionesDeSeguridadSocial.Text = string.Format("{0:n0}", double.Parse(this.formVariablesAnalisisVivienda.tbxDeduccionesDeSeguridadSocial.Text));
            else if (((TextBox)sender).Name == this.formVariablesAnalisisVivienda.tbxOtrasDeduccionesColilla.Name && this.formVariablesAnalisisVivienda.tbxOtrasDeduccionesColilla.Text != string.Empty)
                this.formVariablesAnalisisVivienda.tbxOtrasDeduccionesColilla.Text = string.Format("{0:n0}", double.Parse(this.formVariablesAnalisisVivienda.tbxOtrasDeduccionesColilla.Text));

        }
        private void ValidacionSoloNumerosTextBox()
        {
            this.formVariablesAnalisisVivienda.tbxIngresos.KeyPress += new KeyPressEventHandler(CodigoComun.ValidarTextBoxNumero);
            this.formVariablesAnalisisVivienda.tbxOtrosIngresos.KeyPress += new KeyPressEventHandler(CodigoComun.ValidarTextBoxNumero);
            this.formVariablesAnalisisVivienda.tbxDeduccionesColilla.KeyPress += new KeyPressEventHandler(CodigoComun.ValidarTextBoxNumero);
            this.formVariablesAnalisisVivienda.tbxCuotaCentrales.KeyPress += new KeyPressEventHandler(CodigoComun.ValidarTextBoxNumero);
            this.formVariablesAnalisisVivienda.tbxCuotasACancelar.KeyPress += new KeyPressEventHandler(CodigoComun.ValidarTextBoxNumero);
            this.formVariablesAnalisisVivienda.tbxCupoRotativo.KeyPress += new KeyPressEventHandler(CodigoComun.ValidarTextBoxNumero);
            this.formVariablesAnalisisVivienda.tbxValorCuotaLibranza.KeyPress += new KeyPressEventHandler(CodigoComun.ValidarTextBoxNumero);
            this.formVariablesAnalisisVivienda.tbxCuotasCreditoCacelarNomina.KeyPress += new KeyPressEventHandler(CodigoComun.ValidarTextBoxNumero);
            this.formVariablesAnalisisVivienda.tbxEstimacionTarjetasCredito.KeyPress += new KeyPressEventHandler(CodigoComun.ValidarTextBoxNumero);
            this.formVariablesAnalisisVivienda.tbxDeduccionesDeSeguridadSocial.KeyPress += new KeyPressEventHandler(CodigoComun.ValidarTextBoxNumero);
            this.formVariablesAnalisisVivienda.tbxOtrasDeduccionesColilla.KeyPress += new KeyPressEventHandler(CodigoComun.ValidarTextBoxNumero);

        }

        private void ValidacionSoloLetrasTextbox()
        {
            this.formVariablesAnalisisVivienda.tbxNombres.KeyPress += new KeyPressEventHandler(CodigoComun.ValidarTextBoxLetras);
            this.formVariablesAnalisisVivienda.tbxApellidos.KeyPress += new KeyPressEventHandler(CodigoComun.ValidarTextBoxLetras);
            this.formVariablesAnalisisVivienda.tbxProfesion.KeyPress += new KeyPressEventHandler(CodigoComun.ValidarTextBoxLetras);
            this.formVariablesAnalisisVivienda.tbxCargo.KeyPress += new KeyPressEventHandler(CodigoComun.ValidarTextBoxLetras);
            this.formVariablesAnalisisVivienda.tbxOcupacion.KeyPress += new KeyPressEventHandler(CodigoComun.ValidarTextBoxLetras);
            this.formVariablesAnalisisVivienda.tbxEmpresa.KeyPress += new KeyPressEventHandler(CodigoComun.ValidarTextBoxLetras);
            this.formVariablesAnalisisVivienda.tbxActividadEconomica.KeyPress += new KeyPressEventHandler(CodigoComun.ValidarTextBoxLetras);
        }
        private void GeneracionDatosCache()
        {

            Cache.FormaDePago = string.Empty;

            //Tipo de crédito
            if (this.formVariablesAnalisisVivienda.cbxTipoDeCredito.Text == "Mejora de vivienda") Cache.TipoDeCreditoVivienda = "Mejora de vivienda";
            else if (this.formVariablesAnalisisVivienda.cbxTipoDeCredito.Text == "Compra de vivienda nueva") Cache.TipoDeCreditoVivienda = "Compra de vivienda nueva";
            else if (this.formVariablesAnalisisVivienda.cbxTipoDeCredito.Text == "Compra de vivienda usada") Cache.TipoDeCreditoVivienda = "Compra de vivienda usada";

            //Garantia
            if (this.formVariablesAnalisisVivienda.cbxGarantia.Text == "Codeudor") Cache.Garantia = "Codeudor";
            else if (this.formVariablesAnalisisVivienda.cbxGarantia.Text == "Hipoteca") Cache.Garantia = "Hipoteca";
            else if (this.formVariablesAnalisisVivienda.cbxGarantia.Text == "Sin garantía") Cache.Garantia = "Sin garantía";

            if (this.formVariablesAnalisisVivienda.cbxPeriodicidad.Text == "Quincenal") Cache.Periodicidad = "Quincenal";
            else if (this.formVariablesAnalisisVivienda.cbxPeriodicidad.Text == "Mensual") Cache.Periodicidad = "Mensual";

            if (this.formVariablesAnalisisVivienda.cbxEstadoCivil.Text == "Soltero") Cache.EstadoCivil = "Soltero";
            else if (this.formVariablesAnalisisVivienda.cbxEstadoCivil.Text == "Casado") Cache.EstadoCivil = "Casado";
            else if (this.formVariablesAnalisisVivienda.cbxEstadoCivil.Text == "Union libre") Cache.EstadoCivil = "Union libre";
            else if (this.formVariablesAnalisisVivienda.cbxEstadoCivil.Text == "Viudo") Cache.EstadoCivil = "Viudo";

            if (this.formVariablesAnalisisVivienda.cbxVivienda.Text == "Arrendada") Cache.Vivienda = "Arrendada";
            else if (this.formVariablesAnalisisVivienda.cbxVivienda.Text == "Casado") Cache.Vivienda = "Propia";
            else if (this.formVariablesAnalisisVivienda.cbxVivienda.Text == "Union libre") Cache.Vivienda = "Familiar";

            if (this.formVariablesAnalisisVivienda.rbtnCiudad.Checked == true) Cache.CiudadMunicipio = "Ciudad";
            else if (this.formVariablesAnalisisVivienda.rbtnMunicipio.Checked == true) Cache.CiudadMunicipio = "Municipio";

            if (this.formVariablesAnalisisVivienda.cbxCalificacion.Text == "AAA") Cache.Calificacion = "AAA";
            else if (this.formVariablesAnalisisVivienda.cbxCalificacion.Text == "AA") Cache.Calificacion = "AA";
            else if (this.formVariablesAnalisisVivienda.cbxCalificacion.Text == "A") Cache.Calificacion = "A";
            else if (this.formVariablesAnalisisVivienda.cbxCalificacion.Text == "BBB") Cache.Calificacion = "BBB";
            else if (this.formVariablesAnalisisVivienda.cbxCalificacion.Text == "BB") Cache.Calificacion = "BB";
            else if (this.formVariablesAnalisisVivienda.cbxCalificacion.Text == "B") Cache.Calificacion = "B";
            else if (this.formVariablesAnalisisVivienda.cbxCalificacion.Text == "C") Cache.Calificacion = "C";
            else if (this.formVariablesAnalisisVivienda.cbxCalificacion.Text == "D") Cache.Calificacion = "D";
            else if (this.formVariablesAnalisisVivienda.cbxCalificacion.Text == "E") Cache.Calificacion = "E";

            Cache.TotalIngresos = Convert.ToDouble(this.formVariablesAnalisisVivienda.tbxTotalIngresos.Text);
            Cache.Score = (double)this.formVariablesAnalisisVivienda.contadorScore.Value;
            Cache.AntLaboral = (double)this.formVariablesAnalisisVivienda.contadorAntLaboral.Value;
            Cache.TipoDeContrato = this.formVariablesAnalisisVivienda.cbxTipoDeContrato.Text;
            Cache.Edad = (int)this.formVariablesAnalisisVivienda.contadorEdad.Value;
            Cache.Nombre = this.formVariablesAnalisisVivienda.tbxNombres.Text;
            Cache.Apellido = this.formVariablesAnalisisVivienda.tbxApellidos.Text;
            Cache.FechaDeNaciento = (this.formVariablesAnalisisVivienda.dtpEdad.Value.Date).ToString();
            Cache.Profesion = this.formVariablesAnalisisVivienda.tbxProfesion.Text;
            Cache.Cargo = this.formVariablesAnalisisVivienda.tbxCargo.Text;
            Cache.Ocupacion = this.formVariablesAnalisisVivienda.tbxOcupacion.Text;
            Cache.PersonasAcargo = (int)this.formVariablesAnalisisVivienda.contadorPersonasACargo.Value;
            Cache.Estrato = (int)this.formVariablesAnalisisVivienda.contadorEstrato.Value;
            Cache.Empresa = this.formVariablesAnalisisVivienda.tbxEmpresa.Text;
            Cache.ActividadEconomica = this.formVariablesAnalisisVivienda.tbxActividadEconomica.Text;
            Cache.CuotasACancelar = Convert.ToDouble(this.formVariablesAnalisisVivienda.tbxCuotasACancelar.Text);
            Cache.EstimacionCupoRotativo = Convert.ToDouble(this.formVariablesAnalisisVivienda.tbxCupoRotativo.Text);
            Cache.CuotasDeCreditoACancelarPorNomina = Convert.ToDouble(this.formVariablesAnalisisVivienda.tbxCuotasCreditoCacelarNomina.Text);
            Cache.EstimacionTarjetasDeCredito = Convert.ToDouble(this.formVariablesAnalisisVivienda.tbxEstimacionTarjetasCredito.Text);
            Cache.NumeroDemoras = Convert.ToInt32(this.formVariablesAnalisisVivienda.cbxCantidadDeMoras.Text);
            Cache.DiasDeMora = Convert.ToInt32(this.formVariablesAnalisisVivienda.cbxDiasMora.Text);
            Cache.DeduccionesDeSeguridadSocial = Convert.ToDouble(this.formVariablesAnalisisVivienda.tbxDeduccionesDeSeguridadSocial.Text);
            Cache.DeduccionesColilla = Convert.ToDouble(this.formVariablesAnalisisVivienda.tbxDeduccionesColilla.Text);
            Cache.ValorCuotaLibranza = Convert.ToDouble(this.formVariablesAnalisisVivienda.tbxValorCuotaLibranza.Text);
            Cache.IngresoBasico = Convert.ToDouble(this.formVariablesAnalisisVivienda.tbxIngresos.Text);
            Cache.TipoDePersona = "Persona natural";

        }

        private void RetornarTotalDeducciones(object sender, EventArgs args)
        {
            try
            {
                if (this.formVariablesAnalisisVivienda.tbxDeduccionesDeSeguridadSocial.Text != string.Empty && this.formVariablesAnalisisVivienda.tbxOtrasDeduccionesColilla.Text != string.Empty)
                {

                    double totalDeduccionesColilla;
                    totalDeduccionesColilla = CodigoComun.RetornarTotalDeducciones(Convert.ToDouble(this.formVariablesAnalisisVivienda.tbxDeduccionesDeSeguridadSocial.Text), Convert.ToDouble(this.formVariablesAnalisisVivienda.tbxOtrasDeduccionesColilla.Text));
                    this.formVariablesAnalisisVivienda.tbxDeduccionesColilla.Text = totalDeduccionesColilla.ToString("N2");
                }
            }
            catch
            {
                formError = new FormError("El Valor de los ingresos no debe ser cero o un valor inválido");
                formError.ShowDialog();
            }

        }
        private void RetornarTotalIngresos(Object sender, EventArgs args)
        {
            try
            {
                if (this.formVariablesAnalisisVivienda.tbxIngresos.Text != string.Empty && this.formVariablesAnalisisVivienda.tbxOtrosIngresos.Text != string.Empty)
                {
                    double ingresos = Convert.ToDouble(this.formVariablesAnalisisVivienda.tbxIngresos.Text);
                    double otrosIngresos = Convert.ToDouble(this.formVariablesAnalisisVivienda.tbxOtrosIngresos.Text);

                    double totalIngresos = CodigoComun.CalcularTotalIngresos(ingresos, otrosIngresos, 0.8);
                    this.formVariablesAnalisisVivienda.tbxTotalIngresos.Text = totalIngresos.ToString("N2");
                }
            }
            catch
            {
                formError = new FormError("El Valor de los ingresos no debe ser cero o un valor inválido");
                formError.ShowDialog();
            }
        }
        private void RetornarEndeudamientoGlobal(object sender, EventArgs args)
        {
            try
            {
                if (this.formVariablesAnalisisVivienda.tbxDeduccionesColilla.Text != string.Empty &&
                    this.formVariablesAnalisisVivienda.tbxCuotaCentrales.Text != string.Empty &&
                    this.formVariablesAnalisisVivienda.tbxCuotasACancelar.Text != string.Empty &&
                    this.formVariablesAnalisisVivienda.tbxIngresos.Text != string.Empty &&
                    this.formVariablesAnalisisVivienda.cbxVivienda.Text != string.Empty &&
                    this.formVariablesAnalisisVivienda.tbxOtrosIngresos.Text != string.Empty
                    && (this.formVariablesAnalisisVivienda.rbtnCiudad.Checked == true || this.formVariablesAnalisisVivienda.rbtnMunicipio.Checked == true))
                {
                    CodigoComun.Alerta("Correcto", FormVentanaEmergente.enmTipo.exito);
                    CalcularEndeudamientoGlobal();
                }
                else
                {
                    formError = new FormError("Datos insuficientes para calcular el endeudamiento global.");
                    formError.ShowDialog();
                }
            }
            catch (Exception e)
            {
                formError = new FormError($"Error: {e}");
                formError.ShowDialog();
            }
        }
        private void CalcularEndeudamientoGlobal()
        {
            double endeudamientoGlobal;


            endeudamientoGlobal = EndeudamientoGlobal.CalcularEndeudamientoGlobalCaja(Convert.ToDouble(this.formVariablesAnalisisVivienda.tbxDeduccionesColilla.Text),
                Convert.ToDouble(this.formVariablesAnalisisVivienda.tbxCuotaCentrales.Text), Convert.ToDouble(this.formVariablesAnalisisVivienda.tbxCuota.Text), RetornarDANECiudadPueblo(),
                RetornarDANEVivienda(), Convert.ToDouble(this.formVariablesAnalisisVivienda.tbxCuotasACancelar.Text),
                Convert.ToDouble(this.formVariablesAnalisisVivienda.tbxIngresos.Text), Convert.ToDouble(this.formVariablesAnalisisVivienda.tbxOtrosIngresos.Text));
            this.formVariablesAnalisisVivienda.tbxEndeudamientoGlobal.Text = endeudamientoGlobal.ToString("0.00%");
            Cache.EndeudamientoGlobal = endeudamientoGlobal;

        }
        private double RetornarDANEVivienda()
        {
            double ValorDANEVivienda = 0;

            if (this.formVariablesAnalisisVivienda.rbtnCiudad.Checked == true)
            {
                if (this.formVariablesAnalisisVivienda.cbxVivienda.Text == "Arrendada")
                    ValorDANEVivienda = GastosDANE.RetornarDANEViviendaCiudad(true, Convert.ToDouble(this.formVariablesAnalisisVivienda.tbxIngresos.Text));
                else if (this.formVariablesAnalisisVivienda.cbxVivienda.Text == "Familiar")
                    ValorDANEVivienda = GastosDANE.RetornarDANEViviendaCiudad(false, Convert.ToDouble(this.formVariablesAnalisisVivienda.tbxIngresos.Text));
                else
                    ValorDANEVivienda = 0;
            }
            else if (this.formVariablesAnalisisVivienda.rbtnCiudad.Checked == false)
            {
                if (this.formVariablesAnalisisVivienda.cbxVivienda.Text == "Arrendada")
                    ValorDANEVivienda = GastosDANE.RetornarDANEViviendaPueblo(true, Convert.ToDouble(this.formVariablesAnalisisVivienda.tbxIngresos.Text));
                else if (this.formVariablesAnalisisVivienda.cbxVivienda.Text == "Familiar")
                    ValorDANEVivienda = GastosDANE.RetornarDANEViviendaPueblo(false, Convert.ToDouble(this.formVariablesAnalisisVivienda.tbxIngresos.Text));
                else
                    ValorDANEVivienda = 0;
            }
            return ValorDANEVivienda;
        }
        private double RetornarDANECiudadPueblo()
        {
            double ValorDANE;
            ValorDANE = GastosDANE.RetornarDANECiudadPueblo(this.formVariablesAnalisisVivienda.rbtnCiudad.Checked, Convert.ToDouble(this.formVariablesAnalisisVivienda.tbxIngresos.Text));
            return ValorDANE;
        }
        private void RetornarDisponible(object senderm, EventArgs args)
        {

            double disponible;
            try
            {
                if (this.formVariablesAnalisisVivienda.tbxIngresos.Text != string.Empty &&
                   this.formVariablesAnalisisVivienda.tbxDeduccionesColilla.Text != string.Empty &&
                   this.formVariablesAnalisisVivienda.tbxCuotasCreditoCacelarNomina.Text != string.Empty &&
                   this.formVariablesAnalisisVivienda.tbxDeduccionesDeSeguridadSocial.Text != string.Empty &&
                   this.formVariablesAnalisisVivienda.tbxOtrasDeduccionesColilla.Text != string.Empty &&
                   this.formVariablesAnalisisVivienda.tbxOtrosIngresos.Text != string.Empty &&
                   (this.formVariablesAnalisisVivienda.rbtnCiudad.Checked == true || this.formVariablesAnalisisVivienda.rbtnMunicipio.Checked == true) &&
                   this.formVariablesAnalisisVivienda.cbxVivienda.Text != string.Empty &&
                   this.formVariablesAnalisisVivienda.tbxCuotasACancelar.Text != string.Empty)

                {
                    CodigoComun.Alerta("Correcto", FormVentanaEmergente.enmTipo.exito);
                    disponible = Disponible.CalcularDisponibleCaja(Convert.ToDouble(this.formVariablesAnalisisVivienda.tbxIngresos.Text),
                    Convert.ToDouble(this.formVariablesAnalisisVivienda.tbxOtrosIngresos.Text), Convert.ToDouble(this.formVariablesAnalisisVivienda.tbxDeduccionesColilla.Text),
                    RetornarDANECiudadPueblo(), RetornarDANEVivienda(), Convert.ToDouble(this.formVariablesAnalisisVivienda.tbxCuotasACancelar.Text));
                    this.formVariablesAnalisisVivienda.tbxDisponible.Text = disponible.ToString("N2");
                    Cache.Disponible = disponible;
                }
                else
                {
                    formError = new FormError("Datos insuficientes para calcular el disponible.");
                    formError.ShowDialog();
                }
            }
            catch (Exception e)
            {
                formError = new FormError($"Error: {e}");
                formError.ShowDialog();
            }
        }
        private void RetornarTotalMora(object sender, EventArgs args)
        {
            if (this.formVariablesAnalisisVivienda.cbxCantidadDeMoras.Text != string.Empty && this.formVariablesAnalisisVivienda.cbxDiasMora.Text != string.Empty)
                this.formVariablesAnalisisVivienda.tbxComportamientoDePagos.Text = CodigoComun.RetornarMorasTotales(this.formVariablesAnalisisVivienda.cbxCantidadDeMoras, this.formVariablesAnalisisVivienda.cbxDiasMora);
        }

        private void RetornarEdad(object sender, EventArgs args)
        {
            this.formVariablesAnalisisVivienda.contadorEdad.Value = CodigoComun.CalcularEdad(this.formVariablesAnalisisVivienda.dtpEdad);
        }
        private void AbrirFormAnalisisCredito(object sender, EventArgs args)
        {
            if (this.formVariablesAnalisisVivienda.tbxNombres.Text != string.Empty
                && this.formVariablesAnalisisVivienda.cbxPeriodicidad.Text != string.Empty && this.formVariablesAnalisisVivienda.cbxGarantia.Text != string.Empty
                && this.formVariablesAnalisisVivienda.cbxTipoDeCredito.Text != string.Empty && this.formVariablesAnalisisVivienda.tbxProfesion.Text != string.Empty
                && this.formVariablesAnalisisVivienda.tbxCargo.Text != string.Empty && this.formVariablesAnalisisVivienda.tbxOcupacion.Text != string.Empty
                && this.formVariablesAnalisisVivienda.cbxEstadoCivil.Text != string.Empty && this.formVariablesAnalisisVivienda.contadorEdad.Value != 0
                && this.formVariablesAnalisisVivienda.cbxVivienda.Text != string.Empty
                && this.formVariablesAnalisisVivienda.contadorEstrato.Value != 0 && (this.formVariablesAnalisisVivienda.rbtnCiudad.Checked == true ||
                this.formVariablesAnalisisVivienda.rbtnMunicipio.Checked == true) && this.formVariablesAnalisisVivienda.tbxEmpresa.Text != string.Empty
                && this.formVariablesAnalisisVivienda.tbxActividadEconomica.Text != string.Empty && this.formVariablesAnalisisVivienda.cbxTipoDeContrato.Text != string.Empty
                && this.formVariablesAnalisisVivienda.contadorAntLaboral.Value != 0 && this.formVariablesAnalisisVivienda.tbxIngresos.Text != string.Empty
                && this.formVariablesAnalisisVivienda.tbxOtrosIngresos.Text != string.Empty && this.formVariablesAnalisisVivienda.tbxDeduccionesColilla.Text != string.Empty
                && this.formVariablesAnalisisVivienda.tbxCuotaCentrales.Text != string.Empty && this.formVariablesAnalisisVivienda.tbxCuotasACancelar.Text != string.Empty
                && this.formVariablesAnalisisVivienda.tbxEstimacionTarjetasCredito.Text != string.Empty && this.formVariablesAnalisisVivienda.tbxValorCuotaLibranza.Text != string.Empty
                && this.formVariablesAnalisisVivienda.tbxCuotasCreditoCacelarNomina.Text != string.Empty && this.formVariablesAnalisisVivienda.tbxEstimacionTarjetasCredito.Text != string.Empty
                && this.formVariablesAnalisisVivienda.contadorScore.Value != 0
                && this.formVariablesAnalisisVivienda.cbxCalificacion.Text != string.Empty && this.formVariablesAnalisisVivienda.tbxEndeudamientoGlobal.Text != string.Empty)
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
        private void AbrirFormCodeudor(object sender, EventArgs args)
        {
            using (formCodeudor = new FormCodeudor())
            {
                formCodeudor.tbxCuota.Text = this.formVariablesAnalisisVivienda.tbxCuota.Text;
                formCodeudor.ShowDialog();
            }
        }


    }
}

using Presentacion.CodigoCompartido;
using Presentacion.Ventanas.VentanaAnalisisDeCredito;
using Presentacion.Ventanas.VentanaAviso;
using Presentacion.Ventanas.VentanaCodeudor;
using Presentacion.Ventanas.VentanaEmergente;
using Presentacion.Ventanas.VentanaError;
using SoporteUsuario.CacheUsuario;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.FormsCarteras.Comercial.VariablesAnalisisComercial
{
    class ControladorformVariablesAnalisisComercial
    {
        private FormVariablesAnalisisComercial formVariablesAnalisisComercial;
        private FormAnalisisDeCredito formAnalisisDeCredito = new FormAnalisisDeCredito();
        private FormError formError;
        private FormCodeudor formCodeudor;
        private int sumaPosicionX;


        public ControladorformVariablesAnalisisComercial(FormVariablesAnalisisComercial formVariablesAnalisisComercial)
        {
            this.formVariablesAnalisisComercial = formVariablesAnalisisComercial;
            this.formVariablesAnalisisComercial.Load += new EventHandler(CargarForm);

            MensajesTooltip();
            RetornarFormatoTextBox();
            ValidacionSoloNumerosTextBox();
            ValidacionSoloLetrasTextbox();
            EventoBotones();
        }
        private void CargarForm(object sender, EventArgs args)
        {
            this.formVariablesAnalisisComercial.tbxCedula.Text = Cache.Cedula;
            this.formVariablesAnalisisComercial.tbxMonto.Text = Cache.Monto.ToString("N2");
            this.formVariablesAnalisisComercial.tbxCuota.Text = Cache.Cuota.ToString("N2");
            this.formVariablesAnalisisComercial.contadorPlazo.Value = Cache.Plazo;
            this.formVariablesAnalisisComercial.contadorTasa.Value = Cache.Tasa;
            this.formVariablesAnalisisComercial.tbxNombres.Focus();

        }

        private void EventoBotones()
        {
            this.formVariablesAnalisisComercial.tbxIngresos.TextChanged += new EventHandler(RetornarTotalIngresos);
            this.formVariablesAnalisisComercial.tbxOtrosIngresos.TextChanged += new EventHandler(RetornarTotalIngresos);
            this.formVariablesAnalisisComercial.btnCalcularEndeudamientoGlobal.Click += new EventHandler(RetornarEndeudamientoGlobal);
            this.formVariablesAnalisisComercial.btnCalcularDisponible.Click += new EventHandler(RetornarDisponible);
            this.formVariablesAnalisisComercial.cbxDiasMora.TextChanged += new EventHandler(RetornarTotalMora);
            this.formVariablesAnalisisComercial.cbxCantidadDeMoras.TextChanged += new EventHandler(RetornarTotalMora);
            this.formVariablesAnalisisComercial.cbxDiasMora.Leave += new EventHandler(RetornarTotalMora);
            this.formVariablesAnalisisComercial.cbxCantidadDeMoras.Leave += new EventHandler(RetornarTotalMora);
            this.formVariablesAnalisisComercial.dtpEdad.ValueChanged += new EventHandler(RetornarEdad);
            this.formVariablesAnalisisComercial.btnAnalizar.Click += new EventHandler(AbrirFormAnalisisCredito);
            this.formVariablesAnalisisComercial.tbxDeduccionesDeSeguridadSocial.TextChanged += new EventHandler(RetornarTotalDeducciones);
            this.formVariablesAnalisisComercial.tbxOtrasDeduccionesColilla.TextChanged += new EventHandler(RetornarTotalDeducciones);
            this.formVariablesAnalisisComercial.btnCodeudor.Click += new EventHandler(AbrirFormCodeudor);
            this.formVariablesAnalisisComercial.tbxIngresos.Enter += new EventHandler(CambiarScroll);
            this.formVariablesAnalisisComercial.tbxCuotaCentrales.Enter += new EventHandler(CambiarScroll);
            this.formVariablesAnalisisComercial.tbxNombres.Enter +=      new EventHandler(CambiarScroll);
        }
        private void MensajesTooltip()
        {
            this.formVariablesAnalisisComercial.ttMensajesFormComercial.SetToolTip(this.formVariablesAnalisisComercial.tbxNombres, "Ingrese los nombres del solicitante o el nombre completo de la empresa.");
            this.formVariablesAnalisisComercial.ttMensajesFormComercial.SetToolTip(this.formVariablesAnalisisComercial.cbxPeriodicidad, "Ingrese la peridicidad de pago del crédito.");
            this.formVariablesAnalisisComercial.ttMensajesFormComercial.SetToolTip(this.formVariablesAnalisisComercial.cbxGarantia, "Ingrese La garantía del crédito a analizar.");
            this.formVariablesAnalisisComercial.ttMensajesFormComercial.SetToolTip(this.formVariablesAnalisisComercial.cbxTipoDePersona, "Seleccione si es una persona natural o jurídica");
            this.formVariablesAnalisisComercial.ttMensajesFormComercial.SetToolTip(this.formVariablesAnalisisComercial.dtpEdad, "Ingrese la fecha de nacimiento del solicitante sea persona natural o jurídica.");
            this.formVariablesAnalisisComercial.ttMensajesFormComercial.SetToolTip(this.formVariablesAnalisisComercial.tbxProfesion, "Ingrese La profesión del solicitante.");
            this.formVariablesAnalisisComercial.ttMensajesFormComercial.SetToolTip(this.formVariablesAnalisisComercial.tbxCargo, "Ingrese el cargo actual del solicitante.");
            this.formVariablesAnalisisComercial.ttMensajesFormComercial.SetToolTip(this.formVariablesAnalisisComercial.tbxOcupacion, "Ingrese la ocupación actual del solicitante.");
            this.formVariablesAnalisisComercial.ttMensajesFormComercial.SetToolTip(this.formVariablesAnalisisComercial.cbxEstadoCivil, "Ingrese el estado civil actual solicitante.");
            this.formVariablesAnalisisComercial.ttMensajesFormComercial.SetToolTip(this.formVariablesAnalisisComercial.contadorEdad, "Ingrese la edad en años del solicitante.");
            this.formVariablesAnalisisComercial.ttMensajesFormComercial.SetToolTip(this.formVariablesAnalisisComercial.contadorPersonasACargo, "Ingrese la cantidad de personas a cargo del solicitante.");
            this.formVariablesAnalisisComercial.ttMensajesFormComercial.SetToolTip(this.formVariablesAnalisisComercial.cbxVivienda, "Ingrese el tipo de vivienda del solicitante.");
            this.formVariablesAnalisisComercial.ttMensajesFormComercial.SetToolTip(this.formVariablesAnalisisComercial.contadorEstrato, "Ingrese el estrato económico del solicitante.");
            this.formVariablesAnalisisComercial.ttMensajesFormComercial.SetToolTip(this.formVariablesAnalisisComercial.rbtnCiudad, "El solicitante vive actualmente en una zona urbana.");
            this.formVariablesAnalisisComercial.ttMensajesFormComercial.SetToolTip(this.formVariablesAnalisisComercial.rbtnMunicipio, "El solicitante vive actualmente en una zona rural.");
            this.formVariablesAnalisisComercial.ttMensajesFormComercial.SetToolTip(this.formVariablesAnalisisComercial.tbxIngresos, "ingresos mensuales actuales del solicitante; sin puntos ni comas.");
            this.formVariablesAnalisisComercial.ttMensajesFormComercial.SetToolTip(this.formVariablesAnalisisComercial.tbxOtrosIngresos, "Otros ingresos mensuales actuales del solicitante; sin puntos ni comas.");
            this.formVariablesAnalisisComercial.ttMensajesFormComercial.SetToolTip(this.formVariablesAnalisisComercial.cbxDestinoDelCredito, "Si el solicitante es una persona jurídica, especifique el destino del crédito.");
            this.formVariablesAnalisisComercial.ttMensajesFormComercial.SetToolTip(this.formVariablesAnalisisComercial.tbxActividadEconomica, "Actividad económica de la emprea.");
            this.formVariablesAnalisisComercial.ttMensajesFormComercial.SetToolTip(this.formVariablesAnalisisComercial.cbxTipoDeContrato, "Tipo de contrato laboral del solicitante.");
            this.formVariablesAnalisisComercial.ttMensajesFormComercial.SetToolTip(this.formVariablesAnalisisComercial.contadorAntLaboral, "Antigüedad laboral en meses.");

            this.formVariablesAnalisisComercial.ttMensajesFormComercial.SetToolTip(this.formVariablesAnalisisComercial.tbxDeduccionesColilla, "Total deducciones registradas en la colilla de pago.");
            this.formVariablesAnalisisComercial.ttMensajesFormComercial.SetToolTip(this.formVariablesAnalisisComercial.tbxCuotaCentrales, "Total cuotas mensuales registradas en las centrales.");
            this.formVariablesAnalisisComercial.ttMensajesFormComercial.SetToolTip(this.formVariablesAnalisisComercial.tbxCuotasACancelar, "Cuotas a cancelar mediante el crédito solicitado.");
            this.formVariablesAnalisisComercial.ttMensajesFormComercial.SetToolTip(this.formVariablesAnalisisComercial.tbxCupoRotativo, "Estimación de la cuota del cupo rotativo.");
            this.formVariablesAnalisisComercial.ttMensajesFormComercial.SetToolTip(this.formVariablesAnalisisComercial.tbxValorCuotaLibranza, "Valor a compensar de la cuota registrada en colilla.");
            this.formVariablesAnalisisComercial.ttMensajesFormComercial.SetToolTip(this.formVariablesAnalisisComercial.tbxCuotasCreditoCacelarNomina, "Cuota del crédito a refinanciar por nómina.");
            this.formVariablesAnalisisComercial.ttMensajesFormComercial.SetToolTip(this.formVariablesAnalisisComercial.tbxEstimacionTarjetasCredito, "Estimación de la cuota del cupo de la tarjeta de crédito.");
            this.formVariablesAnalisisComercial.ttMensajesFormComercial.SetToolTip(this.formVariablesAnalisisComercial.tbxDeduccionesDeSeguridadSocial, "Valor de las deducciones asociadas a la seguridad social.");
            this.formVariablesAnalisisComercial.ttMensajesFormComercial.SetToolTip(this.formVariablesAnalisisComercial.tbxOtrasDeduccionesColilla, "Otras deducciones asociadas a la colilla.");

            this.formVariablesAnalisisComercial.ttMensajesFormComercial.SetToolTip(this.formVariablesAnalisisComercial.contadorScore, "Ingrese el score del solicitante.");
            this.formVariablesAnalisisComercial.ttMensajesFormComercial.SetToolTip(this.formVariablesAnalisisComercial.cbxCalificacion, "Ingrese la calificación del solicitante.");
            this.formVariablesAnalisisComercial.ttMensajesFormComercial.SetToolTip(this.formVariablesAnalisisComercial.btnAnalizar, "Analizar crédito según cumplimiento de políticas internas.");
            this.formVariablesAnalisisComercial.ttMensajesFormComercial.SetToolTip(this.formVariablesAnalisisComercial.cbxCantidadDeMoras, "Ingrese el número mayor de moras que registra el solicitante.");
            this.formVariablesAnalisisComercial.ttMensajesFormComercial.SetToolTip(this.formVariablesAnalisisComercial.cbxDiasMora, "Ingrese los días de mora que registra el solicitante.");
            this.formVariablesAnalisisComercial.ttMensajesFormComercial.SetToolTip(this.formVariablesAnalisisComercial.btnCalcularEndeudamientoGlobal, "Calcular el endeudamiento global del solicitante.");
            this.formVariablesAnalisisComercial.ttMensajesFormComercial.SetToolTip(this.formVariablesAnalisisComercial.btnCalcularDisponible, "Calcular el disponible del solicitante.");

        }
        private void FormatoNumeroTexBox(object sender, EventArgs args)
        {
            if (((TextBox)sender).Name == this.formVariablesAnalisisComercial.tbxIngresos.Name && this.formVariablesAnalisisComercial.tbxIngresos.Text != string.Empty)
                this.formVariablesAnalisisComercial.tbxIngresos.Text = string.Format("{0:n0}", double.Parse(this.formVariablesAnalisisComercial.tbxIngresos.Text));
            else if (((TextBox)sender).Name == this.formVariablesAnalisisComercial.tbxOtrosIngresos.Name && this.formVariablesAnalisisComercial.tbxOtrosIngresos.Text != string.Empty)
                this.formVariablesAnalisisComercial.tbxOtrosIngresos.Text = string.Format("{0:n0}", double.Parse(this.formVariablesAnalisisComercial.tbxOtrosIngresos.Text));
            else if (((TextBox)sender).Name == this.formVariablesAnalisisComercial.tbxDeduccionesColilla.Name && this.formVariablesAnalisisComercial.tbxDeduccionesColilla.Text != string.Empty)
                this.formVariablesAnalisisComercial.tbxDeduccionesColilla.Text = string.Format("{0:n0}", double.Parse(this.formVariablesAnalisisComercial.tbxDeduccionesColilla.Text));
            else if (((TextBox)sender).Name == this.formVariablesAnalisisComercial.tbxCuotaCentrales.Name && this.formVariablesAnalisisComercial.tbxCuotaCentrales.Text != string.Empty)
                this.formVariablesAnalisisComercial.tbxCuotaCentrales.Text = string.Format("{0:n0}", double.Parse(this.formVariablesAnalisisComercial.tbxCuotaCentrales.Text));
            else if (((TextBox)sender).Name == this.formVariablesAnalisisComercial.tbxCupoRotativo.Name && this.formVariablesAnalisisComercial.tbxCupoRotativo.Text != string.Empty)
                this.formVariablesAnalisisComercial.tbxCupoRotativo.Text = string.Format("{0:n0}", double.Parse(this.formVariablesAnalisisComercial.tbxCupoRotativo.Text));
            else if (((TextBox)sender).Name == this.formVariablesAnalisisComercial.tbxCuotasACancelar.Name && this.formVariablesAnalisisComercial.tbxCuotasACancelar.Text != string.Empty)
                this.formVariablesAnalisisComercial.tbxCuotasACancelar.Text = string.Format("{0:n0}", double.Parse(this.formVariablesAnalisisComercial.tbxCuotasACancelar.Text));
            else if (((TextBox)sender).Name == this.formVariablesAnalisisComercial.tbxValorCuotaLibranza.Name && this.formVariablesAnalisisComercial.tbxValorCuotaLibranza.Text != string.Empty)
                this.formVariablesAnalisisComercial.tbxValorCuotaLibranza.Text = string.Format("{0:n0}", double.Parse(this.formVariablesAnalisisComercial.tbxValorCuotaLibranza.Text));
            else if (((TextBox)sender).Name == this.formVariablesAnalisisComercial.tbxCuotasCreditoCacelarNomina.Name && this.formVariablesAnalisisComercial.tbxCuotasCreditoCacelarNomina.Text != string.Empty)
                this.formVariablesAnalisisComercial.tbxCuotasCreditoCacelarNomina.Text = string.Format("{0:n0}", double.Parse(this.formVariablesAnalisisComercial.tbxCuotasCreditoCacelarNomina.Text));
            else if (((TextBox)sender).Name == this.formVariablesAnalisisComercial.tbxEstimacionTarjetasCredito.Name && this.formVariablesAnalisisComercial.tbxEstimacionTarjetasCredito.Text != string.Empty)
                this.formVariablesAnalisisComercial.tbxEstimacionTarjetasCredito.Text = string.Format("{0:n0}", double.Parse(this.formVariablesAnalisisComercial.tbxEstimacionTarjetasCredito.Text));
            else if (((TextBox)sender).Name == this.formVariablesAnalisisComercial.tbxDeduccionesDeSeguridadSocial.Name && this.formVariablesAnalisisComercial.tbxDeduccionesDeSeguridadSocial.Text != string.Empty)
                this.formVariablesAnalisisComercial.tbxDeduccionesDeSeguridadSocial.Text = string.Format("{0:n0}", double.Parse(this.formVariablesAnalisisComercial.tbxDeduccionesDeSeguridadSocial.Text));
            else if (((TextBox)sender).Name == this.formVariablesAnalisisComercial.tbxOtrasDeduccionesColilla.Name && this.formVariablesAnalisisComercial.tbxOtrasDeduccionesColilla.Text != string.Empty)
                this.formVariablesAnalisisComercial.tbxOtrasDeduccionesColilla.Text = string.Format("{0:n0}", double.Parse(this.formVariablesAnalisisComercial.tbxOtrasDeduccionesColilla.Text));

        }
        private void RetornarFormatoTextBox()
        {
            this.formVariablesAnalisisComercial.tbxIngresos.Leave += new EventHandler(FormatoNumeroTexBox);
            this.formVariablesAnalisisComercial.tbxOtrosIngresos.Leave += new EventHandler(FormatoNumeroTexBox);
            this.formVariablesAnalisisComercial.tbxDeduccionesColilla.Leave += new EventHandler(FormatoNumeroTexBox);
            this.formVariablesAnalisisComercial.tbxCuotaCentrales.Leave += new EventHandler(FormatoNumeroTexBox);
            this.formVariablesAnalisisComercial.tbxCuotasACancelar.Leave += new EventHandler(FormatoNumeroTexBox);
            this.formVariablesAnalisisComercial.tbxCupoRotativo.Leave += new EventHandler(FormatoNumeroTexBox);
            this.formVariablesAnalisisComercial.tbxValorCuotaLibranza.Leave += new EventHandler(FormatoNumeroTexBox);
            this.formVariablesAnalisisComercial.tbxCuotasCreditoCacelarNomina.Leave += new EventHandler(FormatoNumeroTexBox);
            this.formVariablesAnalisisComercial.tbxEstimacionTarjetasCredito.Leave += new EventHandler(FormatoNumeroTexBox);
            this.formVariablesAnalisisComercial.tbxDeduccionesDeSeguridadSocial.Leave += new EventHandler(FormatoNumeroTexBox);
            this.formVariablesAnalisisComercial.tbxOtrasDeduccionesColilla.Leave += new EventHandler(FormatoNumeroTexBox);

        }
        private void ValidacionSoloNumerosTextBox()
        {
            this.formVariablesAnalisisComercial.tbxIngresos.KeyPress += new KeyPressEventHandler(CodigoComun.ValidarTextBoxNumero);
            this.formVariablesAnalisisComercial.tbxOtrosIngresos.KeyPress += new KeyPressEventHandler(CodigoComun.ValidarTextBoxNumero);
            this.formVariablesAnalisisComercial.tbxDeduccionesColilla.KeyPress += new KeyPressEventHandler(CodigoComun.ValidarTextBoxNumero);
            this.formVariablesAnalisisComercial.tbxCuotaCentrales.KeyPress += new KeyPressEventHandler(CodigoComun.ValidarTextBoxNumero);
            this.formVariablesAnalisisComercial.tbxCuotasACancelar.KeyPress += new KeyPressEventHandler(CodigoComun.ValidarTextBoxNumero);
            this.formVariablesAnalisisComercial.tbxCupoRotativo.KeyPress += new KeyPressEventHandler(CodigoComun.ValidarTextBoxNumero);
            this.formVariablesAnalisisComercial.tbxValorCuotaLibranza.KeyPress += new KeyPressEventHandler(CodigoComun.ValidarTextBoxNumero);
            this.formVariablesAnalisisComercial.tbxCuotasCreditoCacelarNomina.KeyPress += new KeyPressEventHandler(CodigoComun.ValidarTextBoxNumero);
            this.formVariablesAnalisisComercial.tbxEstimacionTarjetasCredito.KeyPress += new KeyPressEventHandler(CodigoComun.ValidarTextBoxNumero);
            this.formVariablesAnalisisComercial.tbxDeduccionesDeSeguridadSocial.KeyPress += new KeyPressEventHandler(CodigoComun.ValidarTextBoxNumero);
            this.formVariablesAnalisisComercial.tbxOtrasDeduccionesColilla.KeyPress += new KeyPressEventHandler(CodigoComun.ValidarTextBoxNumero);

        }
        private void ValidacionSoloLetrasTextbox()
        {
            this.formVariablesAnalisisComercial.tbxNombres.KeyPress += new KeyPressEventHandler(CodigoComun.ValidarTextBoxLetras);
            this.formVariablesAnalisisComercial.tbxProfesion.KeyPress += new KeyPressEventHandler(CodigoComun.ValidarTextBoxLetras);
            this.formVariablesAnalisisComercial.tbxCargo.KeyPress += new KeyPressEventHandler(CodigoComun.ValidarTextBoxLetras);
            this.formVariablesAnalisisComercial.tbxOcupacion.KeyPress += new KeyPressEventHandler(CodigoComun.ValidarTextBoxLetras);
            this.formVariablesAnalisisComercial.tbxActividadEconomica.KeyPress += new KeyPressEventHandler(CodigoComun.ValidarTextBoxLetras);
        }

        private void GeneracionDatosCache()
        {

            Cache.FormaDePago = string.Empty;

            //forma de pago
            if (this.formVariablesAnalisisComercial.cbxTipoDePersona.Text == "Persona natural") Cache.TipoDePersona = "Persona natural";
            else if (this.formVariablesAnalisisComercial.cbxTipoDePersona.Text == "Persona jurídica") Cache.TipoDePersona = "Persona jurídica";

            //Garantia
            if (this.formVariablesAnalisisComercial.cbxGarantia.Text == "Codeudor") Cache.Garantia = "Codeudor";
            else if (this.formVariablesAnalisisComercial.cbxGarantia.Text == "Hipoteca") Cache.Garantia = "Hipoteca";
            else if (this.formVariablesAnalisisComercial.cbxGarantia.Text == "Sin garantía") Cache.Garantia = "Sin garantía";
            else Cache.Garantia = "N/A";

            if (this.formVariablesAnalisisComercial.cbxPeriodicidad.Text == "Quincenal") Cache.Periodicidad = "Quincenal";
            else if (this.formVariablesAnalisisComercial.cbxPeriodicidad.Text == "Mensual") Cache.Periodicidad = "Mensual";

            if (this.formVariablesAnalisisComercial.cbxEstadoCivil.Text == "Soltero") Cache.EstadoCivil = "Soltero";
            else if (this.formVariablesAnalisisComercial.cbxEstadoCivil.Text == "Casado") Cache.EstadoCivil = "Casado";
            else if (this.formVariablesAnalisisComercial.cbxEstadoCivil.Text == "Union libre") Cache.EstadoCivil = "Union libre";
            else if (this.formVariablesAnalisisComercial.cbxEstadoCivil.Text == "Viudo") Cache.EstadoCivil = "Viudo";
            else Cache.EstadoCivil = "N/A";

            if (this.formVariablesAnalisisComercial.cbxVivienda.Text == "Arrendada") Cache.Vivienda = "Arrendada";
            else if (this.formVariablesAnalisisComercial.cbxVivienda.Text == "Casado") Cache.Vivienda = "Propia";
            else if (this.formVariablesAnalisisComercial.cbxVivienda.Text == "Union libre") Cache.Vivienda = "Familiar";
            else Cache.Vivienda = "N/A";

            if (this.formVariablesAnalisisComercial.rbtnCiudad.Checked == true) Cache.CiudadMunicipio = "Ciudad";
            else if (this.formVariablesAnalisisComercial.rbtnMunicipio.Checked == true) Cache.CiudadMunicipio = "Municipio";

            if (this.formVariablesAnalisisComercial.cbxDestinoDelCredito.Text == "Capital de trabajo") Cache.DestinoDelCredito = "Capital de trabajo";
            else if (this.formVariablesAnalisisComercial.cbxDestinoDelCredito.Text == "Compra de activos") Cache.DestinoDelCredito = "Compra de activos";
            else if (this.formVariablesAnalisisComercial.cbxDestinoDelCredito.Text == "Unificacion de pasivos") Cache.DestinoDelCredito = "Unificacion de pasivos";
            else Cache.DestinoDelCredito = "N/A";

            if (this.formVariablesAnalisisComercial.cbxCalificacion.Text == "AAA") Cache.Calificacion = "AAA";
            else if (this.formVariablesAnalisisComercial.cbxCalificacion.Text == "AA") Cache.Calificacion = "AA";
            else if (this.formVariablesAnalisisComercial.cbxCalificacion.Text == "A") Cache.Calificacion = "A";
            else if (this.formVariablesAnalisisComercial.cbxCalificacion.Text == "BBB") Cache.Calificacion = "BBB";
            else if (this.formVariablesAnalisisComercial.cbxCalificacion.Text == "BB") Cache.Calificacion = "BB";
            else if (this.formVariablesAnalisisComercial.cbxCalificacion.Text == "B") Cache.Calificacion = "B";
            else if (this.formVariablesAnalisisComercial.cbxCalificacion.Text == "C") Cache.Calificacion = "C";
            else if (this.formVariablesAnalisisComercial.cbxCalificacion.Text == "D") Cache.Calificacion = "D";
            else if (this.formVariablesAnalisisComercial.cbxCalificacion.Text == "E") Cache.Calificacion = "E";

            Cache.TotalIngresos = Convert.ToDouble(this.formVariablesAnalisisComercial.tbxTotalIngresos.Text);
            Cache.Score = (double)this.formVariablesAnalisisComercial.contadorScore.Value;
            Cache.AntLaboral = (double)this.formVariablesAnalisisComercial.contadorAntLaboral.Value;
            Cache.TipoDeContrato = this.formVariablesAnalisisComercial.cbxTipoDeContrato.Text;
            Cache.Edad = (int)this.formVariablesAnalisisComercial.contadorEdad.Value;
            Cache.Nombre = this.formVariablesAnalisisComercial.tbxNombres.Text;
            Cache.Apellido = " ";
            Cache.FechaDeNaciento = (this.formVariablesAnalisisComercial.dtpEdad.Value.Date).ToString();
            Cache.Profesion = this.formVariablesAnalisisComercial.tbxProfesion.Text;
            Cache.Cargo = this.formVariablesAnalisisComercial.tbxCargo.Text;
            Cache.Ocupacion = this.formVariablesAnalisisComercial.tbxOcupacion.Text;
            Cache.PersonasAcargo = (int)this.formVariablesAnalisisComercial.contadorPersonasACargo.Value;
            Cache.Estrato = (int)this.formVariablesAnalisisComercial.contadorEstrato.Value;
            Cache.Empresa = this.formVariablesAnalisisComercial.tbxNombres.Text;
            Cache.ActividadEconomica = this.formVariablesAnalisisComercial.tbxActividadEconomica.Text;
            Cache.CuotasACancelar = Convert.ToDouble(this.formVariablesAnalisisComercial.tbxCuotasACancelar.Text);
            Cache.EstimacionCupoRotativo = Convert.ToDouble(this.formVariablesAnalisisComercial.tbxCupoRotativo.Text);
            Cache.CuotasDeCreditoACancelarPorNomina = Convert.ToDouble(this.formVariablesAnalisisComercial.tbxCuotasCreditoCacelarNomina.Text);
            Cache.EstimacionTarjetasDeCredito = Convert.ToDouble(this.formVariablesAnalisisComercial.tbxEstimacionTarjetasCredito.Text);
            Cache.NumeroDemoras = Convert.ToInt32(this.formVariablesAnalisisComercial.cbxCantidadDeMoras.Text);
            Cache.DiasDeMora = Convert.ToInt32(this.formVariablesAnalisisComercial.cbxDiasMora.Text);
            Cache.DeduccionesDeSeguridadSocial = Convert.ToDouble(this.formVariablesAnalisisComercial.tbxDeduccionesDeSeguridadSocial.Text);
            Cache.DeduccionesColilla = Convert.ToDouble(this.formVariablesAnalisisComercial.tbxDeduccionesColilla.Text);
            Cache.ValorCuotaLibranza = Convert.ToDouble(this.formVariablesAnalisisComercial.tbxValorCuotaLibranza.Text);
            Cache.IngresoBasico = Convert.ToDouble(this.formVariablesAnalisisComercial.tbxIngresos.Text);
            Cache.FormaDePago = "Caja";
        }

        private void RetornarTotalIngresos(Object sender, EventArgs args)
        {
            try
            {
                if (this.formVariablesAnalisisComercial.tbxIngresos.Text != string.Empty && this.formVariablesAnalisisComercial.tbxOtrosIngresos.Text != string.Empty)
                {
                    double ingresos = Convert.ToDouble(this.formVariablesAnalisisComercial.tbxIngresos.Text);
                    double otrosIngresos = Convert.ToDouble(this.formVariablesAnalisisComercial.tbxOtrosIngresos.Text);

                    double totalIngresos = CodigoComun.CalcularTotalIngresos(ingresos, otrosIngresos, 0.8);
                    this.formVariablesAnalisisComercial.tbxTotalIngresos.Text = totalIngresos.ToString("N2");
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
                if (this.formVariablesAnalisisComercial.tbxDeduccionesColilla.Text != string.Empty &&
                    this.formVariablesAnalisisComercial.tbxCuotaCentrales.Text != string.Empty &&
                    this.formVariablesAnalisisComercial.tbxCuotasACancelar.Text != string.Empty &&
                    this.formVariablesAnalisisComercial.tbxIngresos.Text != string.Empty &&
                    this.formVariablesAnalisisComercial.cbxVivienda.Text != string.Empty &&
                    this.formVariablesAnalisisComercial.tbxOtrosIngresos.Text != string.Empty
                    && (this.formVariablesAnalisisComercial.rbtnCiudad.Checked == true || this.formVariablesAnalisisComercial.rbtnMunicipio.Checked == true))
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


            endeudamientoGlobal = EndeudamientoGlobal.CalcularEndeudamientoGlobalCaja(Convert.ToDouble(this.formVariablesAnalisisComercial.tbxDeduccionesColilla.Text),
                Convert.ToDouble(this.formVariablesAnalisisComercial.tbxCuotaCentrales.Text), Convert.ToDouble(this.formVariablesAnalisisComercial.tbxCuota.Text), RetornarDANECiudadPueblo(),
                RetornarDANEVivienda(), Convert.ToDouble(this.formVariablesAnalisisComercial.tbxCuotasACancelar.Text),
                Convert.ToDouble(this.formVariablesAnalisisComercial.tbxIngresos.Text), Convert.ToDouble(this.formVariablesAnalisisComercial.tbxOtrosIngresos.Text));
            this.formVariablesAnalisisComercial.tbxEndeudamientoGlobal.Text = endeudamientoGlobal.ToString("0.00%");
            Cache.EndeudamientoGlobal = endeudamientoGlobal;

        }

        private double RetornarDANEVivienda()
        {
            double ValorDANEVivienda = 0;

            if (this.formVariablesAnalisisComercial.rbtnCiudad.Checked == true)
            {
                if (this.formVariablesAnalisisComercial.cbxVivienda.Text == "Arrendada")
                    ValorDANEVivienda = GastosDANE.RetornarDANEViviendaCiudad(true, Convert.ToDouble(this.formVariablesAnalisisComercial.tbxIngresos.Text));
                else if (this.formVariablesAnalisisComercial.cbxVivienda.Text == "Familiar")
                    ValorDANEVivienda = GastosDANE.RetornarDANEViviendaCiudad(false, Convert.ToDouble(this.formVariablesAnalisisComercial.tbxIngresos.Text));
                else
                    ValorDANEVivienda = 0;
            }
            else if (this.formVariablesAnalisisComercial.rbtnCiudad.Checked == false)
            {
                if (this.formVariablesAnalisisComercial.cbxVivienda.Text == "Arrendada")
                    ValorDANEVivienda = GastosDANE.RetornarDANEViviendaPueblo(true, Convert.ToDouble(this.formVariablesAnalisisComercial.tbxIngresos.Text));
                else if (this.formVariablesAnalisisComercial.cbxVivienda.Text == "Familiar")
                    ValorDANEVivienda = GastosDANE.RetornarDANEViviendaPueblo(false, Convert.ToDouble(this.formVariablesAnalisisComercial.tbxIngresos.Text));
                else
                    ValorDANEVivienda = 0;
            }
            return ValorDANEVivienda;
        }
        private double RetornarDANECiudadPueblo()
        {
            double ValorDANE;
            ValorDANE = GastosDANE.RetornarDANECiudadPueblo(this.formVariablesAnalisisComercial.rbtnCiudad.Checked, Convert.ToDouble(this.formVariablesAnalisisComercial.tbxIngresos.Text));
            return ValorDANE;
        }
        private void RetornarDisponible(object senderm, EventArgs args)
        {
            
            double disponible;
            try
            {
                if (this.formVariablesAnalisisComercial.tbxIngresos.Text != string.Empty &&
                   this.formVariablesAnalisisComercial.tbxDeduccionesColilla.Text != string.Empty &&
                   this.formVariablesAnalisisComercial.tbxCuotasCreditoCacelarNomina.Text != string.Empty &&
                   this.formVariablesAnalisisComercial.tbxDeduccionesDeSeguridadSocial.Text != string.Empty &&
                   this.formVariablesAnalisisComercial.tbxOtrasDeduccionesColilla.Text != string.Empty &&
                   this.formVariablesAnalisisComercial.tbxOtrosIngresos.Text != string.Empty &&
                   (this.formVariablesAnalisisComercial.rbtnCiudad.Checked == true || this.formVariablesAnalisisComercial.rbtnMunicipio.Checked == true) &&
                   this.formVariablesAnalisisComercial.cbxVivienda.Text != string.Empty &&
                   this.formVariablesAnalisisComercial.tbxCuotasACancelar.Text != string.Empty)

                {
                    CodigoComun.Alerta("Correcto", FormVentanaEmergente.enmTipo.exito);
                    disponible = Disponible.CalcularDisponibleCaja(Convert.ToDouble(this.formVariablesAnalisisComercial.tbxIngresos.Text),
                    Convert.ToDouble(this.formVariablesAnalisisComercial.tbxOtrosIngresos.Text), Convert.ToDouble(this.formVariablesAnalisisComercial.tbxDeduccionesColilla.Text),
                    RetornarDANECiudadPueblo(), RetornarDANEVivienda(), Convert.ToDouble(this.formVariablesAnalisisComercial.tbxCuotasACancelar.Text));
                    this.formVariablesAnalisisComercial.tbxDisponible.Text = disponible.ToString("N2");
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
            if (this.formVariablesAnalisisComercial.cbxCantidadDeMoras.Text != string.Empty && this.formVariablesAnalisisComercial.cbxDiasMora.Text != string.Empty)
                this.formVariablesAnalisisComercial.tbxComportamientoDePagos.Text = CodigoComun.RetornarMorasTotales(this.formVariablesAnalisisComercial.cbxCantidadDeMoras, this.formVariablesAnalisisComercial.cbxDiasMora);
        }
        private void RetornarEdad(object sender, EventArgs args)
        {
            this.formVariablesAnalisisComercial.contadorEdad.Value = CodigoComun.CalcularEdad(this.formVariablesAnalisisComercial.dtpEdad);
        }
        private void AbrirFormAnalisisCredito(object sender, EventArgs args)
        {
            if (this.formVariablesAnalisisComercial.tbxNombres.Text != string.Empty 
                && this.formVariablesAnalisisComercial.cbxPeriodicidad.Text != string.Empty && this.formVariablesAnalisisComercial.cbxGarantia.Text != string.Empty
                && this.formVariablesAnalisisComercial.cbxTipoDePersona.Text != string.Empty && this.formVariablesAnalisisComercial.tbxProfesion.Text != string.Empty
                && this.formVariablesAnalisisComercial.tbxCargo.Text != string.Empty && this.formVariablesAnalisisComercial.tbxOcupacion.Text != string.Empty
                && this.formVariablesAnalisisComercial.cbxEstadoCivil.Text != string.Empty && this.formVariablesAnalisisComercial.contadorEdad.Value != 0
                && this.formVariablesAnalisisComercial.cbxVivienda.Text != string.Empty
                && this.formVariablesAnalisisComercial.contadorEstrato.Value != 0 && (this.formVariablesAnalisisComercial.rbtnCiudad.Checked == true ||
                this.formVariablesAnalisisComercial.rbtnMunicipio.Checked == true) && this.formVariablesAnalisisComercial.cbxDestinoDelCredito.Text != string.Empty
                && this.formVariablesAnalisisComercial.tbxActividadEconomica.Text != string.Empty && this.formVariablesAnalisisComercial.cbxTipoDeContrato.Text != string.Empty
                && this.formVariablesAnalisisComercial.contadorAntLaboral.Value != 0 && this.formVariablesAnalisisComercial.tbxIngresos.Text != string.Empty
                && this.formVariablesAnalisisComercial.tbxOtrosIngresos.Text != string.Empty && this.formVariablesAnalisisComercial.tbxDeduccionesColilla.Text != string.Empty
                && this.formVariablesAnalisisComercial.tbxCuotaCentrales.Text != string.Empty && this.formVariablesAnalisisComercial.tbxCuotasACancelar.Text != string.Empty
                && this.formVariablesAnalisisComercial.tbxEstimacionTarjetasCredito.Text != string.Empty && this.formVariablesAnalisisComercial.tbxValorCuotaLibranza.Text != string.Empty
                && this.formVariablesAnalisisComercial.tbxCuotasCreditoCacelarNomina.Text != string.Empty && this.formVariablesAnalisisComercial.tbxEstimacionTarjetasCredito.Text != string.Empty
                && this.formVariablesAnalisisComercial.contadorScore.Value != 0
                && this.formVariablesAnalisisComercial.cbxCalificacion.Text != string.Empty && this.formVariablesAnalisisComercial.tbxEndeudamientoGlobal.Text != string.Empty)
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
        private void RetornarTotalDeducciones(object sender, EventArgs args)
        {
            try
            {
                if (this.formVariablesAnalisisComercial.tbxDeduccionesDeSeguridadSocial.Text != string.Empty && this.formVariablesAnalisisComercial.tbxOtrasDeduccionesColilla.Text != string.Empty)
                {

                    double totalDeduccionesColilla;
                    totalDeduccionesColilla = CodigoComun.RetornarTotalDeducciones(Convert.ToDouble(this.formVariablesAnalisisComercial.tbxDeduccionesDeSeguridadSocial.Text), Convert.ToDouble(this.formVariablesAnalisisComercial.tbxOtrasDeduccionesColilla.Text));
                    this.formVariablesAnalisisComercial.tbxDeduccionesColilla.Text = totalDeduccionesColilla.ToString("N2");
                }
            }
            catch
            {
                formError = new FormError("El Valor de las deducciones no debe ser cero o un valor inválido");
                formError.ShowDialog();
            }

        }
        private void AbrirFormCodeudor(object sender, EventArgs args)
        {
            using (formCodeudor = new FormCodeudor())
            {
                formCodeudor.tbxCuota.Text = this.formVariablesAnalisisComercial.tbxCuota.Text;
                formCodeudor.ShowDialog();
            }
        }
        private void CambiarScroll(object sender, EventArgs args)
        {
           if (((TextBox)sender).Name == this.formVariablesAnalisisComercial.tbxIngresos.Name) CodigoComun.SetScroll(this.formVariablesAnalisisComercial, 300);
           else if (((TextBox)sender).Name == this.formVariablesAnalisisComercial.tbxCuotaCentrales.Name) CodigoComun.SetScroll(this.formVariablesAnalisisComercial, 700);
           else if (((TextBox)sender).Name == this.formVariablesAnalisisComercial.tbxNombres.Name) CodigoComun.SetScroll(this.formVariablesAnalisisComercial, 0);
        }
    }
}

using Presentacion.CodigoCompartido;
using Presentacion.Ventanas.VentanaAnalisisDeCredito;
using Presentacion.Ventanas.VentanaAviso;
using Presentacion.Ventanas.VentanaCodeudor;
using Presentacion.Ventanas.VentanaEmergente;
using Presentacion.Ventanas.VentanaError;
using SoporteUsuario.CacheUsuario;
using System;
using System.Windows.Forms;



namespace Presentacion.FormsCarteras.Consumo.VarialblesAnalisis
{
    class ControladorFormVariablesAnalisisConsumo
    {
        private FormVariablesAnalisisConsumo formVariables;
        private FormAnalisisDeCredito formAnalisisDeCredito = new FormAnalisisDeCredito();
        private FormError formError;
        private FormAviso formAviso;
        private FormCodeudor formCodeudor;


        public ControladorFormVariablesAnalisisConsumo(FormVariablesAnalisisConsumo formVariables)
        {
            this.formVariables = formVariables;
            this.formVariables.Load += new EventHandler(CargarForm);
            EventosBotones();
            MensajesTooltip();
            ValidacionSoloNumerosTextBox();
        }
        private void EventosBotones()
        {
            this.formVariables.btnAnalizar.Click += new EventHandler(AbrirFormAnalisisCredito);
            this.formVariables.tbxIngresos.TextChanged += new EventHandler(RetornarTotalIngresos);
            this.formVariables.tbxOtrosIngresos.TextChanged += new EventHandler(RetornarTotalIngresos);
            this.formVariables.cbxDiasMora.TextChanged += new EventHandler(RetornarTotalMora);
            this.formVariables.cbxCantidadDeMoras.TextChanged += new EventHandler(RetornarTotalMora);
            this.formVariables.cbxDiasMora.Leave += new EventHandler(RetornarTotalMora);
            this.formVariables.cbxCantidadDeMoras.Leave += new EventHandler(RetornarTotalMora);
            this.formVariables.cbxFormaDePago.TextChanged += new EventHandler(RetornarTotalIngresos);
            this.formVariables.dtpEdad.ValueChanged += new EventHandler(RetornarEdad);
            this.formVariables.btnCalcularEndeudamientoGlobal.Click += new EventHandler(RetornarEndeudamientoGlobal);
            this.formVariables.btnAfectacionColilla.Click += new EventHandler(RetornarAfectacionColilla);
            this.formVariables.btnCalcularDisponible.Click += new EventHandler(RetornarDisponible);
            this.formVariables.tbxDeduccionesDeSeguridadSocial.TextChanged += new EventHandler(RetornarTotalDeducciones);
            this.formVariables.tbxOtrasDeduccionesColilla.TextChanged += new EventHandler(RetornarTotalDeducciones);
            this.formVariables.btnCodeudor.Click += new EventHandler(AbrirFormCodeudor);
            this.formVariables.tbxIngresos.Enter += new EventHandler(CambiarScroll);
            this.formVariables.tbxCuotaCentrales.Enter += new EventHandler(CambiarScroll);
            this.formVariables.tbxNombres.Enter += new EventHandler(CambiarScroll);
            this.formVariables.tbxIngresos.Click += new EventHandler(SeleccionarFinalDeTextoIngresos);
            this.formVariables.tbxOtrosIngresos.Click += new EventHandler(SeleccionarFinalDeTextoIngresos);
            this.formVariables.tbxDeduccionesDeSeguridadSocial.Click += new EventHandler(SeleccionarFinalDeTextoEgresos);
            this.formVariables.tbxOtrasDeduccionesColilla.Click += new EventHandler(SeleccionarFinalDeTextoEgresos);
            this.formVariables.tbxCuotasACancelar.Click += new EventHandler(SeleccionarFinalDeTextoEgresos);
            this.formVariables.tbxEstimacionTarjetasCredito.Click += new EventHandler(SeleccionarFinalDeTextoEgresos);
            this.formVariables.tbxCupoRotativo.Click += new EventHandler(SeleccionarFinalDeTextoEgresos);
            this.formVariables.tbxValorCuotaLibranza.Click += new EventHandler(SeleccionarFinalDeTextoEgresos);
            this.formVariables.tbxCuotasCreditoCacelarNomina.Click += new EventHandler(SeleccionarFinalDeTextoEgresos);
            this.formVariables.tbxCuotaCentrales.Click += new EventHandler(SeleccionarFinalDeTextoEgresos);
            RetornarFormatoTextBox();
            ValidacionSoloLetrasTextbox();
        }

        private void MensajesTooltip()
        {
            this.formVariables.ttMensajesFormConsumo.SetToolTip(this.formVariables.tbxNombres, "Ingrese los nombres del solicitante.");
            this.formVariables.ttMensajesFormConsumo.SetToolTip(this.formVariables.tbxApellidos, "Ingrese los apellidos del solicitante.");
            this.formVariables.ttMensajesFormConsumo.SetToolTip(this.formVariables.cbxPeriodicidad, "Ingrese la periodicidad de pago del crédito.");
            this.formVariables.ttMensajesFormConsumo.SetToolTip(this.formVariables.cbxGarantia, "Ingrese La garantía del crédito a analizar.");
            this.formVariables.ttMensajesFormConsumo.SetToolTip(this.formVariables.cbxFormaDePago, "Ingrese si el pago será por nómina o caja.");
            this.formVariables.ttMensajesFormConsumo.SetToolTip(this.formVariables.dtpEdad, "Ingrese la fecha de nacimiento del solicitante.");
            this.formVariables.ttMensajesFormConsumo.SetToolTip(this.formVariables.tbxProfesion, "Ingrese La profesión del solicitante.");
            this.formVariables.ttMensajesFormConsumo.SetToolTip(this.formVariables.tbxCargo, "Ingrese el cargo actual del solicitante.");
            this.formVariables.ttMensajesFormConsumo.SetToolTip(this.formVariables.tbxOcupacion, "Ingrese la ocupación actual del solicitante.");
            this.formVariables.ttMensajesFormConsumo.SetToolTip(this.formVariables.cbxEstadoCivil, "Ingrese el estado civil actual solicitante.");
            this.formVariables.ttMensajesFormConsumo.SetToolTip(this.formVariables.contadorEdad, "Ingrese la edad en años del solicitante.");
            this.formVariables.ttMensajesFormConsumo.SetToolTip(this.formVariables.contadorPersonasACargo, "Ingrese la cantidad de personas a cargo del solicitante.");
            this.formVariables.ttMensajesFormConsumo.SetToolTip(this.formVariables.cbxVivienda, "Ingrese el tipo de vivienda del solicitante.");
            this.formVariables.ttMensajesFormConsumo.SetToolTip(this.formVariables.contadorEstrato, "Ingrese el estrato económico del solicitante.");
            this.formVariables.ttMensajesFormConsumo.SetToolTip(this.formVariables.rbtnCiudad, "El solicitante vive actualmente en una zona urbana.");
            this.formVariables.ttMensajesFormConsumo.SetToolTip(this.formVariables.rbtnMunicipio, "El solicitante vive actualmente en una zona rural.");
            this.formVariables.ttMensajesFormConsumo.SetToolTip(this.formVariables.tbxIngresos, "ingresos mensuales actuales del solicitante.");
            this.formVariables.ttMensajesFormConsumo.SetToolTip(this.formVariables.tbxOtrosIngresos, "Otros ingresos mensuales actuales del solicitante.");
            this.formVariables.ttMensajesFormConsumo.SetToolTip(this.formVariables.tbxEmpresa, "Nombre de la empresa donde trabaja el solicitante.");
            this.formVariables.ttMensajesFormConsumo.SetToolTip(this.formVariables.tbxActividadEconomica, "Actividad económica de la emprea.");
            this.formVariables.ttMensajesFormConsumo.SetToolTip(this.formVariables.cbxTipoDeContrato, "Tipo de contrato laboral del solicitante.");
            this.formVariables.ttMensajesFormConsumo.SetToolTip(this.formVariables.contadorAntLaboral, "Antigüedad laboral en meses.");

            this.formVariables.ttMensajesFormConsumo.SetToolTip(this.formVariables.tbxDeduccionesColilla, "Total deducciones registradas en la colilla de pago.");
            this.formVariables.ttMensajesFormConsumo.SetToolTip(this.formVariables.tbxCuotaCentrales, "Total cuotas mensuales registradas en las centrales.");
            this.formVariables.ttMensajesFormConsumo.SetToolTip(this.formVariables.tbxCuotasACancelar, "Cuotas a cancelar mediante el crédito solicitado.");
            this.formVariables.ttMensajesFormConsumo.SetToolTip(this.formVariables.tbxCupoRotativo, "Estimación de la cuota del cupo rotativo.");
            this.formVariables.ttMensajesFormConsumo.SetToolTip(this.formVariables.tbxValorCuotaLibranza, "Valor a compensar de la cuota registrada en colilla.");
            this.formVariables.ttMensajesFormConsumo.SetToolTip(this.formVariables.tbxCuotasCreditoCacelarNomina, "Cuota del crédito a refinanciar por nómina.");
            this.formVariables.ttMensajesFormConsumo.SetToolTip(this.formVariables.tbxEstimacionTarjetasCredito, "Estimación de la cuota del cupo de la tarjeta de crédito.");
            this.formVariables.ttMensajesFormConsumo.SetToolTip(this.formVariables.tbxDeduccionesDeSeguridadSocial, "Valor de las deducciones asociadas a la seguridad social.");
            this.formVariables.ttMensajesFormConsumo.SetToolTip(this.formVariables.tbxOtrasDeduccionesColilla, "Otras deducciones asociadas a la colilla.");

            this.formVariables.ttMensajesFormConsumo.SetToolTip(this.formVariables.contadorScore, "Ingrese el score del solicitante.");
            this.formVariables.ttMensajesFormConsumo.SetToolTip(this.formVariables.cbxCalificacion, "Ingrese la calificación del solicitante.");
            this.formVariables.ttMensajesFormConsumo.SetToolTip(this.formVariables.btnAnalizar, "Analizar crédito según cumplimiento de políticas internas.");
            this.formVariables.ttMensajesFormConsumo.SetToolTip(this.formVariables.cbxCantidadDeMoras, "Ingrese el número mayor de moras que registra el solicitante.");
            this.formVariables.ttMensajesFormConsumo.SetToolTip(this.formVariables.cbxDiasMora, "Ingrese los días de mora que registra el solicitante.");

            this.formVariables.ttMensajesFormConsumo.SetToolTip(this.formVariables.btnAfectacionColilla, "Calcular la afectación colilla del solicitante.");
            this.formVariables.ttMensajesFormConsumo.SetToolTip(this.formVariables.btnCalcularEndeudamientoGlobal, "Calcular el endeudamiento global del solicitante.");
            this.formVariables.ttMensajesFormConsumo.SetToolTip(this.formVariables.btnCalcularDisponible, "Calcular el disponible del solicitante.");
            this.formVariables.ttMensajesFormConsumo.SetToolTip(this.formVariables.cbxLeyLibranza, "Selecciones si el cáculo del disponible será bajo la ley de libranza");

        }
        private void CargarForm(object sender, EventArgs args)
        {
            this.formVariables.tbxCedula.Text = Cache.Cedula;
            this.formVariables.tbxMonto.Text = Cache.Monto.ToString("N2");
            this.formVariables.tbxCuota.Text = Cache.Cuota.ToString("N2");
            this.formVariables.contadorPlazo.Value = Cache.Plazo;
            this.formVariables.contadorTasa.Value = Cache.Tasa;
            this.formVariables.tbxNombres.Focus();

        }
        private void RetornarFormatoTextBox()
        {
            this.formVariables.tbxIngresos.Leave += new EventHandler(FormatoNumeroTexBox);
            this.formVariables.tbxOtrosIngresos.Leave += new EventHandler(FormatoNumeroTexBox);
            this.formVariables.tbxDeduccionesColilla.Leave += new EventHandler(FormatoNumeroTexBox);
            this.formVariables.tbxCuotaCentrales.Leave += new EventHandler(FormatoNumeroTexBox);
            this.formVariables.tbxCuotasACancelar.Leave += new EventHandler(FormatoNumeroTexBox);
            this.formVariables.tbxCupoRotativo.Leave += new EventHandler(FormatoNumeroTexBox);
            this.formVariables.tbxValorCuotaLibranza.Leave += new EventHandler(FormatoNumeroTexBox);
            this.formVariables.tbxCuotasCreditoCacelarNomina.Leave += new EventHandler(FormatoNumeroTexBox);
            this.formVariables.tbxEstimacionTarjetasCredito.Leave += new EventHandler(FormatoNumeroTexBox);
            this.formVariables.tbxDeduccionesDeSeguridadSocial.Leave += new EventHandler(FormatoNumeroTexBox);
            this.formVariables.tbxOtrasDeduccionesColilla.Leave += new EventHandler(FormatoNumeroTexBox);

        }
        private void ValidacionSoloNumerosTextBox()
        {
            this.formVariables.tbxIngresos.KeyPress += new KeyPressEventHandler(CodigoComun.ValidarTextBoxNumero);
            this.formVariables.tbxOtrosIngresos.KeyPress += new KeyPressEventHandler(CodigoComun.ValidarTextBoxNumero);
            this.formVariables.tbxDeduccionesColilla.KeyPress += new KeyPressEventHandler(CodigoComun.ValidarTextBoxNumero);
            this.formVariables.tbxCuotaCentrales.KeyPress += new KeyPressEventHandler(CodigoComun.ValidarTextBoxNumero);
            this.formVariables.tbxCuotasACancelar.KeyPress += new KeyPressEventHandler(CodigoComun.ValidarTextBoxNumero);
            this.formVariables.tbxCupoRotativo.KeyPress += new KeyPressEventHandler(CodigoComun.ValidarTextBoxNumero);
            this.formVariables.tbxValorCuotaLibranza.KeyPress += new KeyPressEventHandler(CodigoComun.ValidarTextBoxNumero);
            this.formVariables.tbxCuotasCreditoCacelarNomina.KeyPress += new KeyPressEventHandler(CodigoComun.ValidarTextBoxNumero);
            this.formVariables.tbxEstimacionTarjetasCredito.KeyPress += new KeyPressEventHandler(CodigoComun.ValidarTextBoxNumero);
            this.formVariables.tbxDeduccionesDeSeguridadSocial.KeyPress += new KeyPressEventHandler(CodigoComun.ValidarTextBoxNumero);
            this.formVariables.tbxOtrasDeduccionesColilla.KeyPress += new KeyPressEventHandler(CodigoComun.ValidarTextBoxNumero);

        }
        private void ValidacionSoloLetrasTextbox()
        {
            this.formVariables.tbxNombres.KeyPress += new KeyPressEventHandler(CodigoComun.ValidarTextBoxLetras);
            this.formVariables.tbxApellidos.KeyPress += new KeyPressEventHandler(CodigoComun.ValidarTextBoxLetras);
            this.formVariables.tbxProfesion.KeyPress += new KeyPressEventHandler(CodigoComun.ValidarTextBoxLetras);
            this.formVariables.tbxCargo.KeyPress += new KeyPressEventHandler(CodigoComun.ValidarTextBoxLetras);
            this.formVariables.tbxOcupacion.KeyPress += new KeyPressEventHandler(CodigoComun.ValidarTextBoxLetras);
            this.formVariables.tbxEmpresa.KeyPress += new KeyPressEventHandler(CodigoComun.ValidarTextBoxLetras);
            this.formVariables.tbxActividadEconomica.KeyPress += new KeyPressEventHandler(CodigoComun.ValidarTextBoxLetras);
        }
        private void AbrirFormAnalisisCredito(object sender, EventArgs args)
        {
            if (this.formVariables.tbxNombres.Text != string.Empty && this.formVariables.tbxApellidos.Text != string.Empty
                && this.formVariables.cbxPeriodicidad.Text != string.Empty && this.formVariables.cbxGarantia.Text != string.Empty
                && this.formVariables.cbxFormaDePago.Text != string.Empty && this.formVariables.tbxProfesion.Text != string.Empty
                && this.formVariables.tbxCargo.Text != string.Empty && this.formVariables.tbxOcupacion.Text != string.Empty
                && this.formVariables.cbxEstadoCivil.Text != string.Empty && this.formVariables.contadorEdad.Value != 0
                && this.formVariables.cbxVivienda.Text != string.Empty
                && this.formVariables.contadorEstrato.Value != 0 && (this.formVariables.rbtnCiudad.Checked == true ||
                this.formVariables.rbtnMunicipio.Checked == true) && this.formVariables.tbxEmpresa.Text != string.Empty
                && this.formVariables.tbxActividadEconomica.Text != string.Empty && this.formVariables.cbxTipoDeContrato.Text != string.Empty
                && this.formVariables.contadorAntLaboral.Value != 0 && this.formVariables.tbxIngresos.Text != string.Empty
                && this.formVariables.tbxOtrosIngresos.Text != string.Empty && this.formVariables.tbxDeduccionesColilla.Text != string.Empty
                && this.formVariables.tbxCuotaCentrales.Text != string.Empty && this.formVariables.tbxCuotasACancelar.Text != string.Empty
                && this.formVariables.tbxEstimacionTarjetasCredito.Text != string.Empty && this.formVariables.tbxValorCuotaLibranza.Text != string.Empty
                && this.formVariables.tbxCuotasCreditoCacelarNomina.Text != string.Empty && this.formVariables.tbxEstimacionTarjetasCredito.Text != string.Empty
                && this.formVariables.tbxAfectacionColilla.Text != string.Empty && this.formVariables.contadorScore.Value != 0
                && this.formVariables.cbxCalificacion.Text != string.Empty && this.formVariables.tbxEndeudamientoGlobal.Text != string.Empty)
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
        private void GeneracionDatosCache()
        {

            Cache.FormaDePago = string.Empty;

            //forma de pago
            if (this.formVariables.cbxFormaDePago.Text == "Caja") Cache.FormaDePago = "Caja";
            else if (this.formVariables.cbxFormaDePago.Text == "Nomina") Cache.FormaDePago = "Nomina";

            //Garantia
            if (this.formVariables.cbxGarantia.Text == "Codeudor") Cache.Garantia = "Codeudor";
            else if (this.formVariables.cbxGarantia.Text == "Hipoteca") Cache.Garantia = "Hipoteca";
            else if (this.formVariables.cbxGarantia.Text == "Sin garantía") Cache.Garantia = "Sin garantía";

            if (this.formVariables.cbxPeriodicidad.Text == "Quincenal") Cache.Periodicidad = "Quincenal";
            else if (this.formVariables.cbxPeriodicidad.Text == "Mensual") Cache.Periodicidad = "Mensual";

            if (this.formVariables.cbxEstadoCivil.Text == "Soltero") Cache.EstadoCivil = "Soltero";
            else if (this.formVariables.cbxEstadoCivil.Text == "Casado") Cache.EstadoCivil = "Casado";
            else if (this.formVariables.cbxEstadoCivil.Text == "Union libre") Cache.EstadoCivil = "Union libre";
            else if (this.formVariables.cbxEstadoCivil.Text == "Viudo") Cache.EstadoCivil = "Viudo";

            if (this.formVariables.cbxVivienda.Text == "Arrendada") Cache.Vivienda = "Arrendada";
            else if (this.formVariables.cbxVivienda.Text == "Propia") Cache.Vivienda = "Propia";
            else if (this.formVariables.cbxVivienda.Text == "Familiar") Cache.Vivienda = "Familiar";

            if (this.formVariables.rbtnCiudad.Checked == true) Cache.CiudadMunicipio = "Zona urbana";
            else if (this.formVariables.rbtnMunicipio.Checked == true) Cache.CiudadMunicipio = "Zona rural";

            if (this.formVariables.cbxCalificacion.Text == "AAA") Cache.Calificacion = "AAA";
            else if (this.formVariables.cbxCalificacion.Text == "AA") Cache.Calificacion = "AA";
            else if (this.formVariables.cbxCalificacion.Text == "A") Cache.Calificacion = "A";
            else if (this.formVariables.cbxCalificacion.Text == "BBB") Cache.Calificacion = "BBB";
            else if (this.formVariables.cbxCalificacion.Text == "BB") Cache.Calificacion = "BB";
            else if (this.formVariables.cbxCalificacion.Text == "B") Cache.Calificacion = "B";
            else if (this.formVariables.cbxCalificacion.Text == "C") Cache.Calificacion = "C";
            else if (this.formVariables.cbxCalificacion.Text == "D") Cache.Calificacion = "D";
            else if (this.formVariables.cbxCalificacion.Text == "E") Cache.Calificacion = "E";

            if (this.formVariables.cbxLeyLibranza.Checked == true) Cache.AplicaLeyLibranza = "Aplica";
            else if (this.formVariables.cbxLeyLibranza.Checked == false) Cache.AplicaLeyLibranza = "No aplica";



            Cache.TotalIngresos = Convert.ToDouble(this.formVariables.tbxTotalIngresos.Text);
            Cache.Score = (double)this.formVariables.contadorScore.Value;
            Cache.AntLaboral = (double)this.formVariables.contadorAntLaboral.Value;
            Cache.TipoDeContrato = this.formVariables.cbxTipoDeContrato.Text;
            Cache.Edad = (int)this.formVariables.contadorEdad.Value;
            Cache.Nombre = this.formVariables.tbxNombres.Text;
            Cache.Apellido = this.formVariables.tbxApellidos.Text;
            Cache.FechaDeNaciento = (this.formVariables.dtpEdad.Value.Date).ToString();
            Cache.Profesion = this.formVariables.tbxProfesion.Text;
            Cache.Cargo = this.formVariables.tbxCargo.Text;
            Cache.Ocupacion = this.formVariables.tbxOcupacion.Text;
            Cache.PersonasAcargo = (int)this.formVariables.contadorPersonasACargo.Value;
            Cache.Estrato = (int)this.formVariables.contadorEstrato.Value;
            Cache.Empresa = this.formVariables.tbxEmpresa.Text;
            Cache.ActividadEconomica = this.formVariables.tbxActividadEconomica.Text;
            Cache.CuotasACancelar = Convert.ToDouble(this.formVariables.tbxCuotasACancelar.Text);
            Cache.EstimacionCupoRotativo = Convert.ToDouble(this.formVariables.tbxCupoRotativo.Text);
            Cache.CuotasDeCreditoACancelarPorNomina = Convert.ToDouble(this.formVariables.tbxCuotasCreditoCacelarNomina.Text);
            Cache.EstimacionTarjetasDeCredito = Convert.ToDouble(this.formVariables.tbxEstimacionTarjetasCredito.Text);
            Cache.NumeroDemoras = Convert.ToInt32(this.formVariables.cbxCantidadDeMoras.Text);
            Cache.DiasDeMora = Convert.ToInt32(this.formVariables.cbxDiasMora.Text);
            Cache.DeduccionesDeSeguridadSocial = Convert.ToDouble(this.formVariables.tbxDeduccionesDeSeguridadSocial.Text);
            Cache.DeduccionesColilla = Convert.ToDouble(this.formVariables.tbxDeduccionesColilla.Text);
            Cache.OtrasDeduccionesColilla = Convert.ToDouble(this.formVariables.tbxOtrasDeduccionesColilla.Text);
            Cache.ValorCuotaLibranza = Convert.ToDouble(this.formVariables.tbxValorCuotaLibranza.Text);
            Cache.IngresoBasico = Convert.ToDouble(this.formVariables.tbxIngresos.Text);
            Cache.OtrosIngresos = Convert.ToDouble(this.formVariables.tbxOtrosIngresos.Text);
            Cache.ComportamientoDePagos = this.formVariables.tbxComportamientoDePagos.Text;
            Cache.TipoDePersona = "Persona natural";
            Cache.CuotaCentrales = Convert.ToDouble(this.formVariables.tbxCuotaCentrales.Text);

        }
        private void RetornarTotalIngresos(Object sender, EventArgs args)
        {
            OcultarCheckBox();
            AdvertenciaCambioDeFormaDePago();
            try
            {
                if (this.formVariables.tbxIngresos.Text != string.Empty && this.formVariables.tbxOtrosIngresos.Text != string.Empty)
                {
                    double ingresos = Convert.ToDouble(this.formVariables.tbxIngresos.Text);
                    double otrosIngresos = Convert.ToDouble(this.formVariables.tbxOtrosIngresos.Text);

                    if (this.formVariables.cbxFormaDePago.Text == "Nomina")
                    {
                        double totalIngresos = CodigoComun.CalcularTotalIngresos(ingresos, otrosIngresos, 1);
                        this.formVariables.tbxTotalIngresos.Text = totalIngresos.ToString("N2");
                    }
                    else
                    {
                        double totalIngresos = CodigoComun.CalcularTotalIngresos(ingresos, otrosIngresos, 0.8);
                        this.formVariables.tbxTotalIngresos.Text = totalIngresos.ToString("N2");
                    }
                }
            }
            catch
            {
                formError = new FormError("El Valor de los ingresos no debe ser cero o un valor inválido");
                formError.ShowDialog();
            }
        }
        private void AdvertenciaCambioDeFormaDePago()
        {
            if ((this.formVariables.tbxAfectacionColilla.Text != string.Empty && this.formVariables.tbxAfectacionColilla.Text != "N/A") || this.formVariables.tbxEndeudamientoGlobal.Text != string.Empty
               || this.formVariables.tbxDisponible.Text != string.Empty)
            {
                formAviso = new FormAviso("Se debe recalcular los indicadores de capacidad de pago");
                this.formVariables.tbxEndeudamientoGlobal.Text = string.Empty;
                this.formVariables.tbxDisponible.Text = string.Empty;
                formAviso.ShowDialog();
            }
        }
        private void OcultarCheckBox()
        {
            if (this.formVariables.cbxFormaDePago.Text == "Caja")
            {
                this.formVariables.cbxLeyLibranza.Visible = false;
                this.formVariables.tbxAfectacionColilla.Text = "N/A";
                this.formVariables.btnAfectacionColilla.Enabled = false;

            }
            else if (this.formVariables.cbxFormaDePago.Text == "Nomina")

            {
                this.formVariables.cbxLeyLibranza.Visible = true;
                this.formVariables.tbxAfectacionColilla.Text = string.Empty;
                this.formVariables.btnAfectacionColilla.Enabled = true;
            }
        }
        private void FormatoNumeroTexBox(object sender, EventArgs args)
        {
            if (((TextBox)sender).Name == this.formVariables.tbxIngresos.Name && this.formVariables.tbxIngresos.Text != string.Empty)
                this.formVariables.tbxIngresos.Text = string.Format("{0:n0}", double.Parse(this.formVariables.tbxIngresos.Text));
            else if (((TextBox)sender).Name == this.formVariables.tbxOtrosIngresos.Name && this.formVariables.tbxOtrosIngresos.Text != string.Empty)
                this.formVariables.tbxOtrosIngresos.Text = string.Format("{0:n0}", double.Parse(this.formVariables.tbxOtrosIngresos.Text));
            else if (((TextBox)sender).Name == this.formVariables.tbxDeduccionesColilla.Name && this.formVariables.tbxDeduccionesColilla.Text != string.Empty)
                this.formVariables.tbxDeduccionesColilla.Text = string.Format("{0:n0}", double.Parse(this.formVariables.tbxDeduccionesColilla.Text));
            else if (((TextBox)sender).Name == this.formVariables.tbxCuotaCentrales.Name && this.formVariables.tbxCuotaCentrales.Text != string.Empty)
                this.formVariables.tbxCuotaCentrales.Text = string.Format("{0:n0}", double.Parse(this.formVariables.tbxCuotaCentrales.Text));
            else if (((TextBox)sender).Name == this.formVariables.tbxCupoRotativo.Name && this.formVariables.tbxCupoRotativo.Text != string.Empty)
                this.formVariables.tbxCupoRotativo.Text = string.Format("{0:n0}", double.Parse(this.formVariables.tbxCupoRotativo.Text));
            else if (((TextBox)sender).Name == this.formVariables.tbxCuotasACancelar.Name && this.formVariables.tbxCuotasACancelar.Text != string.Empty)
                this.formVariables.tbxCuotasACancelar.Text = string.Format("{0:n0}", double.Parse(this.formVariables.tbxCuotasACancelar.Text));
            else if (((TextBox)sender).Name == this.formVariables.tbxValorCuotaLibranza.Name && this.formVariables.tbxValorCuotaLibranza.Text != string.Empty)
                this.formVariables.tbxValorCuotaLibranza.Text = string.Format("{0:n0}", double.Parse(this.formVariables.tbxValorCuotaLibranza.Text));
            else if (((TextBox)sender).Name == this.formVariables.tbxCuotasCreditoCacelarNomina.Name && this.formVariables.tbxCuotasCreditoCacelarNomina.Text != string.Empty)
                this.formVariables.tbxCuotasCreditoCacelarNomina.Text = string.Format("{0:n0}", double.Parse(this.formVariables.tbxCuotasCreditoCacelarNomina.Text));
            else if (((TextBox)sender).Name == this.formVariables.tbxEstimacionTarjetasCredito.Name && this.formVariables.tbxEstimacionTarjetasCredito.Text != string.Empty)
                this.formVariables.tbxEstimacionTarjetasCredito.Text = string.Format("{0:n0}", double.Parse(this.formVariables.tbxEstimacionTarjetasCredito.Text));
            else if (((TextBox)sender).Name == this.formVariables.tbxDeduccionesDeSeguridadSocial.Name && this.formVariables.tbxDeduccionesDeSeguridadSocial.Text != string.Empty)
                this.formVariables.tbxDeduccionesDeSeguridadSocial.Text = string.Format("{0:n0}", double.Parse(this.formVariables.tbxDeduccionesDeSeguridadSocial.Text));
            else if (((TextBox)sender).Name == this.formVariables.tbxOtrasDeduccionesColilla.Name && this.formVariables.tbxOtrasDeduccionesColilla.Text != string.Empty)
                this.formVariables.tbxOtrasDeduccionesColilla.Text = string.Format("{0:n0}", double.Parse(this.formVariables.tbxOtrasDeduccionesColilla.Text));

        }
        private void RetornarEndeudamientoGlobal(object sender, EventArgs args)
        {
            try
            {
                if (this.formVariables.tbxDeduccionesColilla.Text != string.Empty &&
                    this.formVariables.tbxCuotaCentrales.Text != string.Empty &&
                    this.formVariables.tbxCuotasACancelar.Text != string.Empty &&
                    this.formVariables.tbxIngresos.Text != string.Empty &&
                    this.formVariables.cbxVivienda.Text != string.Empty &&
                    this.formVariables.cbxFormaDePago.Text != string.Empty &&
                    this.formVariables.tbxOtrosIngresos.Text != string.Empty
                    && (this.formVariables.rbtnCiudad.Checked == true || this.formVariables.rbtnMunicipio.Checked == true))
                {
                    CodigoComun.Alerta("Correcto", FormVentanaEmergente.enmTipo.exito);
                    CalcularEndeudamientoGlobal(this.formVariables.cbxFormaDePago.Text);
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
        private void CalcularEndeudamientoGlobal(string formaDePago)
        {
            double endeudamientoGlobal;

            if (formaDePago == "Nomina")
            {
                endeudamientoGlobal = EndeudamientoGlobal.CalcularEndeudamientoGlobalNomina(Convert.ToDouble(this.formVariables.tbxDeduccionesColilla.Text),
                    Convert.ToDouble(this.formVariables.tbxCuotaCentrales.Text), Convert.ToDouble(this.formVariables.tbxCuota.Text), Convert.ToDouble(this.formVariables.tbxCuotasCreditoCacelarNomina.Text),
                    Convert.ToDouble(this.formVariables.tbxIngresos.Text), Convert.ToDouble(this.formVariables.tbxOtrosIngresos.Text));
                this.formVariables.tbxEndeudamientoGlobal.Text = endeudamientoGlobal.ToString("0.00%");
                Cache.EndeudamientoGlobal = endeudamientoGlobal;
            }
            else if (formaDePago == "Caja")
            {
                endeudamientoGlobal = EndeudamientoGlobal.CalcularEndeudamientoGlobalCaja(Convert.ToDouble(this.formVariables.tbxDeduccionesColilla.Text),
                    Convert.ToDouble(this.formVariables.tbxCuotaCentrales.Text), Convert.ToDouble(this.formVariables.tbxCuota.Text), RetornarDANECiudadPueblo(),
                    RetornarDANEVivienda(), Convert.ToDouble(this.formVariables.tbxCuotasACancelar.Text),
                    Convert.ToDouble(this.formVariables.tbxIngresos.Text), Convert.ToDouble(this.formVariables.tbxOtrosIngresos.Text));
                this.formVariables.tbxEndeudamientoGlobal.Text = endeudamientoGlobal.ToString("0.00%");
                Cache.EndeudamientoGlobal = endeudamientoGlobal;
            }
        }
        private void RetornarDisponible(object senderm, EventArgs args)
        {
            double disponible;
            try
            {
                if (this.formVariables.tbxIngresos.Text != string.Empty &&
                   this.formVariables.tbxDeduccionesColilla.Text != string.Empty &&
                   this.formVariables.tbxCuotasCreditoCacelarNomina.Text != string.Empty &&
                   this.formVariables.tbxDeduccionesDeSeguridadSocial.Text != string.Empty &&
                   this.formVariables.tbxOtrasDeduccionesColilla.Text != string.Empty &&
                   this.formVariables.tbxOtrosIngresos.Text != string.Empty &&
                   (this.formVariables.rbtnCiudad.Checked == true || this.formVariables.rbtnMunicipio.Checked == true) &&
                   this.formVariables.cbxVivienda.Text != string.Empty &&
                   this.formVariables.tbxCuotasACancelar.Text != string.Empty && this.formVariables.cbxFormaDePago.Text != string.Empty)

                {
                    if (this.formVariables.cbxFormaDePago.Text == "Nomina")
                    {
                        CodigoComun.Alerta("Correcto", FormVentanaEmergente.enmTipo.exito);
                        if (this.formVariables.cbxLeyLibranza.Checked == false)
                        {
                            disponible = Disponible.CalcularDisponibleNominaSinLibranza(Convert.ToDouble(this.formVariables.tbxIngresos.Text),
                                 Convert.ToDouble(this.formVariables.tbxDeduccionesColilla.Text),
                                 Convert.ToDouble(this.formVariables.tbxCuotasCreditoCacelarNomina.Text));
                            this.formVariables.tbxDisponible.Text = disponible.ToString("N2");
                            Cache.Disponible = disponible;
                        }

                        else if (this.formVariables.cbxLeyLibranza.Checked == true)
                        {
                            disponible = Disponible.CalcularDisponibleNominaConLibranza(Convert.ToDouble(this.formVariables.tbxIngresos.Text),
                                Convert.ToDouble(this.formVariables.tbxDeduccionesDeSeguridadSocial.Text), Convert.ToDouble(this.formVariables.tbxOtrasDeduccionesColilla.Text),
                                Convert.ToDouble(this.formVariables.tbxCuotasCreditoCacelarNomina.Text));
                            this.formVariables.tbxDisponible.Text = disponible.ToString("N2");
                            Cache.Disponible = disponible;
                        }
                    }
                    else if (this.formVariables.cbxFormaDePago.Text == "Caja")
                    {
                        CodigoComun.Alerta("Correcto", FormVentanaEmergente.enmTipo.exito);
                        disponible = Disponible.CalcularDisponibleCaja(Convert.ToDouble(this.formVariables.tbxIngresos.Text),
                        Convert.ToDouble(this.formVariables.tbxOtrosIngresos.Text), Convert.ToDouble(this.formVariables.tbxDeduccionesColilla.Text),
                        RetornarDANECiudadPueblo(), RetornarDANEVivienda(), Convert.ToDouble(this.formVariables.tbxCuotasACancelar.Text));
                        this.formVariables.tbxDisponible.Text = disponible.ToString("N2");
                        Cache.Disponible = disponible;
                    }

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
        public void RetornarAfectacionColilla(object sender, EventArgs args)
        {
            double afectacionColilla;
            try
            {
                if (this.formVariables.tbxDeduccionesColilla.Text != string.Empty && this.formVariables.tbxCuotasCreditoCacelarNomina.Text != string.Empty
                    && this.formVariables.tbxIngresos.Text != string.Empty)
                {
                    CodigoComun.Alerta("Correcto", FormVentanaEmergente.enmTipo.exito);
                    afectacionColilla = AfectacionColilla.CalcularAfectacionColilla(Convert.ToDouble(this.formVariables.tbxDeduccionesColilla.Text),
                        Convert.ToDouble(this.formVariables.tbxCuota.Text), Convert.ToDouble(this.formVariables.tbxCuotasCreditoCacelarNomina.Text),
                        Convert.ToDouble(this.formVariables.tbxIngresos.Text));
                    this.formVariables.tbxAfectacionColilla.Text = afectacionColilla.ToString("0.00%");
                    Cache.AfectacionColilla = afectacionColilla;
                }
                else
                {
                    formError = new FormError("Datos insuficientes para calcular la afectacion colilla.");
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
            if (this.formVariables.cbxCantidadDeMoras.Text != string.Empty && this.formVariables.cbxDiasMora.Text != string.Empty)
                this.formVariables.tbxComportamientoDePagos.Text = CodigoComun.RetornarMorasTotales(this.formVariables.cbxCantidadDeMoras, this.formVariables.cbxDiasMora);
        }
        private void RetornarEdad(object sender, EventArgs args)
        {
            try
            {
                this.formVariables.contadorEdad.Value = CodigoComun.CalcularEdad(this.formVariables.dtpEdad);
            }
            catch 
            {

                using (formError = new FormError("Seleccione una fecha de nacimiendo válida, no puede ser superior a la fecha actual"))
                {
                    formError.ShowDialog();
                }
            }
           
        }
        private double RetornarDANECiudadPueblo()
        {
            double ValorDANE;
            ValorDANE = GastosDANE.RetornarDANECiudadPueblo(this.formVariables.rbtnCiudad.Checked, Convert.ToDouble(this.formVariables.tbxIngresos.Text));
            return ValorDANE;
        }
        private double RetornarDANEVivienda()
        {
            double ValorDANEVivienda = 0;

            if (this.formVariables.rbtnCiudad.Checked == true)
            {
                if (this.formVariables.cbxVivienda.Text == "Arrendada")
                    ValorDANEVivienda = GastosDANE.RetornarDANEViviendaCiudad(true, Convert.ToDouble(this.formVariables.tbxIngresos.Text));
                else if (this.formVariables.cbxVivienda.Text == "Familiar")
                    ValorDANEVivienda = GastosDANE.RetornarDANEViviendaCiudad(false, Convert.ToDouble(this.formVariables.tbxIngresos.Text));
                else
                    ValorDANEVivienda = 0;
            }
            else if (this.formVariables.rbtnCiudad.Checked == false)
            {
                if (this.formVariables.cbxVivienda.Text == "Arrendada")
                    ValorDANEVivienda = GastosDANE.RetornarDANEViviendaPueblo(true, Convert.ToDouble(this.formVariables.tbxIngresos.Text));
                else if (this.formVariables.cbxVivienda.Text == "Familiar")
                    ValorDANEVivienda = GastosDANE.RetornarDANEViviendaPueblo(false, Convert.ToDouble(this.formVariables.tbxIngresos.Text));
                else
                    ValorDANEVivienda = 0;
            }
            return ValorDANEVivienda;
        }
        private void RetornarTotalDeducciones(object sender, EventArgs args)
        {
            try
            {
                if (this.formVariables.tbxDeduccionesDeSeguridadSocial.Text != string.Empty && this.formVariables.tbxOtrasDeduccionesColilla.Text != string.Empty)
                {
                    
                    double totalDeduccionesColilla;
                    totalDeduccionesColilla = CodigoComun.RetornarTotalDeducciones(Convert.ToDouble(this.formVariables.tbxDeduccionesDeSeguridadSocial.Text), Convert.ToDouble(this.formVariables.tbxOtrasDeduccionesColilla.Text));
                    this.formVariables.tbxDeduccionesColilla.Text = totalDeduccionesColilla.ToString("N2");
                }
            }
            catch
            {
                formError = new FormError("El Valor de de las deducciones no debe ser cero o un valor inválido");
                formError.ShowDialog();
            }

        }
        private void AbrirFormCodeudor(object sender, EventArgs args)
        {
            using (formCodeudor = new FormCodeudor())
            {
                formCodeudor.cbxFormaDePago.Text = this.formVariables.cbxFormaDePago.Text;
                formCodeudor.tbxCuota.Text = this.formVariables.tbxCuota.Text;
                if(this.formVariables.cbxFormaDePago.Text  == "Caja")
                {
                    formCodeudor.tbxAfectacionColilla.Text = "N/A";
                    formCodeudor.tbxAfectacionColilla.Enabled = false;
                    formCodeudor.cbxLeyLibranza.Visible = false;
                }
                formCodeudor.ShowDialog();
            }
        }
        private void CambiarScroll(object sender, EventArgs args)
        {
            if (((TextBox)sender).Name == this.formVariables.tbxIngresos.Name) CodigoComun.SetScroll(this.formVariables, 300);
            else if (((TextBox)sender).Name == this.formVariables.tbxCuotaCentrales.Name) CodigoComun.SetScroll(this.formVariables, 700);
            else if (((TextBox)sender).Name == this.formVariables.tbxNombres.Name) CodigoComun.SetScroll(this.formVariables, 0);

            
        }
        private void SeleccionarFinalDeTextoIngresos(object sender, EventArgs args)
        {
            foreach (Control control in this.formVariables.pnlIngresos.Controls)
            {
                if (control is TextBox) { CodigoComun.TextoFinalTextbox((TextBox)control); }
            }
        }
        private void SeleccionarFinalDeTextoEgresos(object sender, EventArgs args)
        {
            foreach (Control control in this.formVariables.pnlEgresos.Controls)
            {
                if (control is TextBox) { CodigoComun.TextoFinalTextbox((TextBox)control); }
            }
        }

    }

}

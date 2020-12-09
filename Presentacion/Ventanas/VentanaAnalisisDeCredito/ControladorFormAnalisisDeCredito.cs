using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentacion.CodigoCompartido;
using Presentacion.FormsCarteras.Consumo.VarialblesAnalisis;
using Presentacion.Properties;
using Presentacion.Ventanas.VentanaConfirmacion;
using Presentacion.Ventanas.VentanaError;
using Presentacion.Ventanas.VentanaAviso; 
using SoporteUsuario.CacheUsuario;
using Presentacion.Ventanas.VentanaEmergente;

namespace Presentacion.Ventanas.VentanaAnalisisDeCredito
{
    class ControladorFormAnalisisDeCredito
    {
        private FormAnalisisDeCredito formAnalisisDeCredito;
        private StringBuilder mensajeDeAnalisis = new StringBuilder();
        private double salario = Settings.Default.salario;
        private FormConfirmacion formConfirmacion;
        private FormError formError;
        private FormAviso formAviso;

        public ControladorFormAnalisisDeCredito(FormAnalisisDeCredito formAnalisisDeCredito)
        {
            this.formAnalisisDeCredito = formAnalisisDeCredito;
            this.formAnalisisDeCredito.Load += new EventHandler(CargarForm);
            this.formAnalisisDeCredito.btnCerrar.Click += new EventHandler(CerrarForm);
            this.formAnalisisDeCredito.timerCargarForm.Tick += new EventHandler(EfectoLogin);
            this.formAnalisisDeCredito.btnAlmacenarInformacion.Click += new EventHandler(BotonAlmacenarInformacion);

        }
    
        private void CargarForm(object sender, EventArgs args)
        {
            this.formAnalisisDeCredito.Opacity = 0.0;
            ValidacionDeDatos();
            this.formAnalisisDeCredito.pnlSuperior.BackColor = Cache.ColorInicio;
            this.formAnalisisDeCredito.btnAlmacenarInformacion.BackColor = Cache.ColorInicio;
            this.formAnalisisDeCredito.btnCerrar.BackColor = Cache.ColorInicio;
            this.formAnalisisDeCredito.pnlLinea.BackColor = Cache.ColorInicio;
        
        }

        private void CerrarForm(object sender, EventArgs args) => CodigoComun.BtnCerrar(this.formAnalisisDeCredito);

        private void EfectoLogin(object sender, EventArgs args) => CodigoComun.Timer(this.formAnalisisDeCredito, this.formAnalisisDeCredito.timerCargarForm);
        private void ValidacionDeDatos()
        {
            if (Cache.TipoDeCredito == 1 && Cache.FormaDePago == "Nomina") ValidacionDatosConsumoNomina();
            else if (Cache.TipoDeCredito == 1 && Cache.FormaDePago == "Caja") ValidacionDatosConsumoCaja();
            else if (Cache.TipoDeCredito == 2) ValidacionDatosComercial();
            else if (Cache.TipoDeCredito == 3) ValidacionDatosVivienda();
            else if (Cache.TipoDeCredito == 4) ValidacionDatosMicro();
        }
        
        //TODO: Quitar lo de que si el score cumple igual sale un aviso, mejor dejar que si todo se cumple aparezca "No se viola políticas"
        private void ValidacionDatosConsumoNomina()
        {

            //validación de salario

            if ((Cache.TotalIngresos) < salario) mensajeDeAnalisis.AppendLine("La persona tiene ingresos menores a un salario minimo legal mensual vigente ");

            //Validacion Score
            if (Cache.Score < 400) mensajeDeAnalisis.AppendLine("La persona tiene un score menor a 400; Requiere codeudor");

            else mensajeDeAnalisis.AppendLine("La persona tiene un score mayor a 400; No requiere codeudor");

            //Validacion tipo de contrato y tiempo laborado

            if (Cache.TipoDeContrato == "Indefinido" && Cache.AntLaboral < 3) mensajeDeAnalisis.AppendLine("La persona debe tener más de 3 meses laborando bajo un contrato definido");

            else if (Cache.TipoDeContrato == "Fijo" && Cache.AntLaboral < 12) mensajeDeAnalisis.AppendLine("La persona debe tener más de 12 meses laborando bajo un contrato fijo");

            else if (Cache.TipoDeContrato == "Obra labor" && Cache.AntLaboral < 24) mensajeDeAnalisis.AppendLine("La persona debe tener más de 24 meses laborando bajo un contrato obra labor");

            //Validacion endeudamiento global

            if (Cache.EndeudamientoGlobal > 0.8) mensajeDeAnalisis.AppendLine("La persona no debe superar el 80% de su capacidad de pago");

            //Validacion colilla

            if (Cache.AfectacionColilla > 0.5) mensajeDeAnalisis.AppendLine("La persona no debe superar el 50% en el valor de la afectación colilla");

            //Validación Comportamiento de pagos

            if (Cache.NumeroDemoras >= 3 && Cache.DiasDeMora >= 30)
            {
                mensajeDeAnalisis.AppendLine("Las moras actuales superan el máximo de 3 moras de 30 días");
            }
            else if (Cache.NumeroDemoras >= 1 && Cache.DiasDeMora >= 60)
            {
                mensajeDeAnalisis.AppendLine("Las moras actuales superan el máximo de 1 mora de 60 días");
            }

            //Validacion Edad

            if (Cache.Edad < 18) mensajeDeAnalisis.AppendLine("La persona debe ser mayor de 18 años para poder acceder al crédito");
            else if (Cache.Edad > 80) mensajeDeAnalisis.AppendLine("La persona superar por " + (Cache.Edad - 80) + " años la edad máxima permitida por políticas");

            //Validación Monto

            if (Convert.ToDouble(Cache.Monto) < salario) mensajeDeAnalisis.AppendLine("El monto del crédito debe ser superior a un salario mímimo legal");


            //Validacion Garantía

            if (Convert.ToDouble(Cache.Monto) < (salario * 10) && Cache.Garantia != "Sin garantía")
            {
                mensajeDeAnalisis.AppendLine("La persona no necesita garantía para este monto");
            }
            else if (Convert.ToDouble(Cache.Monto) >= (salario * 10) && Convert.ToDouble(Cache.Monto) < (salario * 40) && Cache.Garantia != "Codeudor")
            {
                mensajeDeAnalisis.AppendLine("La persona necesita codeudor para este monto");
            }
            else if (Convert.ToDouble(Cache.Monto) >= (salario * 40) && Cache.Garantia != "Hipoteca")
            {
                mensajeDeAnalisis.AppendLine("La persona necesita garantía hipotecaria para este monto");
            }

            //Validacion Plazos

            if (Cache.Plazo > 36 && Convert.ToDouble(Cache.Monto) < (4 * salario))
            {
                mensajeDeAnalisis.AppendLine("El monto solicitado excede el plazo máximo permitido (36 meses)");
            }

            if (Cache.Plazo > 60 && Convert.ToDouble(Cache.Monto) >= (4 * salario) && Convert.ToDouble(Cache.Monto) < (12 * salario))
            {
                mensajeDeAnalisis.AppendLine("El monto solicitado excede el plazo máximo permitido (60 meses)");
            }

            if (Cache.Plazo > 72 && Cache.Monto >= (13 * salario))
            {
                mensajeDeAnalisis.AppendLine("El monto solicitado excede el plazo máximo permitido (72 meses)");
            }

       

            this.formAnalisisDeCredito.lblMensaje.Text = mensajeDeAnalisis.ToString();
        }
        private void ValidacionDatosConsumoCaja()
        {

            //validación de salario

            if ((Cache.TotalIngresos) < salario) mensajeDeAnalisis.AppendLine("La persona tiene ingresos menores a un salario minimo legal mensual vigente ");

            //Validacion Score
            if (Cache.Score < 600) mensajeDeAnalisis.AppendLine("La persona tiene un score menor a 600; Requiere codeudor");

            else mensajeDeAnalisis.AppendLine("La persona tiene un score mayor a 600; No requiere codeudor");

            //Validacion tipo de contrato y tiempo laborado

            if (Cache.TipoDeContrato == "Indefinido" && Cache.AntLaboral < 6) mensajeDeAnalisis.AppendLine("La persona debe tener más de 6 meses laborando bajo un contrato definido");

            else if (Cache.TipoDeContrato == "Fijo" && Cache.AntLaboral < 12) mensajeDeAnalisis.AppendLine("La persona debe tener más de 12 meses laborando bajo un contrato fijo");

            else if (Cache.TipoDeContrato == "Obra labor" && Cache.AntLaboral < 24) mensajeDeAnalisis.AppendLine("La persona debe tener más de 24 meses laborando bajo un contrato obra labor");

            //Validacion endeudamiento global

            if (Cache.EndeudamientoGlobal > 1) mensajeDeAnalisis.AppendLine("La persona no debe superar el 100% de su capacidad de pago");

            //Comportamiento de pagos

            if (Cache.NumeroDemoras >= 2 && Cache.DiasDeMora >= 30)
            {
                mensajeDeAnalisis.AppendLine("Las moras actuales superan el máximo de 2 moras de 30 días");
            }
            this.formAnalisisDeCredito.lblMensaje.Text = mensajeDeAnalisis.ToString();

            //Validacion Edad

            if (Cache.Edad < 18) mensajeDeAnalisis.AppendLine("La persona debe ser mayor de 18 años para poder acceder al crédito");
            else if (Cache.Edad > 75) mensajeDeAnalisis.AppendLine("La persona superar por " + (Cache.Edad - 75) + " años la edad máxima permitida por políticas");

            //Validación Monto

            if (Convert.ToDouble(Cache.Monto) < salario) mensajeDeAnalisis.AppendLine("El monto del crédito debe ser superior a un salario mímimo legal");


            //Validacion Garantía

            if (Convert.ToDouble(Cache.Monto) < (salario * 5) && Cache.Garantia != "Sin garantía")
            {
                mensajeDeAnalisis.AppendLine("La persona no necesita garantía para este monto");
            }
            else if (Convert.ToDouble(Cache.Monto) >= (salario * 5) && Convert.ToDouble(Cache.Monto) < (salario * 30) && Cache.Garantia != "Codeudor")
            {
                mensajeDeAnalisis.AppendLine("La persona necesita codeudor para este monto");
            }
            else if (Convert.ToDouble(Cache.Monto) >= (salario * 30) && Cache.Garantia != "Hipoteca")
            {
                mensajeDeAnalisis.AppendLine("La persona necesita garantía hipotecaria para este monto");
            }

            //Validacion Plazos

            if (Cache.Plazo > 18 && Convert.ToDouble(Cache.Monto) < (3 * salario))
            {
                mensajeDeAnalisis.AppendLine("El monto solicitado excede el plazo máximo permitido de 36 meses");
            }

            if (Cache.Plazo > 48 && Convert.ToDouble(Cache.Monto) >= (3 * salario) && Convert.ToDouble(Cache.Monto) < (10 * salario))
            {
                mensajeDeAnalisis.AppendLine("El monto solicitado excede el plazo máximo permitido (60 meses)");
            }

            if (Cache.Plazo > 60 && Convert.ToDouble(Cache.Monto) >= (11 * salario))
            {
                mensajeDeAnalisis.AppendLine("El monto solicitado excede el plazo máximo permitido (72 meses)");
            }

            this.formAnalisisDeCredito.lblMensaje.Text = mensajeDeAnalisis.ToString();
        }
        private void ValidacionDatosComercial()
        {

            //validación de salario

            if ((Cache.TotalIngresos) < 2 * salario) mensajeDeAnalisis.AppendLine("La persona tiene ingresos menores a dos salario minimo legal mensual vigente ");

            //Validacion Score
            if (Cache.Score < 700) mensajeDeAnalisis.AppendLine("La persona tiene un score menor a 700; Requiere codeudor");

            else mensajeDeAnalisis.AppendLine("La persona tiene un score mayor a 700; No requiere codeudor");

            //Validacion tipo de contrato y tiempo laborado

            if (Cache.TipoDeContrato == "Indefinido" && Cache.TipoDePersona == "Persona natural" && Cache.AntLaboral < 12) mensajeDeAnalisis.AppendLine("La persona debe tener más de 12 meses laborando bajo un contrato definido");

            else if (Cache.TipoDeContrato == "Fijo" && Cache.TipoDePersona == "Persona natural" && Cache.AntLaboral < 36) mensajeDeAnalisis.AppendLine("La persona debe tener más de 36 meses laborando bajo un contrato fijo");
            
            else if(Cache.TipoDePersona == "Persona jurídica" && Cache.Edad < 24) mensajeDeAnalisis.AppendLine("La empresa debe tener más de 24 meses constituida legalmente");

            //Validacion endeudamiento global

            if (Cache.EndeudamientoGlobal > 1) mensajeDeAnalisis.AppendLine("La persona no debe superar el 100% de su capacidad de pago");

            //Comportamiento de pagos

            if (Cache.NumeroDemoras >= 2 && Cache.DiasDeMora >= 30)
            {
                mensajeDeAnalisis.AppendLine("Las moras actuales superan el máximo de 2 moras de 30 días");
            }
            this.formAnalisisDeCredito.lblMensaje.Text = mensajeDeAnalisis.ToString();

            //Validacion Edad

            if (Cache.Edad < 24 && Cache.TipoDePersona == "Persona natural") mensajeDeAnalisis.AppendLine("La persona debe ser mayor de 24 años para poder acceder al crédito");
            else if (Cache.Edad > 75 && Cache.TipoDePersona == "Persona natural") mensajeDeAnalisis.AppendLine("La persona superar por " + (Cache.Edad - 75) + " años la edad máxima permitida por políticas");

            //Validación Monto

            if (Convert.ToDouble(Cache.Monto) < 2 * salario) mensajeDeAnalisis.AppendLine("El monto del crédito debe ser superior a dos salario mímimos legales");


            //Validacion Garantía

            if (Convert.ToDouble(Cache.Monto) < (salario * 15) && Cache.Garantia != "Sin garantía")
            {
                mensajeDeAnalisis.AppendLine("La persona no necesita garantía para este monto");
            }
            else if (Convert.ToDouble(Cache.Monto) >= (salario * 15) && Convert.ToDouble(Cache.Monto) < (salario * 60) && Cache.Garantia != "Codeudor")
            {
                mensajeDeAnalisis.AppendLine("La persona necesita codeudor para este monto");
            }
            else if (Convert.ToDouble(Cache.Monto) >= (salario * 60) && Cache.Garantia != "Hipoteca")
            {
                mensajeDeAnalisis.AppendLine("La persona necesita garantía hipotecaria para este monto");
            }

            //Validacion Plazos

            if (Cache.Plazo > 24 && Cache.DestinoDelCredito == "Capital de trabajo")
            {
                mensajeDeAnalisis.AppendLine("El plazo solicitado excede lo permitido por la política en créditos destinados a capital de trabajo");
            }
            else if (Cache.Plazo > 60 && (Cache.DestinoDelCredito == "Compra de activos" || Cache.DestinoDelCredito == "Unificacion de pasivos"))
            {
                mensajeDeAnalisis.AppendLine("El plazo solicitado excede lo permitido por la política en créditos destinados a compra de activos o unificación de pasivos");
            }


            this.formAnalisisDeCredito.lblMensaje.Text = mensajeDeAnalisis.ToString();

        }
        private void ValidacionDatosVivienda()
        {

            //validación de salario

            if ((Cache.TotalIngresos) < 2 * salario) mensajeDeAnalisis.AppendLine("La persona tiene ingresos menores a  dos salario minimo legal mensual vigente ");

            //Validacion Score
            if (Cache.Score < 500) mensajeDeAnalisis.AppendLine("La persona tiene un score menor a 500; Requiere codeudor");

            else mensajeDeAnalisis.AppendLine("La persona tiene un score mayor a 500; No requiere codeudor");

            //Validacion tipo de contrato y tiempo laborado

            if (Cache.TipoDeContrato == "Indefinido" && Cache.AntLaboral < 12) mensajeDeAnalisis.AppendLine("La persona debe tener más de 12 meses laborando bajo un contrato definido");

            else if (Cache.TipoDeContrato == "Fijo" && Cache.AntLaboral < 24) mensajeDeAnalisis.AppendLine("La persona debe tener más de 24 meses laborando bajo un contrato fijo");

            else if (Cache.TipoDeContrato == "Obra labor" && Cache.AntLaboral < 24) mensajeDeAnalisis.AppendLine("La persona debe tener más de 24 meses laborando bajo un contrato obra labor");

            //Validacion endeudamiento global

            if (Cache.EndeudamientoGlobal > 1) mensajeDeAnalisis.AppendLine("La persona no debe superar el 100% de su capacidad de pago");

            // Validación de cuota

            if (Cache.Cuota > (Cache.TotalIngresos * 0.30)) mensajeDeAnalisis.AppendLine("El valor de la cuota supera el 30% del total de ingresos de la persona");

            //Comportamiento de pagos


            if (Cache.NumeroDemoras >= 2 && Cache.DiasDeMora >= 30)
            {
                mensajeDeAnalisis.AppendLine("Las moras actuales superan el máximo de 2 moras de 30 días");
            }
            this.formAnalisisDeCredito.lblMensaje.Text = mensajeDeAnalisis.ToString();

            //Validacion Edad

            if (Cache.Edad < 24) mensajeDeAnalisis.AppendLine("La persona debe ser mayor de 24 años para poder acceder al crédito");
            else if (Cache.Edad > 75) mensajeDeAnalisis.AppendLine("La persona superar por " + (Cache.Edad - 75) + " años la edad máxima permitida por políticas");


            //Validación Monto

            if (Convert.ToDouble(Cache.Monto) < 5 * salario) mensajeDeAnalisis.AppendLine("El monto del crédito debe ser superior a cinco salarios mímimos legales");

            //Validacion Garantía

            if (Cache.Garantia != "Hipoteca")
            {
                mensajeDeAnalisis.AppendLine("La persona necesita garantía hipotecaria para este tipo crédito");
            }

            //Validacion Plazos

            if (Cache.Plazo > 72 && Cache.TipoDeCreditoVivienda == "Mejora de vivienda")
            {
                mensajeDeAnalisis.AppendLine("El plazo solicitado excede lo permitido por la política en créditos destinados a mejoras de vivienda");
            }
            else if (Cache.Plazo > 180 && (Cache.DestinoDelCredito == "Compra de vivienda nueva" || Cache.DestinoDelCredito == "Compra de vivienda usada"))
            {
                mensajeDeAnalisis.AppendLine("El plazo solicitado excede lo permitido por la política en créditos destinados a compra de vivienda nueva o compra de vivienda usada");
            }


            this.formAnalisisDeCredito.lblMensaje.Text = mensajeDeAnalisis.ToString();

        }
        private void ValidacionDatosMicro()
        {

            //validación de salario

            if ((Cache.TotalIngresos) < 1 * salario) mensajeDeAnalisis.AppendLine("La persona tiene ingresos menores a un salario minimo legal mensual vigente ");

            //Validacion Score
            if (Cache.Score < 700) mensajeDeAnalisis.AppendLine("La persona tiene un score menor a 700; Requiere codeudor");

            else mensajeDeAnalisis.AppendLine("La persona tiene un score mayor a 700; No requiere codeudor");

            //Validacion Ant.Laboral

            if (Cache.TiempoUnidadProductiva < 24) mensajeDeAnalisis.AppendLine("La unidad productiva debe tener al menos 24 meses de constitución");

            //Comportamiento de pagos

            if (Cache.NumeroDemoras >= 2 && Cache.DiasDeMora >= 30)
            {
                mensajeDeAnalisis.AppendLine("Las moras actuales superan el máximo de 2 moras de 30 días");
            }
            this.formAnalisisDeCredito.lblMensaje.Text = mensajeDeAnalisis.ToString();

            //Validacion Edad

            if (Cache.Edad < 24) mensajeDeAnalisis.AppendLine("La persona debe ser mayor de 24 años para poder acceder al crédito");
            else if (Cache.Edad > 65) mensajeDeAnalisis.AppendLine("La persona superar por " + (Cache.Edad - 65) + " años la edad máxima permitida por políticas");


            //Validación Monto

            if (Convert.ToDouble(Cache.Monto) < 1 * salario) mensajeDeAnalisis.AppendLine("El monto del crédito debe ser superior a un salario mímimo legal");

            //Validacion Garantía

            if (Convert.ToDouble(Cache.Monto) < (salario * 4) && Cache.Garantia != "Sin garantía")
            {
                mensajeDeAnalisis.AppendLine("La persona no necesita garantía para este monto");
            }
            else if (Convert.ToDouble(Cache.Monto) >= (salario * 4) && Convert.ToDouble(Cache.Monto) < (salario * 26) && Cache.Garantia != "Codeudor")
            {
                mensajeDeAnalisis.AppendLine("La persona necesita codeudor para este monto");
            }
            else if (Convert.ToDouble(Cache.Monto) >= (salario * 26) && Cache.Garantia != "Hipoteca")
            {
                mensajeDeAnalisis.AppendLine("La persona necesita garantía hipotecaria para este monto");
            }


            //Validacion Plazos

            if (Cache.Plazo > 12 && Cache.DestinoDelCredito == "Capital de trabajo")
            {
                mensajeDeAnalisis.AppendLine("El plazo solicitado excede lo permitido por la política en créditos destinados a capital de trabajo");
            }
            else if (Cache.Plazo > 36 && (Cache.DestinoDelCredito == "Compra de activos" || Cache.DestinoDelCredito == "Unificacion de pasivos"))
            {
                mensajeDeAnalisis.AppendLine("El plazo solicitado excede lo permitido por la política en créditos destinados a compra de activos o unificación de pasivos");
            }


            this.formAnalisisDeCredito.lblMensaje.Text = mensajeDeAnalisis.ToString();

        }
        

        private void BotonAlmacenarInformacion(object sender, EventArgs args)
        {
            if (this.formAnalisisDeCredito.tbxCriterioDelAnalista.Text != string.Empty)
            {
                formConfirmacion = new FormConfirmacion("¿Desea almacenar la ifnformación del crédito simualdo?");
                DialogResult resultado = formConfirmacion.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    CodigoComun.Alerta("Correcto", FormVentanaEmergente.enmTipo.exito);
                    Cache.CumplimientoDePoliticias = this.formAnalisisDeCredito.lblMensaje.Text;
                    Cache.CriterioDelAnalista = this.formAnalisisDeCredito.tbxCriterioDelAnalista.Text;
                    formAviso = new FormAviso("Información guardada correctamente y lista para ser exportada");
                    formAviso.ShowDialog();
                    this.formAnalisisDeCredito.Close();
                }
            }
            else
            {
                formError = new FormError("El criterio del analista es necesario para almacenar la información");
                formError.ShowDialog();
            }
        }
    }
}

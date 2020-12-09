using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presentacion.FormsCarteras.Comercial;
using Presentacion.FormsCarteras.Consumo.VarialblesAnalisis;
using Presentacion.CodigoCompartido;
using Presentacion.Ventanas.VentanaError;
using SoporteUsuario.CacheUsuario;
using Presentacion.Ventanas.VentanaConfirmacion;
using System.Windows.Forms;
using System.Threading;
using Presentacion.FormsCarteras.Comercial.VariablesAnalisisComercial;
using Presentacion.FormsCarteras.Vivienda.VariablesAnalisisVivienda;
using Presentacion.FormsCarteras.Micro.VariablesAnalisisMicro;
using Presentacion.Ventanas.VentanaEmergente;
using Presentacion.Ventanas.Calculadora;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.IO;
using System.Reflection;

namespace Presentacion.FormsCarteras.Consumo
{
    class ControladorFormConsumo
    {
        private FormConsumo formConsumo;
        private FormVariablesAnalisisConsumo formVariablesAnalisis = new FormVariablesAnalisisConsumo();
        private FormVariablesAnalisisComercial formVariablesAnalisisComercial = new FormVariablesAnalisisComercial();
        private FormVariablesAnalisisVivienda formVariablesAnalisisVivienda = new FormVariablesAnalisisVivienda();
        private FormVarialblesAnalisisMicro formVariablesAnalisisMicro = new FormVarialblesAnalisisMicro();
        private double Cuota;
        private FormError formError;
        private FormConfirmacion formConfirmacion;
        private CodigoComun codigoComun = new CodigoComun();
        private ExportarExcel exportarExcel = new ExportarExcel();
        private FormCalculadora formCalculadora;

        private bool validacionFormActivo = false;
        public ControladorFormConsumo(FormConsumo formConsumo)
        {
            this.formConsumo = formConsumo;
            this.formConsumo.btnAnalisis.Click += new EventHandler(AbrirFormAnalisis);
            this.formConsumo.Load += new EventHandler(CargarForm); this.formConsumo.tbxMonto.TextChanged += new EventHandler(CalcularCuota);
            this.formConsumo.contadorPlazo.ValueChanged += new EventHandler(CalcularCuota);
            this.formConsumo.contadorPlazo.Enter += new EventHandler(CalcularCuota);
            this.formConsumo.contadorPlazo.Leave += new EventHandler(CalcularCuota);
            this.formConsumo.contadorTasa.ValueChanged += new EventHandler(CalcularCuota);
            this.formConsumo.btnPlanCuotas.Click += new EventHandler(PlanDeCuotas);
            this.formConsumo.btnExportarExcel.Click += new EventHandler(ExportarArchivoExcel);
            this.formConsumo.tbxMonto.Leave += new EventHandler(FormatoNumeroTexBox);
            this.formConsumo.btnExportar.Click += new EventHandler(BotonExportar);
            this.formConsumo.btnCalculadora.Click += new EventHandler(AbrirCalculadora);
            this.formConsumo.KeyDown += new KeyEventHandler(AbrirCalculadoraShortCut);
           
            ValidacionSoloNumerosTextBox();
            MensajesToolTip();
            PanelExportarDiseno();
        }

        private void CargarForm(object sender, EventArgs args)
        {
             CodigoComun.EstiloDataGrid(this.formConsumo.dgvPlanPagoComercial);
            this.formConsumo.pnlCambioDeColor.BackColor = Cache.ColorInicio;
            this.formConsumo.tbxCedula.Focus();
        }
        private void MensajesToolTip()
        {
            this.formConsumo.ttFormConsumo.SetToolTip(this.formConsumo.tbxCedula, "Ingrese la cédula sin puntos ni comas.");
            this.formConsumo.ttFormConsumo.SetToolTip(this.formConsumo.tbxMonto, "Ingrese el monto del crédito en pesos; sin puntos ni comas.");
            this.formConsumo.ttFormConsumo.SetToolTip(this.formConsumo.contadorPlazo, "Ingrese la cantidad de meses del plazo del crédito.");
            this.formConsumo.ttFormConsumo.SetToolTip(this.formConsumo.contadorTasa, "Ingrese la tasa mes vencida del crédito.");
            this.formConsumo.ttFormConsumo.SetToolTip(this.formConsumo.btnPlanCuotas, "Generar pla de cuotas luego de diligenciar todas las variables básicas del crédito.");
            this.formConsumo.ttFormConsumo.SetToolTip(this.formConsumo.dgvPlanPagoComercial, "Plan de pago.");
            this.formConsumo.ttFormConsumo.SetToolTip(this.formConsumo.btnAnalisis, "Analizar crédito luego de tener las variables básicas. Alt + A");
            this.formConsumo.ttFormConsumo.SetToolTip(this.formConsumo.btnExportar, "Exportar la información del crédito.");
            this.formConsumo.ttFormConsumo.SetToolTip(this.formConsumo.btnExportarExcel, "Exportar la información del crédito a un archivo de excel. Alt + E");
            this.formConsumo.ttFormConsumo.SetToolTip(this.formConsumo.btnExportarPDF, "Exportar la información del crédito a un archivo PDF.");
            this.formConsumo.ttFormConsumo.SetToolTip(this.formConsumo.btnCalculadora, "Abrir calculadora Alt + S");

        }
        private void ValidacionSoloNumerosTextBox()
        {
            this.formConsumo.tbxMonto.KeyPress += new KeyPressEventHandler(CodigoComun.ValidarTextBoxNumero);
            this.formConsumo.tbxCedula.KeyPress += new KeyPressEventHandler(CodigoComun.ValidarTextBoxNumero);
        }
        private void AbrirFormAnalisis(object sender, EventArgs args)
        {
            if (this.formConsumo.tbxCedula.Text != string.Empty && this.formConsumo.tbxMonto.Text != string.Empty &&
                this.formConsumo.tbxCuota.Text != string.Empty && this.formConsumo.contadorPlazo.Value != 0
                && this.formConsumo.contadorTasa.Value != 0 && this.formConsumo.dgvPlanPagoComercial.Rows.Count > 0)
            {

                if (codigoComun.ActiveForm == null && validacionFormActivo != true)
                {
                    CodigoComun.Alerta("Correcto", FormVentanaEmergente.enmTipo.exito);
                    OcultarFormPlanDeCuotas(false);
                    this.formConsumo.trancisionFormAnalisis.Show(this.formConsumo.pnlCentro);
                    ValidarTipoDeForm();
                    validacionFormActivo = true;

                }

            }
            else
            {
                formError = new FormError("Ingrese el valor de todas las variables de entrada iniciales para el para el análisis del crédito");
                formError.ShowDialog();
            }

        }
        private void OcultarFormPlanDeCuotas(bool visibilidad)
        {
            this.formConsumo.pnlPrincipal.Visible = visibilidad;
            this.formConsumo.pnlCentro.Visible = visibilidad;
            this.formConsumo.dgvPlanPagoComercial.Visible = visibilidad;

        }
        private void ValidarTipoDeForm()
        {
            if (Cache.TipoDeCredito == 1) codigoComun.AbrirFormHijo(formVariablesAnalisis, this.formConsumo.pnlCentro);
            else if (Cache.TipoDeCredito == 2) codigoComun.AbrirFormHijo(formVariablesAnalisisComercial, this.formConsumo.pnlCentro);
            else if (Cache.TipoDeCredito == 3) codigoComun.AbrirFormHijo(formVariablesAnalisisVivienda, this.formConsumo.pnlCentro);
            else if (Cache.TipoDeCredito == 4) codigoComun.AbrirFormHijo(formVariablesAnalisisMicro, this.formConsumo.pnlCentro);

        }
        private void CalcularCuota(object sender, EventArgs args)
        {
            try
            {
                if (this.formConsumo.tbxMonto.Text != string.Empty)
                {
                    this.Cuota = CodigoComun.CalcularCuota(Convert.ToDouble(this.formConsumo.tbxMonto.Text), Convert.ToDouble(this.formConsumo.contadorTasa.Value), Convert.ToInt32(this.formConsumo.contadorPlazo.Value));
                    this.formConsumo.tbxCuota.Text = this.Cuota.ToString("N2");
                }
            }
            catch
            {
                using (formError = new FormError("Error en el formato numérico de las variables de entrada"))
                {

                    formError.ShowDialog();
                    this.formConsumo.tbxMonto.Text = string.Empty;
                }
            }


        }
        private void PlanDeCuotas(object sender, EventArgs args)
        {
            if (this.formConsumo.tbxMonto.Text != string.Empty && this.formConsumo.contadorPlazo.Value != 0 && this.formConsumo.contadorTasa.Value != 0)
            {
                this.formConsumo.dgvPlanPagoComercial.Rows.Clear();
                CodigoComun.PlanDeCuotas(this.formConsumo.dgvPlanPagoComercial, (Convert.ToDouble(this.formConsumo.tbxMonto.Text))
                , Convert.ToInt32(this.formConsumo.contadorPlazo.Value), (Math.Round(Convert.ToDouble(this.formConsumo.contadorTasa.Value), 2))
                , (Math.Round(Convert.ToDouble(this.formConsumo.tbxCuota.Text), 2)));
                LlenarCache();
            }
            else
            {
                formError = new FormError("Ingrese el valor del monto, plazo y cuota del crédito antes de simular el plan de pago");
                formError.ShowDialog();
            }

        }
        private void LlenarCache()
        {
            Cache.Cedula = this.formConsumo.tbxCedula.Text;
            Cache.Monto = Convert.ToDouble(this.formConsumo.tbxMonto.Text);
            Cache.Plazo = this.formConsumo.contadorPlazo.Value;
            Cache.Tasa = this.formConsumo.contadorTasa.Value;
            Cache.Cuota = Convert.ToDouble(this.formConsumo.tbxCuota.Text);

        }
        private async void ExportarArchivoExcel(object sender, EventArgs args)
        {
            using (formConfirmacion = new FormConfirmacion("¿Desea generar un archivo de excel con la información del crédito?"))
            {
                DialogResult result = formConfirmacion.ShowDialog();
                if (result == DialogResult.OK)
                {
                    CodigoComun.Alerta("Exportando, espere", FormVentanaEmergente.enmTipo.info);
                    await MostrarAlerta();
                    CodigoComun.Alerta("Archivo exportado", FormVentanaEmergente.enmTipo.exito);

                    
                }
            }
          
            EsconderSubMenu();

        }
        private async Task MostrarAlerta()
        {
            await Task.Run(() =>
            {
                exportarExcel.GuardarDataGrid(this.formConsumo.dgvPlanPagoComercial);
            });
        }
        private void FormatoNumeroTexBox(object sender, EventArgs args)
        {
            if (((TextBox)sender).Name == this.formConsumo.tbxMonto.Name && this.formConsumo.tbxMonto.Text != string.Empty)
                this.formConsumo.tbxMonto.Text = string.Format("{0:n0}", double.Parse(this.formConsumo.tbxMonto.Text));
        }
        private void PanelExportarDiseno() => this.formConsumo.pnlExportar.Visible = false;
        private void EsconderSubMenu()
        {
            if (this.formConsumo.pnlExportar.Visible == true) this.formConsumo.pnlExportar.Visible = false;
        }
        private void MostrarSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                EsconderSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        private void BotonExportar(object sender, EventArgs args)
        {
            MostrarSubMenu(this.formConsumo.pnlExportar);

        }
        private void AbrirCalculadora(object sender, EventArgs args)
        {
            formCalculadora = new FormCalculadora();
            formCalculadora.ShowDialog();
        }
        private void AbrirCalculadoraShortCut(object sender, KeyEventArgs e)
        {
            if(e.Alt &&  e.KeyCode == Keys.S)
            {
                this.formConsumo.btnCalculadora.PerformClick();
            }

            if(e.Alt && e.KeyCode == Keys.E)
            {
                this.formConsumo.btnExportar.PerformClick();
                this.formConsumo.btnExportarExcel.PerformClick();
            }
            if (e.Alt && e.KeyCode == Keys.A)
            {

                this.formConsumo.btnAnalisis.PerformClick();
            }

        }
    }
}

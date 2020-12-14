using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Presentacion.Ventanas.VentanaEmergente;
using Presentacion.Ventanas.VentanaError;
using SoporteUsuario.CacheUsuario;


namespace Presentacion.CodigoCompartido
{
    public class ExportarExcel
    {

        public void GuardarDataGrid(DataGridView dataGridView)
        {

            Microsoft.Office.Interop.Excel.Application application = new Microsoft.Office.Interop.Excel.Application();
            Workbook workbook = application.Workbooks.Add(XlSheetType.xlWorksheet);
            Worksheet worksheet = (Worksheet)application.ActiveSheet;
            Worksheet worksheet2 = (Worksheet)workbook.Worksheets.Add();
            Worksheet worksheet3 = (Worksheet)workbook.Worksheets.Add();
            Color colorNaranjaTitulos = Color.FromArgb(248, 100, 26);
            Color colorNarnjaClaroNombreVariables = Color.FromArgb(252, 228, 214);
            Color colorAzulClaroValorVariables = Color.FromArgb(217, 225, 242);
            FormError formError;

            for (int i = 1; i < dataGridView.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridView.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = (Math.Truncate(Convert.ToDouble(dataGridView.Rows[i].Cells[j].Value)).ToString());

                }
            }

            for (int i = 1; i < dataGridView.Rows.Count + 1; i++)
            {
                worksheet.Cells[i + 1, 1].Interior.Color = Color.FromArgb(252, 228, 214);
                worksheet.Cells[i + 1, 1].Font.Bold = true;
            }


            for (int i = 1; i < dataGridView.Rows.Count + 1; i++)
            {
                for (int j = 1; j < dataGridView.Columns.Count; j++)
                {
                    worksheet.Cells[i + 1, j + 1].Interior.Color = Color.FromArgb(217, 225, 242);
                }
            }


            Range line = (Range)worksheet.Rows[1];
            for (int i = 0; i < 15; i++)
            {
                line.Insert();
            }


            worksheet.Name = "Crédito Analizado";
            worksheet.Activate();
            application.ActiveWindow.DisplayGridlines = false;
            worksheet.Columns[3].NumberFormat = "#,##0.00";
            worksheet.Columns[4].NumberFormat = "#,##0.00";
            //letra negrilla

            worksheet.Range["A1:B1"].Font.Bold = true;
            worksheet.Cells[1, 1].Style.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            worksheet.Range["B1:F800"].Style = "Comma";

            //Escribir valores en celdas
            worksheet.Cells[1, 1] = "Información Básica personal";
            worksheet.Range["A1:B1"].Interior.Color = colorNaranjaTitulos;


            worksheet.Range["A1:B1"].Font.Color = Color.White;
            worksheet.Range["A1:B1"].Merge();

            worksheet.Cells[2, 1] = "Cédula";
            worksheet.Cells[2, 2] = Cache.Cedula;
            worksheet.Cells[3, 1] = "Nombre";
            worksheet.Cells[3, 2] = Cache.Nombre;
            worksheet.Cells[4, 1] = "Apellidos";
            worksheet.Cells[4, 2] = Cache.Apellido;

            worksheet.Cells[6, 1] = "Información del crédito";
            worksheet.Cells[7, 1] = "Monto";
            worksheet.Cells[7, 2] = Cache.Monto;
            worksheet.Cells[8, 1] = "Plazo";
            worksheet.Cells[8, 2] = Cache.Plazo;
            worksheet.Cells[9, 1] = "Tasa MV";
            worksheet.Cells[9, 2] = Cache.Tasa;
            worksheet.Cells[10, 1] = "Cuota";
            worksheet.Cells[10, 2] = Cache.Cuota;
            worksheet.Cells[11, 1] = "Periodicidad";
            worksheet.Cells[11, 2] = Cache.Periodicidad;
            worksheet.Cells[12, 1] = "Garantía";
            worksheet.Cells[12, 2] = Cache.Garantia;
            worksheet.Cells[13, 1] = "Forma de pago";
            worksheet.Cells[13, 2] = Cache.FormaDePago;
            worksheet.Cells[14, 1] = "Tipo de Credito";
            worksheet.Cells[14, 2] = ValidarTipoDeCredito() + ", " + Cache.TipoDePersona;

            worksheet.Range["A6:B6"].Interior.Color = colorNaranjaTitulos;
            worksheet.Range["A6:B6"].Font.Bold = true;
            worksheet.Range["A16:F16"].Interior.Color = colorNaranjaTitulos;
            worksheet.Range["A2:A4"].Interior.Color = colorNarnjaClaroNombreVariables;
            worksheet.Range["A2:A4"].Font.Bold = true;
            worksheet.Range["A7:A14"].Interior.Color = colorNarnjaClaroNombreVariables;
            worksheet.Range["A7:A14"].Font.Bold = true;
            worksheet.Range["B2:B4"].Interior.Color = colorAzulClaroValorVariables;
            worksheet.Range["B7:B14"].Interior.Color = colorAzulClaroValorVariables;
            worksheet.Range["A6:B6"].Font.Color = Color.White;
            worksheet.Range["A16:F16"].Font.Color = Color.White;

            worksheet.Columns.AutoFit();
            worksheet.Range["A6:B6"].Merge();


            if (Cache.TipoDeCredito != 4)
            {
                worksheet2.Activate();
                worksheet2.Name = "Informacion general";
                application.ActiveWindow.DisplayGridlines = false;


                worksheet2.Cells[1, 1] = "Información general";
                worksheet2.Range["A1:D1"].Interior.Color = colorNaranjaTitulos;
                worksheet2.Range["A1:D1"].Font.Color = Color.White;
                worksheet2.Cells[1, 4].EntireRow.Font.Bold = true;
                worksheet2.Range["A1:D1"].Merge();

                worksheet2.Cells[2, 1] = "Fecha de nacimiento";
                worksheet2.Cells[2, 2] = Cache.FechaDeNaciento;
                worksheet2.Cells[3, 1] = "Profesión";
                worksheet2.Cells[3, 2] = Cache.Profesion;
                worksheet2.Cells[4, 1] = "Cargo";
                worksheet2.Cells[4, 2] = Cache.Cargo;
                worksheet2.Cells[5, 1] = "Ocupación";
                worksheet2.Cells[5, 2] = Cache.Ocupacion;
                worksheet2.Cells[2, 3] = "Estado civil";
                worksheet2.Cells[2, 4] = Cache.EstadoCivil;
                worksheet2.Cells[3, 3] = "Edad";
                worksheet2.Cells[3, 4] = Cache.Edad + " años";
                worksheet2.Cells[4, 3] = "Persona a cargo";
                worksheet2.Cells[4, 4] = Cache.PersonasAcargo;
                worksheet2.Cells[5, 3] = "Tipo de vivienda";
                worksheet2.Cells[5, 4] = Cache.Vivienda + ", " + Cache.CiudadMunicipio + ", estrato " + Cache.Estrato;

                worksheet2.Cells[8, 1] = "Empresa donde labora";
                worksheet2.Cells[8, 2] = Cache.Empresa;
                worksheet2.Cells[9, 1] = "Tipo de contrato";
                worksheet2.Cells[9, 2] = Cache.TipoDeContrato;
                worksheet2.Cells[8, 3] = "Actividad económica";
                worksheet2.Cells[8, 4] = Cache.ActividadEconomica;
                worksheet2.Cells[9, 3] = "Antigüedad laboral";
                worksheet2.Cells[9, 4] = Cache.AntLaboral + " meses";


                worksheet2.Cells[7, 1] = "Información laboral";
                worksheet2.Range["A7:D7"].Interior.Color = colorNaranjaTitulos;
                worksheet2.Range["A7:D7"].Font.Color = Color.White;
                worksheet2.Cells[7, 4].EntireRow.Font.Bold = true;
                worksheet2.Range["A7:D7"].Merge();

                worksheet2.Range["A2:A5"].Interior.Color = colorNarnjaClaroNombreVariables;
                worksheet2.Range["A2:A5"].Font.Bold = true;
                worksheet2.Range["C2:C5"].Interior.Color = colorNarnjaClaroNombreVariables;
                worksheet2.Range["C2:C5"].Font.Bold = true;
                worksheet2.Range["B2:B5"].Interior.Color = colorAzulClaroValorVariables;
                worksheet2.Range["D2:D5"].Interior.Color = colorAzulClaroValorVariables;


                worksheet2.Range["A8:A9"].Interior.Color = colorNarnjaClaroNombreVariables;
                worksheet2.Range["A8:A9"].Font.Bold = true;
                worksheet2.Range["C8:C9"].Interior.Color = colorNarnjaClaroNombreVariables;
                worksheet2.Range["C8:C9"].Font.Bold = true;
                worksheet2.Range["B8:B9"].Interior.Color = colorAzulClaroValorVariables;
                worksheet2.Range["D8:D9"].Interior.Color = colorAzulClaroValorVariables;


                worksheet2.Cells[11, 1] = "Información Financiera (Ingresos)";
                worksheet2.Range["A11:B11"].Interior.Color = colorNaranjaTitulos;
                worksheet2.Range["A11:B11"].Font.Color = Color.White;
                worksheet2.Cells[11, 2].EntireRow.Font.Bold = true;
                worksheet2.Range["A11:B11"].Merge();

                worksheet2.Cells[12, 1] = "Ingresos";
                worksheet2.Cells[12, 2] = Cache.IngresoBasico;
                worksheet2.Cells[13, 1] = "Otros ingresos";
                worksheet2.Cells[13, 2] = Cache.OtrosIngresos;
                worksheet2.Cells[14, 1] = "Total Ingresos";
                worksheet2.Cells[14, 2] = Cache.TotalIngresos;
                worksheet2.Range["A12:A14"].Interior.Color = colorNarnjaClaroNombreVariables;
                worksheet2.Range["A12:A14"].Font.Bold = true;
                worksheet2.Range["B12:B14"].Interior.Color = colorAzulClaroValorVariables;

                worksheet2.Range["B12:B14"].Style = "Comma";

                worksheet2.Cells[16, 1] = "Información Financiera (Egresos)";
                worksheet2.Range["A16:D16"].Interior.Color = colorNaranjaTitulos;
                worksheet2.Range["A16:D16"].Font.Color = Color.White;
                worksheet2.Cells[16, 4].EntireRow.Font.Bold = true;
                worksheet2.Range["A16:D16"].Merge();

                worksheet2.Cells[17, 1] = "Deducciones seguridad social";
                worksheet2.Cells[17, 2] = Cache.DeduccionesDeSeguridadSocial;
                worksheet2.Cells[18, 1] = "Otras deducciones colilla";
                worksheet2.Cells[18, 2] = Cache.OtrasDeduccionesColilla;
                worksheet2.Cells[19, 1] = "Total deducciones";
                worksheet2.Cells[19, 2] = Cache.DeduccionesColilla;
                worksheet2.Cells[20, 1] = "Cuotas a cancelar";
                worksheet2.Cells[20, 2] = Cache.CuotasACancelar;
                worksheet2.Cells[17, 3] = "Estimación cupo Rotativo";
                worksheet2.Cells[17, 4] = Cache.EstimacionCupoRotativo;
                worksheet2.Cells[18, 3] = "Valor cuota libranza";
                worksheet2.Cells[18, 4] = Cache.ValorCuotaLibranza;
                worksheet2.Cells[19, 3] = "Cuota de crédito a cancelar por nómina";
                worksheet2.Cells[19, 4] = Cache.CuotasDeCreditoACancelarPorNomina;
                worksheet2.Cells[20, 3] = "Estimación tarjeras de crédito";
                worksheet2.Cells[20, 4] = Cache.EstimacionTarjetasDeCredito;
                worksheet2.Cells[21, 3] = "Cuotas centrlas de riesgo";
                worksheet2.Cells[21, 4] = Cache.CuotaCentrales;
                worksheet2.Range["A17:A20"].Interior.Color = colorNarnjaClaroNombreVariables;
                worksheet2.Range["A17:A20"].Font.Bold = true;
                worksheet2.Range["C17:C21"].Interior.Color = colorNarnjaClaroNombreVariables;
                worksheet2.Range["C17:C21"].Font.Bold = true;
                worksheet2.Range["B17:B20"].Interior.Color = colorAzulClaroValorVariables;
                worksheet2.Range["D17:D21"].Interior.Color = colorAzulClaroValorVariables;

                worksheet2.Range["B17:B20"].Style = "Comma";
                worksheet2.Range["D17:D21"].Style = "Comma";

                worksheet2.Cells[23, 1] = "Calificación del solicitante";
                worksheet2.Range["A23:N23"].Interior.Color = colorNaranjaTitulos;
                worksheet2.Range["A23:N23"].Font.Color = Color.White;
                worksheet2.Cells[23, 14].EntireRow.Font.Bold = true;
                worksheet2.Range["A23:N23"].Merge();
                worksheet2.Cells[24, 1] = "Score";
                worksheet2.Cells[24, 2] = Cache.Score;
                worksheet2.Cells[24, 3] = "Calificación";
                worksheet2.Cells[24, 4] = Cache.Calificacion;
                worksheet2.Cells[24, 5] = "Afectación colilla";
                worksheet2.Cells[24, 6] = Cache.AfectacionColilla;
                worksheet2.Cells[24, 7] = "Endeudamiento global";
                worksheet2.Cells[24, 8] = Cache.EndeudamientoGlobal;
                worksheet2.Cells[24, 9] = "Disponible";
                worksheet2.Cells[24, 10] = Cache.Disponible;
                worksheet2.Cells[24, 11] = "Ley de libranza";
                worksheet2.Cells[24, 12] = Cache.AplicaLeyLibranza;
                worksheet2.Cells[24, 13] = "Total moras";
                worksheet2.Cells[24, 14] = Cache.ComportamientoDePagos;
                worksheet2.Range["A24:A24"].Interior.Color = colorNarnjaClaroNombreVariables;
                worksheet2.Range["A24:A24"].Font.Bold = true;
                worksheet2.Range["C24:C24"].Interior.Color = colorNarnjaClaroNombreVariables;
                worksheet2.Range["C24:C24"].Font.Bold = true;
                worksheet2.Range["E24:E24"].Interior.Color = colorNarnjaClaroNombreVariables;
                worksheet2.Range["E24:E24"].Font.Bold = true;
                worksheet2.Range["G24:G24"].Interior.Color = colorNarnjaClaroNombreVariables;
                worksheet2.Range["G24:G24"].Font.Bold = true;
                worksheet2.Range["I24:I24"].Interior.Color = colorNarnjaClaroNombreVariables;
                worksheet2.Range["I24:I24"].Font.Bold = true;
                worksheet2.Range["K24:K24"].Interior.Color = colorNarnjaClaroNombreVariables;
                worksheet2.Range["K24:K24"].Font.Bold = true;
                worksheet2.Range["M24:M24"].Interior.Color = colorNarnjaClaroNombreVariables;
                worksheet2.Range["M24:M24"].Font.Bold = true;
                worksheet2.Range["B24:B24"].Interior.Color = colorAzulClaroValorVariables;
                worksheet2.Range["D24:D24"].Interior.Color = colorAzulClaroValorVariables;
                worksheet2.Range["F24:F24"].Interior.Color = colorAzulClaroValorVariables;
                worksheet2.Range["H24:H24"].Interior.Color = colorAzulClaroValorVariables;
                worksheet2.Range["J24:J24"].Interior.Color = colorAzulClaroValorVariables;
                worksheet2.Range["L24:L24"].Interior.Color = colorAzulClaroValorVariables;
                worksheet2.Range["N24:N24"].Interior.Color = colorAzulClaroValorVariables;

                worksheet2.Range["J24:J24"].Style = "Comma";
                worksheet2.Range["F24:F24"].NumberFormat = "0.00%";
                worksheet2.Range["H24:H24"].NumberFormat = "0.00%";

                worksheet2.Cells[26, 1] = "Cumplimiento de políticas";
                worksheet2.Range["A26:F26"].Interior.Color = colorNaranjaTitulos;
                worksheet2.Range["A26:F26"].Font.Color = Color.White;
                worksheet2.Range["A26:F26"].Merge();
                worksheet2.Cells[26, 5].EntireRow.Font.Bold = true;
                worksheet2.Cells[27, 1] = Cache.CumplimientoDePoliticias;
                worksheet2.Range["A27:F35"].Style.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                worksheet2.Range["A27:F35"].Interior.Color = colorAzulClaroValorVariables;
                worksheet2.Range["A27:F35"].Merge();

                worksheet2.Cells[38, 1] = "Criterio del analista";
                worksheet2.Range["A38:F38"].Interior.Color = colorNaranjaTitulos;
                worksheet2.Range["A38:F38"].Font.Color = Color.White;
                worksheet2.Range["A38:F38"].Merge();
                worksheet2.Cells[38, 5].EntireRow.Font.Bold = true;
                worksheet2.Cells[39, 1] = Cache.CriterioDelAnalista;
                worksheet2.Range["A39:F43"].Style.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                worksheet2.Range["A39:F43"].Interior.Color = colorAzulClaroValorVariables;
                worksheet2.Range["A39:F43"].Merge();

                worksheet2.Cells[45, 1] = "Nombre del analista";
                worksheet2.Cells[45, 1].EntireRow.Font.Bold = true;
                worksheet2.Cells[45, 2] = Cache.NombreAnalista;
                worksheet2.Cells[45, 2].EntireRow.Font.Italic = true;
                worksheet2.Range["A45:B45"].Interior.Color = colorAzulClaroValorVariables;

                worksheet2.Columns.AutoFit();
                worksheet2.Rows.AutoFit();
                worksheet2.Cells[1, 1].Style.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            }

            else if (Cache.TipoDeCredito == 4)
            {
                worksheet2.Activate();
                worksheet2.Name = "Informacion general";
                application.ActiveWindow.DisplayGridlines = false;


                worksheet2.Cells[1, 1] = "Información general";
                worksheet2.Range["A1:D1"].Interior.Color = colorNaranjaTitulos;
                worksheet2.Range["A1:D1"].Font.Color = Color.White;
                worksheet2.Cells[1, 4].EntireRow.Font.Bold = true;
                worksheet2.Range["A1:D1"].Merge();

                worksheet2.Cells[2, 1] = "Fecha de nacimiento";
                worksheet2.Cells[2, 2] = Cache.FechaDeNaciento;
                worksheet2.Cells[3, 1] = "Profesión";
                worksheet2.Cells[3, 2] = Cache.Profesion;
                worksheet2.Cells[4, 1] = "Cargo";
                worksheet2.Cells[4, 2] = Cache.Cargo;
                worksheet2.Cells[5, 1] = "Ocupación";
                worksheet2.Cells[5, 2] = Cache.Ocupacion;
                worksheet2.Cells[2, 3] = "Estado civil";
                worksheet2.Cells[2, 4] = Cache.EstadoCivil;
                worksheet2.Cells[3, 3] = "Edad";
                worksheet2.Cells[3, 4] = Cache.Edad + " años";
                worksheet2.Cells[4, 3] = "Persona a cargo";
                worksheet2.Cells[4, 4] = Cache.PersonasAcargo;
                worksheet2.Cells[5, 3] = "Tipo de vivienda";
                worksheet2.Cells[5, 4] = Cache.Vivienda + ", " + Cache.CiudadMunicipio;

                worksheet2.Cells[8, 1] = "Empresa donde labora";
                worksheet2.Cells[8, 2] = Cache.Empresa;
                worksheet2.Cells[9, 1] = "Tipo de contrato";
                worksheet2.Cells[9, 2] = Cache.TipoDeContrato;
                worksheet2.Cells[8, 3] = "Actividad económica";
                worksheet2.Cells[8, 4] = Cache.ActividadEconomica;
                worksheet2.Cells[9, 3] = "Antigüedad laboral";
                worksheet2.Cells[9, 4] = Cache.AntLaboral + " meses";


                worksheet2.Cells[7, 1] = "Información laboral";
                worksheet2.Range["A7:D7"].Interior.Color = colorNaranjaTitulos;
                worksheet2.Range["A7:D7"].Font.Color = Color.White;
                worksheet2.Cells[7, 4].EntireRow.Font.Bold = true;
                worksheet2.Range["A7:D7"].Merge();

                worksheet2.Range["A2:A5"].Interior.Color = colorNarnjaClaroNombreVariables;
                worksheet2.Range["A2:A5"].Font.Bold = true;
                worksheet2.Range["C2:C5"].Interior.Color = colorNarnjaClaroNombreVariables;
                worksheet2.Range["C2:C5"].Font.Bold = true;
                worksheet2.Range["B2:B5"].Interior.Color = colorAzulClaroValorVariables;
                worksheet2.Range["D2:D5"].Interior.Color = colorAzulClaroValorVariables;


                worksheet2.Range["A8:A9"].Interior.Color = colorNarnjaClaroNombreVariables;
                worksheet2.Range["A8:A9"].Font.Bold = true;
                worksheet2.Range["C8:C9"].Interior.Color = colorNarnjaClaroNombreVariables;
                worksheet2.Range["C8:C9"].Font.Bold = true;
                worksheet2.Range["B8:B9"].Interior.Color = colorAzulClaroValorVariables;
                worksheet2.Range["D8:D9"].Interior.Color = colorAzulClaroValorVariables;


                worksheet2.Cells[11, 1] = "Información Financiera (Ingresos)";
                worksheet2.Range["A11:B11"].Interior.Color = colorNaranjaTitulos;
                worksheet2.Range["A11:B11"].Font.Color = Color.White;
                worksheet2.Cells[11, 2].EntireRow.Font.Bold = true;
                worksheet2.Range["A11:B11"].Merge();

                worksheet2.Cells[12, 1] = "Ingresos";
                worksheet2.Cells[12, 2] = Cache.IngresoBasico;
                worksheet2.Cells[13, 1] = "Egresos";
                worksheet2.Cells[13, 2] = Cache.OtrosIngresos;
                worksheet2.Cells[14, 1] = "Total Ingresos";
                worksheet2.Cells[14, 2] = Cache.TotalIngresos;
                worksheet2.Range["A12:A14"].Interior.Color = colorNarnjaClaroNombreVariables;
                worksheet2.Range["A12:A14"].Font.Bold = true;
                worksheet2.Range["B12:B14"].Interior.Color = colorAzulClaroValorVariables;

                //SE CAMBIA DESDE AQUI
                worksheet2.Cells[16, 1] = "Estado de resultados";
                worksheet2.Range["A16:D16"].Interior.Color = colorNaranjaTitulos;
                worksheet2.Range["A16:D16"].Font.Color = Color.White;
                worksheet2.Cells[16, 4].EntireRow.Font.Bold = true;
                worksheet2.Range["A16:D16"].Merge();

                worksheet2.Cells[17, 1] = "Ventas";
                worksheet2.Cells[17, 2] = Cache.VentasMicro;
                worksheet2.Cells[18, 1] = "Gastos del negocio";
                worksheet2.Cells[18, 2] = Cache.GastosDelNegocioMicro;
                worksheet2.Cells[19, 1] = "Gastos familiares y otros";
                worksheet2.Cells[19, 2] = Cache.GastosFamiliaresYOtrosMicro;
                worksheet2.Cells[20, 1] = "Cuota Centrales de riesgo";
                worksheet2.Cells[20, 2] = Cache.CuotaCentralesDeRiesgoMicro;
                worksheet2.Cells[21, 1] = "Utilidad bruta";
                worksheet2.Cells[21, 2] = Cache.UtilidadBrutaMicro;
                worksheet2.Cells[22, 1] = "Utilidad o pérdida neta";
                worksheet2.Cells[22, 2] = Cache.UtilidadOPerdiaNeta;

                worksheet2.Cells[17, 3] = "Costo de ventas";
                worksheet2.Cells[17, 4] = Cache.CostosDeVentasMicro;
                worksheet2.Cells[18, 3] = "Ingresos familiares y otros";
                worksheet2.Cells[18, 4] = Cache.IngresosFamiliarYOtrosMicro;
                worksheet2.Cells[19, 3] = "Cuota crédito a refianciar";
                worksheet2.Cells[19, 4] = Cache.CuotaDelCreditoARefinancierMicro;
                worksheet2.Cells[20, 3] = "Utilidad o pérdida operativa";
                worksheet2.Cells[20, 4] = Cache.UtilidadOPerdidaOperativaMicro;
                worksheet2.Cells[21, 3] = "Utilidad disponible";
                worksheet2.Cells[21, 4] = Cache.UtildiadDisponibleMicro;

                worksheet2.Range["A17:A22"].Interior.Color = colorNarnjaClaroNombreVariables;
                worksheet2.Range["A17:A22"].Font.Bold = true;
                worksheet2.Range["C17:C21"].Interior.Color = colorNarnjaClaroNombreVariables;
                worksheet2.Range["C17:C21"].Font.Bold = true;
                worksheet2.Range["B17:B22"].Interior.Color = colorAzulClaroValorVariables;
                worksheet2.Range["D17:D21"].Interior.Color = colorAzulClaroValorVariables;




                worksheet2.Cells[24, 1] = "Capacidad de pago deudor";
                worksheet2.Range["A24:F24"].Interior.Color = colorNaranjaTitulos;
                worksheet2.Range["A24:F24"].Font.Color = Color.White;
                worksheet2.Cells[24, 6].EntireRow.Font.Bold = true;
                worksheet2.Range["A24:F24"].Merge();

                worksheet2.Cells[25, 1] = "Margen de confianza";
                worksheet2.Cells[25, 2] = Cache.MargenDeConfianzaMicro;
                worksheet2.Cells[25, 3] = "Capacidad de pago con cuota";
                worksheet2.Cells[25, 4] = Cache.CapaciodadDePagoConCuotaMicro;
                worksheet2.Cells[25, 5] = "Endeudamiento directo";
                worksheet2.Cells[25, 6] = Cache.EndeudamientoDirectodeudorMicro;

                worksheet2.Range["A25:A25"].Interior.Color = colorNarnjaClaroNombreVariables;
                worksheet2.Range["A25:A25"].Font.Bold = true;
                worksheet2.Range["C25:C25"].Interior.Color = colorNarnjaClaroNombreVariables;
                worksheet2.Range["C25:C25"].Font.Bold = true;
                worksheet2.Range["E25:E25"].Interior.Color = colorNarnjaClaroNombreVariables;
                worksheet2.Range["E25:E25"].Font.Bold = true;
                worksheet2.Range["B25:B25"].Interior.Color = colorAzulClaroValorVariables;
                worksheet2.Range["D25:D25"].Interior.Color = colorAzulClaroValorVariables;
                worksheet2.Range["F25:F25"].Interior.Color = colorAzulClaroValorVariables;


                worksheet2.Cells[27, 1] = "Capacidad de pago codeudor";
                worksheet2.Range["A27:F27"].Interior.Color = colorNaranjaTitulos;
                worksheet2.Range["A27:F27"].Font.Color = Color.White;
                worksheet2.Cells[27, 6].EntireRow.Font.Bold = true;
                worksheet2.Range["A27:F27"].Merge();

                worksheet2.Cells[28, 1] = "Ingresos del codeudor";
                worksheet2.Cells[28, 2] = Cache.IngresosCodeudor;
                worksheet2.Cells[28, 3] = "Egresos Codeudor";
                worksheet2.Cells[28, 4] = Cache.EgresosCodeudorMicro;
                worksheet2.Cells[28, 5] = "Endeudamiento directo";
                worksheet2.Cells[28, 6] = Cache.EndeudamientoDirectodeudorMicro;

                worksheet2.Range["A28:A28"].Interior.Color = colorNarnjaClaroNombreVariables;
                worksheet2.Range["A28:A28"].Font.Bold = true;
                worksheet2.Range["C28:C28"].Interior.Color = colorNarnjaClaroNombreVariables;
                worksheet2.Range["C28:C28"].Font.Bold = true;
                worksheet2.Range["E28:E28"].Interior.Color = colorNarnjaClaroNombreVariables;
                worksheet2.Range["E28:E28"].Font.Bold = true;
                worksheet2.Range["B28:B28"].Interior.Color = colorAzulClaroValorVariables;
                worksheet2.Range["D28:D28"].Interior.Color = colorAzulClaroValorVariables;
                worksheet2.Range["F28:F28"].Interior.Color = colorAzulClaroValorVariables;



                worksheet2.Cells[30, 1] = "Calificación del solicitante";
                worksheet2.Range["A30:H30"].Interior.Color = colorNaranjaTitulos;
                worksheet2.Range["A30:H30"].Font.Color = Color.White;
                worksheet2.Cells[30, 8].EntireRow.Font.Bold = true;
                worksheet2.Range["A30:H30"].Merge();

                worksheet2.Cells[31, 1] = "Número de moras";
                worksheet2.Cells[31, 2] = Cache.NumeroDemoras;
                worksheet2.Cells[31, 3] = "Días de mora";
                worksheet2.Cells[31, 4] = Cache.DiasDeMora;
                worksheet2.Cells[31, 5] = "Calificación";
                worksheet2.Cells[31, 6] = Cache.Calificacion;
                worksheet2.Cells[31, 7] = "Score";
                worksheet2.Cells[31, 8] = Cache.Score;

                worksheet2.Range["A31:A31"].Interior.Color = colorNarnjaClaroNombreVariables;
                worksheet2.Range["A31:A31"].Font.Bold = true;
                worksheet2.Range["C31:C31"].Interior.Color = colorNarnjaClaroNombreVariables;
                worksheet2.Range["C31:C31"].Font.Bold = true;
                worksheet2.Range["E31:E31"].Interior.Color = colorNarnjaClaroNombreVariables;
                worksheet2.Range["E31:E31"].Font.Bold = true;
                worksheet2.Range["G31:G31"].Interior.Color = colorNarnjaClaroNombreVariables;
                worksheet2.Range["G31:G31"].Font.Bold = true;
                worksheet2.Range["B31:B31"].Interior.Color = colorAzulClaroValorVariables;
                worksheet2.Range["D31:D31"].Interior.Color = colorAzulClaroValorVariables;
                worksheet2.Range["F31:F31"].Interior.Color = colorAzulClaroValorVariables;
                worksheet2.Range["H31:H31"].Interior.Color = colorAzulClaroValorVariables;


                //Cumplimiento de políticas
                worksheet2.Cells[33, 1] = "Cumplimiento de políticas";
                worksheet2.Range["A33:F33"].Interior.Color = colorNaranjaTitulos;
                worksheet2.Range["A33:F33"].Font.Color = Color.White;
                worksheet2.Range["A33:F33"].Merge();
                worksheet2.Cells[33, 5].EntireRow.Font.Bold = true;
                worksheet2.Cells[34, 1] = Cache.CumplimientoDePoliticias;
                worksheet2.Range["A34:F40"].Style.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                worksheet2.Range["A34:F40"].Interior.Color = colorAzulClaroValorVariables;
                worksheet2.Range["A34:F40"].Merge();

                worksheet2.Cells[41, 1] = "Criterio del analista";
                worksheet2.Range["A41:F41"].Interior.Color = colorNaranjaTitulos;
                worksheet2.Range["A41:F41"].Font.Color = Color.White;
                worksheet2.Range["A41:F41"].Merge();
                worksheet2.Cells[41, 5].EntireRow.Font.Bold = true;
                worksheet2.Cells[42, 1] = Cache.CriterioDelAnalista;
                worksheet2.Range["A42:F46"].Style.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                worksheet2.Range["A42:F46"].Interior.Color = colorAzulClaroValorVariables;
                worksheet2.Range["A42:F46"].Merge();

                worksheet2.Cells[48, 1] = "Nombre del analista";
                worksheet2.Cells[48, 1].EntireRow.Font.Bold = true;
                worksheet2.Cells[48, 2] = Cache.NombreAnalista;
                worksheet2.Cells[48, 2].EntireRow.Font.Italic = true;
                worksheet2.Range["A48:B48"].Interior.Color = colorAzulClaroValorVariables;


                // worksheet3.Range["B2:D11"].Style = "Comma";
                // worksheet3.Range["B16:B17"].Style = "Comma";
                worksheet2.Columns.AutoFit();
                worksheet2.Rows.AutoFit();

            }




            //Codeudor

            if (Cache.TipoDeCredito != 4)
            {
                worksheet3.Activate();
                worksheet3.Name = "Informacion Codeudor";
                application.ActiveWindow.DisplayGridlines = false;

                worksheet3.Cells[1, 1] = "Información Financiera";
                worksheet3.Range["A1:B1"].Interior.Color = colorNaranjaTitulos;
                worksheet3.Range["A1:B1"].Font.Color = Color.White;
                worksheet3.Cells[1, 2].EntireRow.Font.Bold = true;
                worksheet3.Range["A1:B1"].Merge();

                worksheet3.Cells[2, 1] = "Ingresos";
                worksheet3.Cells[2, 2] = Cache.IngresosCodeudor;
                worksheet3.Cells[3, 1] = "Otros ingresos";
                worksheet3.Cells[3, 2] = Cache.OtrosIngresosCodeudor;
                worksheet3.Cells[4, 1] = "Total ingresos";
                worksheet3.Cells[4, 2] = Cache.TotalIngresosCodeudor;
                worksheet3.Cells[5, 1] = "Vivienda";
                worksheet3.Cells[5, 2] = Cache.TipoDeViviendaCodeudor;
                worksheet3.Cells[6, 1] = "Zona de residencia";
                worksheet3.Cells[6, 2] = Cache.CiudadMunicipioCodeduor;

                worksheet3.Range["A2:A6"].Interior.Color = colorNarnjaClaroNombreVariables;
                worksheet3.Range["A2:A6"].Font.Bold = true;
                worksheet3.Range["B2:B6"].Interior.Color = colorAzulClaroValorVariables;



                worksheet3.Cells[8, 1] = "Información Egresos";
                worksheet3.Range["A8:D8"].Interior.Color = colorNaranjaTitulos;
                worksheet3.Range["A8:D8"].Font.Color = Color.White;
                worksheet3.Cells[8, 1].EntireRow.Font.Bold = true;
                worksheet3.Range["A8:D8"].Merge();

                worksheet3.Cells[9, 1] = "Deducciones Seguridad Social";
                worksheet3.Cells[9, 2] = Cache.DeduccionesDeSeguridadSocialCodeudor;
                worksheet3.Cells[10, 1] = "Otras Deducciones";
                worksheet3.Cells[10, 2] = Cache.OtrasDeduccionesColillaCodeudor;
                worksheet3.Cells[11, 1] = "Total Deducciones";
                worksheet3.Cells[11, 2] = Cache.TotalDeduccionesColillaCodeudor;
                worksheet3.Cells[9, 3] = "Cuota Centrales";
                worksheet3.Cells[9, 4] = Cache.CuotasCentralesDeRiesgoCodeudor;
                worksheet3.Cells[10, 3] = "Valor Cuota Libranza";
                worksheet3.Cells[10, 4] = Cache.ValorCuotaLibranzaCodeudor;
                worksheet3.Cells[11, 3] = "Cuotas a Cancelar";
                worksheet3.Cells[11, 4] = Cache.CuotasACancelarCodeudor;

                worksheet3.Range["A9:A11"].Interior.Color = colorNarnjaClaroNombreVariables;
                worksheet3.Range["A9:A11"].Font.Bold = true;
                worksheet3.Range["C9:C11"].Interior.Color = colorNarnjaClaroNombreVariables;
                worksheet3.Range["C9:C11"].Font.Bold = true;
                worksheet3.Range["B9:B11"].Interior.Color = colorAzulClaroValorVariables;
                worksheet3.Range["D9:D11"].Interior.Color = colorAzulClaroValorVariables;



                worksheet3.Cells[13, 1] = "Indicadores Capacidad";
                worksheet3.Range["A13:B13"].Interior.Color = colorNaranjaTitulos;
                worksheet3.Range["A13:B13"].Font.Color = Color.White;
                worksheet3.Cells[13, 1].EntireRow.Font.Bold = true;
                worksheet3.Range["A13:B13"].Merge();

                worksheet3.Cells[14, 1] = "Afectacion colilla";
                worksheet3.Cells[14, 2] = Cache.AfectacionColillaCodeudor;
                worksheet3.Cells[15, 1] = "Endeudamiento global";
                worksheet3.Cells[15, 2] = Cache.EndeudamientoGlobalCodeudor;
                worksheet3.Cells[16, 1] = "Disponible";
                worksheet3.Cells[16, 2] = Cache.DisponibleCodeudor;
                worksheet3.Cells[17, 1] = "Ley de libranza";
                worksheet3.Cells[17, 2] = Cache.AplicaLeyLibranzaCodeduor;

                worksheet3.Range["A14:A17"].Interior.Color = colorNarnjaClaroNombreVariables;
                worksheet3.Range["A14:A17"].Font.Bold = true;
                worksheet3.Range["B14:B17"].Interior.Color = colorAzulClaroValorVariables;

                worksheet3.Range["B2:D11"].Style = "Comma";
                worksheet3.Range["B16:B17"].Style = "Comma";
                worksheet3.Columns.AutoFit();
                worksheet3.Rows.AutoFit();
                worksheet3.Cells[1, 1].Style.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;


                worksheet3.Range["B14:B15"].NumberFormat = "0.00%";

            }

            else if (Cache.TipoDeCredito == 4)
            {
                worksheet3.Activate();
                worksheet3.Name = "Informacion Codeudor";
                application.ActiveWindow.DisplayGridlines = false;

                worksheet3.Cells[1, 1] = "Capacidad de pago";
                worksheet3.Range["A1:B1"].Interior.Color = colorNaranjaTitulos;
                worksheet3.Range["A1:B1"].Font.Color = Color.White;
                worksheet3.Cells[1, 2].EntireRow.Font.Bold = true;
                worksheet3.Range["A1:B1"].Merge();

                worksheet3.Cells[2, 1] = "Ingresos";
                worksheet3.Cells[2, 2] = Cache.IngresosCodeudor;
                worksheet3.Cells[3, 1] = "Egresos";
                worksheet3.Cells[3, 2] = Cache.EgresosCodeudorMicro;
                worksheet3.Cells[4, 1] = "Endeudamiento directo";
                worksheet3.Cells[4, 2] = Cache.EndeudamientoDirectoCodeudorMicro;

                worksheet3.Range["A2:A4"].Interior.Color = colorNarnjaClaroNombreVariables;
                worksheet3.Range["A2:A4"].Font.Bold = true;
                worksheet3.Range["B2:B4"].Interior.Color = colorAzulClaroValorVariables;

                worksheet3.Range["B2:B3"].Style = "Comma";
                worksheet3.Range["B4:B5"].NumberFormat = "0.00%";
                worksheet3.Columns.AutoFit();
                worksheet3.Rows.AutoFit();
                worksheet3.Cells[1, 1].Style.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            }


            worksheet.Activate();

            application.DisplayAlerts = true;

            try
            {
                string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                workbook.SaveAs(Filename: ruta + "/" + Cache.Cedula + " " + Cache.Nombre + " " + Cache.Apellido + ".xlsx");
                //workbook.Close();
            }
            catch (Exception e)
            {
                formError = new FormError($"Error tipo {e}");
            }

            workbook.Close();
        }

        private string ValidarTipoDeCredito()
        {
            if (Cache.TipoDeCredito == 1) return "Consumo";
            else if (Cache.TipoDeCredito == 2) return "Comercial";
            else if (Cache.TipoDeCredito == 3) return "Vivienda";
            else return "Microcrédito";
        }


    }
}

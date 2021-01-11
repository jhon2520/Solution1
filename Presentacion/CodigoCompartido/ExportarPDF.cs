using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Reflection;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Windows.Forms;
using System.Drawing;
using SoporteUsuario.CacheUsuario;
using Presentacion.Ventanas.VentanaError;

namespace Presentacion.CodigoCompartido
{
    public class ExportarPDF
    {
        private FormError formError;
        public void Exportar(DataGridView dataGridView1)
        {
            //Creating iTextSharp Table from the DataTable data


            PdfPTable pdfTable = new PdfPTable(dataGridView1.ColumnCount);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 100;
            pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfTable.DefaultCell.BorderWidth = 1;


            //letras
            var letraBlanca = FontFactory.GetFont("Arial", 15);
            letraBlanca.SetColor(255, 255, 255);

            var TitulosLetra = FontFactory.GetFont("Arial", 15, iTextSharp.text.Font.BOLD);
            TitulosLetra.SetColor(248, 100, 26);


            //Añadir titulo del plan de pagos

            var Titulo = new Paragraph("ANÁLISIS DEL CRÉDITO", TitulosLetra);
            Titulo.Alignment = Element.ALIGN_CENTER;


            var informacionBasica = new Paragraph("Información Básica:", TitulosLetra);

            var planDePAgo = new Paragraph("Plan de pago:", TitulosLetra);


            var cedula = new Chunk("Cédula: ", FontFactory.GetFont("Arial", 15, color: new BaseColor(77,  77 ,77)));
            var cedulaValor = new Chunk($"{string.Format("{0:#,0}", Convert.ToDouble(Cache.Cedula))}, ", FontFactory.GetFont("Arial", 15, new BaseColor(0, 0, 0)));

            var nombre = new Chunk("Nombre: ", FontFactory.GetFont("Arial", 15, color: new BaseColor(77,  77 ,77)));
            var nombrevalor = new Chunk($"{Cache.Nombre} {Cache.Apellido}", FontFactory.GetFont("Arial", 15, new BaseColor(0, 0, 0)));



            var informacionCredito = new Paragraph("Información Del Crédito:", TitulosLetra);


            var monto = new Chunk("Monto Crédito: ", FontFactory.GetFont("Arial", 15, color: new BaseColor(77,  77 ,77)));
            var montoValor = new Chunk($"{string.Format("{0:#,0}", Cache.Monto)} ", FontFactory.GetFont("Arial", 15, new BaseColor(0, 0, 0)));

            var plazo = new Chunk("Plazo: ", FontFactory.GetFont("Arial", 15, color: new BaseColor(77,  77 ,77)));
            var plazoValor = new Chunk($"{string.Format("{0:#,0}", Convert.ToDouble(Cache.Plazo))} meses ", FontFactory.GetFont("Arial", 15, new BaseColor(0, 0, 0)));

            var tasa = new Chunk("Tasa MV: ", FontFactory.GetFont("Arial", 15, color: new BaseColor(77,  77 ,77)));
            var tasaValor = new Chunk($"{string.Format("{0:#,0.00}", Convert.ToDouble(Cache.Tasa))} ", FontFactory.GetFont("Arial", 15, new BaseColor(0, 0, 0)));

            var Cuota = new Chunk("Cuota: ", FontFactory.GetFont("Arial", 15, color: new BaseColor(77,  77 ,77)));
            var cuotaValor = new Chunk($"{string.Format("{0:#,0.00}", Cache.Cuota)} ", FontFactory.GetFont("Arial", 15, new BaseColor(0, 0, 0)));

            var periodicidad = new Chunk("Periodicidad: ", FontFactory.GetFont("Arial", 15, color: new BaseColor(77,  77 ,77)));
            var periodicidadValor = new Chunk($"{Cache.Periodicidad} ", FontFactory.GetFont("Arial", 15, new BaseColor(0, 0, 0)));

            var garantia = new Chunk("Garantía: ", FontFactory.GetFont("Arial", 15, color: new BaseColor(77,  77 ,77)));
            var garantiaValor = new Chunk($"{Cache.Garantia} ", FontFactory.GetFont("Arial", 15, new BaseColor(0, 0, 0)));

            var formaDePago = new Chunk("Forma de pago: ", FontFactory.GetFont("Arial", 15, color: new BaseColor(77,  77 ,77)));
            var formaDePagoValor = new Chunk($"{Cache.FormaDePago} ", FontFactory.GetFont("Arial", 15, new BaseColor(0, 0, 0)));

            var tipoDeCredito = new Chunk("Tipo de Crédito: ", FontFactory.GetFont("Arial", 15, color: new BaseColor(77,  77 ,77)));
            var tipoDeCreditoValor = new Chunk($"{ValidarTipoDeCredito()} ", FontFactory.GetFont("Arial", 15, new BaseColor(0, 0, 0)));




            var informacionGeneral = new Paragraph("Información General:", TitulosLetra);


            var fechaNacimiento = new Chunk("Fecha de nacimiento: ", FontFactory.GetFont("Arial", 15, color: new BaseColor(77,  77 ,77)));
            var fechaNacimientoValor = new Chunk($"{Cache.FechaDeNaciento} ", FontFactory.GetFont("Arial", 15, new BaseColor(0, 0, 0)));
            
            var estadiCivil = new Chunk("Estado civil: ", FontFactory.GetFont("Arial", 15, color: new BaseColor(77,  77 ,77)));
            var estadiCivilValor = new Chunk($"{Cache.EstadoCivil} ", FontFactory.GetFont("Arial", 15, new BaseColor(0, 0, 0)));

            var profesion = new Chunk("Profesión: ", FontFactory.GetFont("Arial", 15, color: new BaseColor(77,  77 ,77)));
            var profesionValor = new Chunk($"{Cache.Profesion} ", FontFactory.GetFont("Arial", 15, new BaseColor(0, 0, 0)));

            var edad = new Chunk("Edad: ", FontFactory.GetFont("Arial", 15, color: new BaseColor(77,  77 ,77)));
            var edadValor = new Chunk($"{Cache.Edad} años ", FontFactory.GetFont("Arial", 15, new BaseColor(0, 0, 0)));

            var cargo = new Chunk("Cargo: ", FontFactory.GetFont("Arial", 15, color: new BaseColor(77,  77 ,77)));
            var cargoValor = new Chunk($"{Cache.Cargo} ", FontFactory.GetFont("Arial", 15, new BaseColor(0, 0, 0)));

            var personasACargo = new Chunk("Personas a cargo: ", FontFactory.GetFont("Arial", 15, color: new BaseColor(77,  77 ,77)));
            var personasACargoValor = new Chunk($"{Cache.PersonasAcargo} ", FontFactory.GetFont("Arial", 15, new BaseColor(0, 0, 0)));

            var ocupacion = new Chunk("Ocupación: ", FontFactory.GetFont("Arial", 15, color: new BaseColor(77,  77 ,77)));
            var ocupacionValor = new Chunk($"{Cache.Ocupacion} ", FontFactory.GetFont("Arial", 15, new BaseColor(0, 0, 0)));

            var tipovivienda = new Chunk("Tipo de vivienda: ", FontFactory.GetFont("Arial", 15, color: new BaseColor(77,  77 ,77)));
            var tipoViviendaValor = new Chunk($"{Cache.Vivienda} ", FontFactory.GetFont("Arial", 15, new BaseColor(0, 0, 0)));



            var informacionLaboral = new Paragraph("Información Laboral:", TitulosLetra);


            var empresa = new Chunk("Empresa: ", FontFactory.GetFont("Arial", 15, color: new BaseColor(77,  77 ,77)));
            var empresaValor = new Chunk($"{Cache.Empresa} ", FontFactory.GetFont("Arial", 15, new BaseColor(0, 0, 0)));

            var actividadEconomica = new Chunk("Actividad económica: ", FontFactory.GetFont("Arial", 15, color: new BaseColor(77,  77 ,77)));
            var actividadEconomicaValor = new Chunk($"{Cache.ActividadEconomica} ", FontFactory.GetFont("Arial", 15, new BaseColor(0, 0, 0)));

            var tipoDeContrato = new Chunk("Tipo de contrato: ", FontFactory.GetFont("Arial", 15, color: new BaseColor(77,  77 ,77)));
            var tipoDeContratoValor = new Chunk($"{Cache.TipoDeContrato} ", FontFactory.GetFont("Arial", 15, new BaseColor(0, 0, 0)));

            var antLaboral = new Chunk("Ant. Laboral: ", FontFactory.GetFont("Arial", 15, color: new BaseColor(77,  77 ,77)));
            var antLaboralValor = new Chunk($"{Cache.AntLaboral} meses", FontFactory.GetFont("Arial", 15, new BaseColor(0, 0, 0)));



            var informacionFinancieraIngresos = new Paragraph("Información Financiera (Ingresos):", TitulosLetra);


            var ingresos = new Chunk("Ingresos: ", FontFactory.GetFont("Arial", 15, color: new BaseColor(77,  77 ,77)));
            var ingresosValor = new Chunk($"{string.Format("{0:#,0.00}", Cache.IngresoBasico)} ", FontFactory.GetFont("Arial", 15, new BaseColor(0, 0, 0)));

            var otrosIngresos = new Chunk("Otros ingresos: ", FontFactory.GetFont("Arial", 15, color: new BaseColor(77,  77 ,77)));
            var otrosIngresosValor = new Chunk($"{string.Format("{0:#,0.00}", Cache.OtrosIngresos)} ", FontFactory.GetFont("Arial", 15, new BaseColor(0, 0, 0)));

            var totalIngresos = new Chunk("Total ingresos: ", FontFactory.GetFont("Arial", 15, color: new BaseColor(77,  77 ,77)));
            var totalIngresosValor = new Chunk($"{string.Format("{0:#,0.00}", Cache.TotalIngresos)} ", FontFactory.GetFont("Arial", 15, new BaseColor(0, 0, 0)));


            var nombreAnalista = new Paragraph($"Nombre del analista: {Cache.NombreAnalista}", TitulosLetra);


            ////////
            //////
            ///
            //Desde aquí debe cambiar en caso de que sea un crédito de microcrédito

            //codigo para todos los créditos menos para micro




            //Adding Header row
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, letraBlanca)) { HorizontalAlignment = Element.ALIGN_MIDDLE };

                cell.BackgroundColor = new BaseColor(248, 100, 26);
                pdfTable.AddCell(cell);
            }
            //Adding DataRow
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {

                    pdfTable.AddCell((Convert.ToDouble(cell.Value)).ToString("N2"));


                }
            }
            //Exporting to PDF
            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            try
            {
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }
            }
            catch (Exception e)
            {

                using (formError = new FormError($"Error tipo: {e}"))
                {
                    formError.ShowDialog();
                }
            }

       
            using (FileStream stream = new FileStream(folderPath + "/" + Cache.Cedula + " " + Cache.Nombre + " " + Cache.Apellido + ".pdf", FileMode.Create))
            {
               

                Document document = new Document(PageSize.A2, 90f, 90f, 30f, 30f);
                PdfWriter.GetInstance(document, stream);
                document.Open();
                CrearEspacios(3, document);
                document.Add(Titulo);
                CrearEspacios(3, document);

                document.Add(informacionBasica);
                CrearEspacios(2, document);
                document.Add(cedula);
                document.Add(cedulaValor);
                document.Add(nombre);
                document.Add(nombrevalor);
                CrearEspacios(2, document);

                document.Add(informacionCredito);
                CrearEspacios(2, document);
                document.Add(monto);
                document.Add(montoValor);
                document.Add(plazo);
                document.Add(plazoValor);
                document.Add(tasa);
                document.Add(tasaValor);
                document.Add(Cuota);
                document.Add(cuotaValor);
                CrearEspacios(1, document);
                document.Add(periodicidad);
                document.Add(periodicidadValor);
                document.Add(garantia);
                document.Add(garantiaValor);
                document.Add(formaDePago);
                document.Add(formaDePagoValor);
                document.Add(tipoDeCredito);
                document.Add(tipoDeCreditoValor);
                CrearEspacios(2, document);

                document.Add(informacionGeneral);
                CrearEspacios(2, document);
                document.Add(fechaNacimiento);
                document.Add(fechaNacimientoValor);
                document.Add(estadiCivil);
                document.Add(estadiCivilValor);
                document.Add(profesion);
                document.Add(profesionValor);
                document.Add(edad);
                document.Add(edadValor);
                CrearEspacios(1, document);
                document.Add(cargo);
                document.Add(cargoValor);
                document.Add(personasACargo);
                document.Add(personasACargoValor);
                document.Add(ocupacion);
                document.Add(ocupacionValor);
                document.Add(tipovivienda);
                document.Add(tipoViviendaValor);
                CrearEspacios(2, document);

                document.Add(informacionLaboral);
                CrearEspacios(2, document);
                document.Add(empresa);
                document.Add(empresaValor);
                document.Add(actividadEconomica);
                document.Add(actividadEconomicaValor);
                document.Add(tipoDeContrato);
                document.Add(tipoDeContratoValor);
                document.Add(antLaboral);
                document.Add(antLaboralValor);
                CrearEspacios(2, document);

                document.Add(informacionFinancieraIngresos);
                CrearEspacios(2, document);
                document.Add(ingresos);
                document.Add(ingresosValor);
                document.Add(otrosIngresos);
                document.Add(otrosIngresosValor);
                document.Add(totalIngresos);
                document.Add(totalIngresosValor);
                CrearEspacios(2, document);

                //fin de hoja según el tipo de crédito
                if (Cache.TipoDeCredito != 4)   
                {
                    FinalHojaCreditosNOMicro(document);
                }
                else
                {
                    FinalHojaCreditosMICRO(document);
                }

                CrearEspacios(3, document);
                document.Add(planDePAgo);
                CrearEspacios(2, document);
                document.Add(pdfTable);
                CrearEspacios(3, document);
                AplicarCodeudor(document);
                document.Add(nombreAnalista);
                document.Close();
                stream.Close();
            }



        } 

        private void CrearEspacios(int cantidad, Document document)
        {
            for (int i = 0; i < cantidad; i++)
            {
                document.Add(new Paragraph("\n"));
            }
        }
        private string ValidarTipoDeCredito()
        {
            if (Cache.TipoDeCredito == 1) return "Consumo";
            else if (Cache.TipoDeCredito == 2) return "Comercial";
            else if (Cache.TipoDeCredito == 3) return "Vivienda";
            else return "Microcrédito";
        }

        private void FinalHojaCreditosNOMicro(Document document)
        {
            var letraBlanca = FontFactory.GetFont("Arial", 15);
            letraBlanca.SetColor(255, 255, 255);

            var TitulosLetra = FontFactory.GetFont("Arial", 15, iTextSharp.text.Font.BOLD);
            TitulosLetra.SetColor(248, 100, 26);

            var informacionFinancieraEgresos = new Paragraph("Información Financiera (Egresos):", TitulosLetra);


            var deduccionesSeguridadSocial = new Chunk("Deducciones seguridad social: ", FontFactory.GetFont("Arial", 15, color: new BaseColor(77,  77 ,77)));
            var deduccionesSeguridadSocialValor = new Chunk($"{string.Format("{0:#,0.00}", Cache.DeduccionesDeSeguridadSocial)} ", FontFactory.GetFont("Arial", 15, new BaseColor(0, 0, 0)));

            var otrasDeduccionesColilla = new Chunk("otras deducciones de colilla: ", FontFactory.GetFont("Arial", 15, color: new BaseColor(77,  77 ,77)));
            var otrasDeduccionesColillaValor = new Chunk($"{string.Format("{0:#,0.00}", Cache.OtrasDeduccionesColilla)} ", FontFactory.GetFont("Arial", 15, new BaseColor(0, 0, 0)));

            var totalDeducciones = new Chunk("Total deducciones de colilla: ", FontFactory.GetFont("Arial", 15, color: new BaseColor(77,  77 ,77)));
            var totalDeduccionesValor = new Chunk($"{string.Format("{0:#,0.00}", Cache.DeduccionesColilla)} ", FontFactory.GetFont("Arial", 15, new BaseColor(0, 0, 0)));

            var cuotasACancelar = new Chunk("Cuotas a cancelar: ", FontFactory.GetFont("Arial", 15, color: new BaseColor(77,  77 ,77)));
            var cuotasACancelarValor = new Chunk($"{string.Format("{0:#,0.00}", Cache.CuotasACancelar)} ", FontFactory.GetFont("Arial", 15, new BaseColor(0, 0, 0)));

            var estimacionCupoRotativo = new Chunk("Estimación Cupo Rotativo: ", FontFactory.GetFont("Arial", 15, color: new BaseColor(77,  77 ,77)));
            var estimacionCupoRotativoValor = new Chunk($"{string.Format("{0:#,0.00}", Cache.EstimacionCupoRotativo)} ", FontFactory.GetFont("Arial", 15, new BaseColor(0, 0, 0)));

            var valorCuotaLibranza = new Chunk("Valor cuota libranza: ", FontFactory.GetFont("Arial", 15, color: new BaseColor(77,  77 ,77)));
            var valorCuotaLibranzaValor = new Chunk($"{string.Format("{0:#,0.00}", Cache.ValorCuotaLibranza)} ", FontFactory.GetFont("Arial", 15, new BaseColor(0, 0, 0)));

            var cuotaCreditoCancelarNomina = new Chunk("Cuota de crédito a cancelar por nómina: ", FontFactory.GetFont("Arial", 15, color: new BaseColor(77,  77 ,77)));
            var cuotaCreditoCancelarNominaValor = new Chunk($"{string.Format("{0:#,0.00}", Cache.CuotasDeCreditoACancelarPorNomina)} ", FontFactory.GetFont("Arial", 15, new BaseColor(0, 0, 0)));

            var estimacionTarjetasCredito = new Chunk("Estimación tarjetas de crédito: ", FontFactory.GetFont("Arial", 15, color: new BaseColor(77,  77 ,77)));
            var estimacionTarjetasCreditoValor = new Chunk($"{string.Format("{0:#,0.00}", Cache.EstimacionTarjetasDeCredito)} ", FontFactory.GetFont("Arial", 15, new BaseColor(0, 0, 0)));

            var cuotaCentralesDeRiesgo = new Chunk("Cuota centrales de riesgo: ", FontFactory.GetFont("Arial", 15, color: new BaseColor(77,  77 ,77)));
            var cuotaCentralesDeRiesgoValor = new Chunk($"{string.Format("{0:#,0.00}", Cache.CuotaCentrales)} ", FontFactory.GetFont("Arial", 15, new BaseColor(0, 0, 0)));


            var calificacionSolicitante = new Paragraph("Calificación Del Solicitante:", TitulosLetra);


            var score = new Chunk("Score: ", FontFactory.GetFont("Arial", 15, color: new BaseColor(77,  77 ,77)));
            var scoreValor = new Chunk($"{string.Format("{0:#,0.0}", Cache.Score)} ", FontFactory.GetFont("Arial", 15, new BaseColor(0, 0, 0)));

            var calificacion = new Chunk("Calificación: ", FontFactory.GetFont("Arial", 15, color: new BaseColor(77,  77 ,77)));
            var calificacionValor = new Chunk($"{Cache.Calificacion} ", FontFactory.GetFont("Arial", 15, new BaseColor(0, 0, 0)));

            var afectacionColilla = new Chunk("Afectación colilla: ", FontFactory.GetFont("Arial", 15, color: new BaseColor(77,  77 ,77)));
            var afectacionColillaValor = new Chunk($"{ Cache.AfectacionColilla.ToString("P2")} ", FontFactory.GetFont("Arial", 15, new BaseColor(0, 0, 0)));

            var endeudamientoGlobal = new Chunk("Endeudamiento global: ", FontFactory.GetFont("Arial", 15, color: new BaseColor(77,  77 ,77)));
            var endeudamientoGlobalValor = new Chunk($"{Cache.EndeudamientoGlobal.ToString("P2")} ", FontFactory.GetFont("Arial", 15, new BaseColor(0, 0, 0)));

            var disponible = new Chunk("Disponible: ", FontFactory.GetFont("Arial", 15, color: new BaseColor(77,  77 ,77)));
            var disponibleValor = new Chunk($"{string.Format("{0:#,0.00}", Cache.Disponible)} ", FontFactory.GetFont("Arial", 15, new BaseColor(0, 0, 0)));

            var leyLibranza = new Chunk("Ley de libranza: ", FontFactory.GetFont("Arial", 15, color: new BaseColor(77,  77 ,77)));
            var leyLibranzaValor = new Chunk($"{Cache.AplicaLeyLibranza} ", FontFactory.GetFont("Arial", 15, new BaseColor(0, 0, 0)));

            var totalMoras = new Chunk("Total moras: ", FontFactory.GetFont("Arial", 15, color: new BaseColor(77,  77 ,77)));
            var totalMorasValor = new Chunk($"{Cache.ComportamientoDePagos} ", FontFactory.GetFont("Arial", 15, new BaseColor(0, 0, 0)));


            var cumplimientoPoliticasTitulo = new Paragraph("Cumplimiento De Políticas:", TitulosLetra);
            var cumplimientoPoliticasValor = new Chunk($"{Cache.CumplimientoDePoliticias} ", FontFactory.GetFont("Arial", 15, new BaseColor(0, 0, 0)));


            var criterioAnalistaTitulo = new Paragraph("Criterio del analista:", TitulosLetra);
            var criterioAnalistaValor = new Chunk($"{Cache.CriterioDelAnalista} ", FontFactory.GetFont("Arial", 15, new BaseColor(0, 0, 0)));


            




            document.Add(informacionFinancieraEgresos);
            CrearEspacios(2, document);
            document.Add(deduccionesSeguridadSocial);
            document.Add(deduccionesSeguridadSocialValor);
            document.Add(otrasDeduccionesColilla);
            document.Add(otrasDeduccionesColillaValor);
            document.Add(totalDeducciones);
            document.Add(totalDeduccionesValor);
            CrearEspacios(1, document);
            document.Add(cuotasACancelar);
            document.Add(cuotasACancelarValor);
            document.Add(estimacionCupoRotativo);
            document.Add(estimacionCupoRotativoValor);
            CrearEspacios(1, document);
            document.Add(valorCuotaLibranza);
            document.Add(valorCuotaLibranzaValor);
            document.Add(cuotaCreditoCancelarNomina);
            document.Add(cuotaCreditoCancelarNominaValor);
            CrearEspacios(1, document);
            document.Add(estimacionTarjetasCredito);
            document.Add(estimacionTarjetasCreditoValor);
            document.Add(cuotaCentralesDeRiesgo);
            document.Add(cuotaCentralesDeRiesgoValor);
            CrearEspacios(2, document);

            document.Add(calificacionSolicitante);
            CrearEspacios(2, document);
            document.Add(score);
            document.Add(scoreValor);
            document.Add(calificacion);
            document.Add(calificacionValor);
            document.Add(afectacionColilla);
            document.Add(afectacionColillaValor);
            CrearEspacios(1, document);
            document.Add(endeudamientoGlobal);
            document.Add(endeudamientoGlobalValor);
            document.Add(disponible);
            document.Add(disponibleValor);
            document.Add(leyLibranza);
            document.Add(leyLibranzaValor);
            document.Add(totalMoras);
            document.Add(totalMorasValor);
            CrearEspacios(2, document);

            document.Add(cumplimientoPoliticasTitulo);
            CrearEspacios(2, document);
            document.Add(cumplimientoPoliticasValor);
            CrearEspacios(2, document);

            document.Add(criterioAnalistaTitulo);
            CrearEspacios(2, document);
            document.Add(criterioAnalistaValor);
            CrearEspacios(9, document);

           
        }

        private void FinalHojaCreditosMICRO(Document document)
        {
            var letraBlanca = FontFactory.GetFont("Arial", 15);
            letraBlanca.SetColor(255, 255, 255);

            var TitulosLetra = FontFactory.GetFont("Arial", 15, iTextSharp.text.Font.BOLD);
            TitulosLetra.SetColor(248, 100, 26);


            var estadoDeResultados = new Paragraph("Estado De Resultados:", TitulosLetra);


            var ventas = new Chunk("Ventas: ", FontFactory.GetFont("Arial", 15, color: new BaseColor(77, 77, 77)));
            var ventasValor = new Chunk($"{string.Format("{0:#,0.00}", Cache.VentasMicro)} ", FontFactory.GetFont("Arial", 15, new BaseColor(0, 0, 0)));

            var costoDeVentas = new Chunk("Costo de ventas: ", FontFactory.GetFont("Arial", 15, color: new BaseColor(77, 77, 77)));
            var costoDeVentasValor = new Chunk($"{string.Format("{0:#,0.00}", Cache.CostosDeVentasMicro)} ", FontFactory.GetFont("Arial", 15, new BaseColor(0, 0, 0)));

            var gastosDelNegocio = new Chunk("Gastos del negocio: ", FontFactory.GetFont("Arial", 15, color: new BaseColor(77, 77, 77)));
            var gastosDelNegocioValor = new Chunk($"{string.Format("{0:#,0.00}", Cache.GastosDelNegocioMicro)} ", FontFactory.GetFont("Arial", 15, new BaseColor(0, 0, 0)));

            var ingresosFamiliares = new Chunk("Ingresos familiares: ", FontFactory.GetFont("Arial", 15, color: new BaseColor(77, 77, 77)));
            var ingresosFamiliaresValor = new Chunk($"{string.Format("{0:#,0.00}", Cache.IngresosFamiliarYOtrosMicro)} ", FontFactory.GetFont("Arial", 15, new BaseColor(0, 0, 0)));

            var gastosFamiliares = new Chunk("Gastos familiares: ", FontFactory.GetFont("Arial", 15, color: new BaseColor(77, 77, 77)));
            var gastosFamiliaresValor = new Chunk($"{string.Format("{0:#,0.00}", Cache.GastosFamiliaresYOtrosMicro)} ", FontFactory.GetFont("Arial", 15, new BaseColor(0, 0, 0)));

            var cuotaCreditoRefinanciar = new Chunk("Cuota del crédito a refinanciar: ", FontFactory.GetFont("Arial", 15, color: new BaseColor(77, 77, 77)));
            var cuotaCreditoRefinanciarValor = new Chunk($"{string.Format("{0:#,0.00}", Cache.CuotaDelCreditoARefinancierMicro)} ", FontFactory.GetFont("Arial", 15, new BaseColor(0, 0, 0)));

            var cuotaCentralesDeRiesgo = new Chunk("Cuota centrales de riesgo: ", FontFactory.GetFont("Arial", 15, color: new BaseColor(77, 77, 77)));
            var cuotaCentralesDeRiesgoValor = new Chunk($"{string.Format("{0:#,0.00}", Cache.CuotaCentralesDeRiesgoMicro)} ", FontFactory.GetFont("Arial", 15, new BaseColor(0, 0, 0)));

            var utilidadOPerdidaOperativa = new Chunk("Utilidad o pérdida operativa: ", FontFactory.GetFont("Arial", 15, color: new BaseColor(77, 77, 77)));
            var utilidadOPerdidaOperativaValor = new Chunk($"{string.Format("{0:#,0.00}", Cache.UtilidadOPerdidaOperativaMicro)} ", FontFactory.GetFont("Arial", 15, new BaseColor(0, 0, 0)));

            var utilidadBruta = new Chunk("Utilidad bruta: ", FontFactory.GetFont("Arial", 15, color: new BaseColor(77, 77, 77)));
            var utilidadBrutaValor = new Chunk($"{string.Format("{0:#,0.00}", Cache.UtilidadBrutaMicro)} ", FontFactory.GetFont("Arial", 15, new BaseColor(0, 0, 0)));

            var utilidadDisponible = new Chunk("Utilidad disponible: ", FontFactory.GetFont("Arial", 15, color: new BaseColor(77, 77, 77)));
            var utilidadDisponibleValor = new Chunk($"{string.Format("{0:#,0.00}", Cache.UtildiadDisponibleMicro)} ", FontFactory.GetFont("Arial", 15, new BaseColor(0, 0, 0)));

            var utilidadOPerdidaNeta = new Chunk("Utilidad o pérdida neta: ", FontFactory.GetFont("Arial", 15, color: new BaseColor(77, 77, 77)));
            var utilidadOPerdidaNetaValor = new Chunk($"{string.Format("{0:#,0.00}", Cache.UtilidadOPerdiaNeta)} ", FontFactory.GetFont("Arial", 15, new BaseColor(0, 0, 0)));



            var capacidadDePagoDeudor = new Paragraph("Capacidad De Pago Deudor:", TitulosLetra);


            var margenConfianza = new Chunk("Margen de confianza: ", FontFactory.GetFont("Arial", 15, color: new BaseColor(77, 77, 77)));
            var margenConfianzaValor = new Chunk($"{Cache.MargenDeConfianzaMicro.ToString("P2")} ", FontFactory.GetFont("Arial", 15, new BaseColor(0, 0, 0)));

            var capacidadDePagoConCuota = new Chunk("Capacidad de pago con cuota: ", FontFactory.GetFont("Arial", 15, color: new BaseColor(77, 77, 77)));
            var capacidadDePagoConCuotaValor = new Chunk($"{Cache.CapaciodadDePagoConCuotaMicro.ToString("P2")} ", FontFactory.GetFont("Arial", 15, new BaseColor(0, 0, 0)));

            var endeudamientoDirecto = new Chunk("Endeudamiento directo: ", FontFactory.GetFont("Arial", 15, color: new BaseColor(77, 77, 77)));
            var endeudamientoDirectoValor = new Chunk($"{Cache.EndeudamientoDirectodeudorMicro.ToString("P2")} ", FontFactory.GetFont("Arial", 15, new BaseColor(0, 0, 0)));


            var capacidadDePagoCodeudor = new Paragraph("Capacidad De Pago Codeudor:", TitulosLetra);


            var ingresosCodeudor = new Chunk("Ingresos del codeudor: ", FontFactory.GetFont("Arial", 15, color: new BaseColor(77, 77, 77)));
            var ingresosCodeudorValor = new Chunk($"{string.Format("{0:#,0.00}", Cache.IngresosCodeudor)} ", FontFactory.GetFont("Arial", 15, new BaseColor(0, 0, 0)));

            var egresosCodeudor = new Chunk("Egresos del codeudor: ", FontFactory.GetFont("Arial", 15, color: new BaseColor(77, 77, 77)));
            var egresosCodeudorValor = new Chunk($"{string.Format("{0:#,0.00}", Cache.EgresosCodeudorMicro)} ", FontFactory.GetFont("Arial", 15, new BaseColor(0, 0, 0)));

            var endeudamientoDirectoCodeudor = new Chunk("Endeudamiento directo: ", FontFactory.GetFont("Arial", 15, color: new BaseColor(77, 77, 77)));
            var endeudamientoDirectoCodeudorValor = new Chunk($"{Cache.EndeudamientoDirectoCodeudorMicro.ToString("P2")} ", FontFactory.GetFont("Arial", 15, new BaseColor(0, 0, 0)));


            var calificacionSolicitante = new Paragraph("Calificación Del Solicitante:", TitulosLetra);


            var totalMoras = new Chunk("Total moras: ", FontFactory.GetFont("Arial", 15, color: new BaseColor(77, 77, 77)));
            var totalMorasValor = new Chunk($"{Cache.ComportamientoDePagos} ", FontFactory.GetFont("Arial", 15, new BaseColor(0, 0, 0)));

            var calificacion = new Chunk("Calificación: ", FontFactory.GetFont("Arial", 15, color: new BaseColor(77, 77, 77)));
            var calificacionValor = new Chunk($"{Cache.Calificacion} ", FontFactory.GetFont("Arial", 15, new BaseColor(0, 0, 0)));

            var score = new Chunk("Score: ", FontFactory.GetFont("Arial", 15, color: new BaseColor(77, 77, 77)));
            var scoreValor = new Chunk($"{string.Format("{0:#,0.0}", Cache.Score)} ", FontFactory.GetFont("Arial", 15, new BaseColor(0, 0, 0)));

            var destinoCredito = new Chunk("Destino del crédito: ", FontFactory.GetFont("Arial", 15, color: new BaseColor(77, 77, 77)));
            var destinoCreditoValor = new Chunk($"{Cache.DestinoDelCredito} ", FontFactory.GetFont("Arial", 15, new BaseColor(0, 0, 0)));


            var cumplimientoPoliticasTitulo = new Paragraph("Cumplimiento De Políticas:", TitulosLetra);
            var cumplimientoPoliticasValor = new Chunk($"{Cache.CumplimientoDePoliticias} ", FontFactory.GetFont("Arial", 15, new BaseColor(0, 0, 0)));


            var criterioAnalistaTitulo = new Paragraph("Criterio del analista:", TitulosLetra);
            var criterioAnalistaValor = new Chunk($"{Cache.CriterioDelAnalista} ", FontFactory.GetFont("Arial", 15, new BaseColor(0, 0, 0)));




            document.Add(estadoDeResultados);
            CrearEspacios(2, document);
            document.Add(ventas);
            document.Add(ventasValor);
            document.Add(costoDeVentas);
            document.Add(costoDeVentasValor);
            document.Add(gastosDelNegocio);
            document.Add(gastosDelNegocioValor);
            document.Add(ingresosFamiliares);
            document.Add(ingresosFamiliaresValor);
            CrearEspacios(1, document);
            document.Add(gastosFamiliares);
            document.Add(gastosFamiliaresValor);
            document.Add(cuotaCreditoRefinanciar);
            document.Add(cuotaCreditoRefinanciarValor);
            document.Add(cuotaCentralesDeRiesgo);
            document.Add(cuotaCentralesDeRiesgoValor);
            CrearEspacios(1, document);
            document.Add(utilidadOPerdidaOperativa);
            document.Add(utilidadOPerdidaOperativaValor);
            document.Add(utilidadBruta);
            document.Add(utilidadBrutaValor);
            document.Add(utilidadDisponible);
            document.Add(utilidadDisponibleValor);
            document.Add(utilidadOPerdidaNeta);
            document.Add(utilidadOPerdidaNetaValor);
            CrearEspacios(2, document);

            document.Add(capacidadDePagoDeudor);
            CrearEspacios(2, document);
            document.Add(margenConfianza);
            document.Add(margenConfianzaValor);
            document.Add(capacidadDePagoConCuota);
            document.Add(capacidadDePagoConCuotaValor);
            document.Add(endeudamientoDirecto);
            document.Add(endeudamientoDirectoValor);
            CrearEspacios(2, document);

            document.Add(capacidadDePagoCodeudor);
            CrearEspacios(2, document);
            document.Add(ingresosCodeudor);
            document.Add(ingresosCodeudorValor);
            document.Add(egresosCodeudor);
            document.Add(egresosCodeudorValor);
            document.Add(endeudamientoDirectoCodeudor);
            document.Add(endeudamientoDirectoCodeudorValor);
            CrearEspacios(2, document);

            document.Add(calificacionSolicitante);
            CrearEspacios(2, document);
            document.Add(score);
            document.Add(scoreValor);
            document.Add(calificacion);
            document.Add(calificacionValor);
            document.Add(totalMoras);
            document.Add(totalMorasValor);
            document.Add(destinoCredito);
            document.Add(destinoCreditoValor);
            CrearEspacios(2, document);

            document.Add(cumplimientoPoliticasTitulo);
            CrearEspacios(2, document);
            document.Add(cumplimientoPoliticasValor);
            CrearEspacios(2, document);

            document.Add(criterioAnalistaTitulo);
            CrearEspacios(2, document);
            document.Add(criterioAnalistaValor);
            CrearEspacios(2, document);

        }

        private void AplicarCodeudor(Document document)
        {
            if (Cache.TipoDeCredito != 4 && Cache.AplicaCodeudor)
            {

          

                var letraBlanca = FontFactory.GetFont("Arial", 15);
                letraBlanca.SetColor(255, 255, 255);

                var TitulosLetra = FontFactory.GetFont("Arial", 15, iTextSharp.text.Font.BOLD);
                TitulosLetra.SetColor(248, 100, 26);


                var Titulo = new Paragraph("CODEUDOR", TitulosLetra);
                Titulo.Alignment = Element.ALIGN_CENTER;


                var informacionFinanciera = new Paragraph("Información Financiera:", TitulosLetra);

                
                var ingresos = new Chunk("Ingresos: ", FontFactory.GetFont("Arial", 15, color: new BaseColor(77, 77, 77)));
                var ingresosValor = new Chunk($"{string.Format("{0:#,0.00}", Cache.IngresosCodeudor)} ", FontFactory.GetFont("Arial", 15, new BaseColor(0, 0, 0)));

                var otrosIngresos = new Chunk("Otros ingresos: ", FontFactory.GetFont("Arial", 15, color: new BaseColor(77, 77, 77)));
                var otrosIngresosValor = new Chunk($"{string.Format("{0:#,0.00}", Cache.OtrosIngresosCodeudor)} ", FontFactory.GetFont("Arial", 15, new BaseColor(0, 0, 0)));

                var totalIngresos = new Chunk("Total ingresos: ", FontFactory.GetFont("Arial", 15, color: new BaseColor(77, 77, 77)));
                var totalIngresosValor = new Chunk($"{string.Format("{0:#,0.00}", Cache.TotalIngresosCodeudor)} ", FontFactory.GetFont("Arial", 15, new BaseColor(0, 0, 0)));

                var vivienda = new Chunk("Tipo de vivienda: ", FontFactory.GetFont("Arial", 15, color: new BaseColor(77, 77, 77)));
                var viviendaValor = new Chunk($"{Cache.TipoDeViviendaCodeudor} ", FontFactory.GetFont("Arial", 15, new BaseColor(0, 0, 0)));



                var informacioEgresos = new Paragraph("Información Egresos:", TitulosLetra);


                var deduccionesSeguridadSocial = new Chunk("Deducciones Seguridad Social: ", FontFactory.GetFont("Arial", 15, color: new BaseColor(77, 77, 77)));
                var deduccionesSeguridadSocialValor = new Chunk($"{string.Format("{0:#,0.00}", Cache.DeduccionesDeSeguridadSocialCodeudor)} ", FontFactory.GetFont("Arial", 15, new BaseColor(0, 0, 0)));

                var otrasDeducciones = new Chunk("Otras deducciones: ", FontFactory.GetFont("Arial", 15, color: new BaseColor(77, 77, 77)));
                var otrasDeduccionesValor = new Chunk($"{string.Format("{0:#,0.00}", Cache.OtrasDeduccionesColillaCodeudor)} ", FontFactory.GetFont("Arial", 15, new BaseColor(0, 0, 0)));

                var totalDeducciones = new Chunk("Total deducciones: ", FontFactory.GetFont("Arial", 15, color: new BaseColor(77, 77, 77)));
                var totalDeduccionesValor = new Chunk($"{string.Format("{0:#,0.00}", Cache.TotalDeduccionesColillaCodeudor)} ", FontFactory.GetFont("Arial", 15, new BaseColor(0, 0, 0)));

                var cuotaCentrales = new Chunk("Cuota Centrales: ", FontFactory.GetFont("Arial", 15, color: new BaseColor(77, 77, 77)));
                var cuotaCentralesValor = new Chunk($"{string.Format("{0:#,0.00}", Cache.CuotasCentralesDeRiesgoCodeudor)} ", FontFactory.GetFont("Arial", 15, new BaseColor(0, 0, 0)));

                var valorCuotaLibranza = new Chunk("Valor cuota libranza: ", FontFactory.GetFont("Arial", 15, color: new BaseColor(77, 77, 77)));
                var valorCuotaLibranzaValor = new Chunk($"{string.Format("{0:#,0.00}", Cache.ValorCuotaLibranzaCodeudor)} ", FontFactory.GetFont("Arial", 15, new BaseColor(0, 0, 0)));

                var cuotasACancelar = new Chunk("Cuotas a cancelar: ", FontFactory.GetFont("Arial", 15, color: new BaseColor(77, 77, 77)));
                var cuotasACancelarValor = new Chunk($"{string.Format("{0:#,0.00}", Cache.CuotasACancelarCodeudor)} ", FontFactory.GetFont("Arial", 15, new BaseColor(0, 0, 0)));


                var indicadoresCapacidad = new Paragraph("Indicadores de capacidad:", TitulosLetra);


                var afectacionColilla = new Chunk("Afectación colilla: ", FontFactory.GetFont("Arial", 15, color: new BaseColor(77, 77, 77)));
                var afectacionColillaValor = new Chunk($"{ Cache.AfectacionColillaCodeudor.ToString("P2")} ", FontFactory.GetFont("Arial", 15, new BaseColor(0, 0, 0)));

                var endeudamientoGlobal = new Chunk("Endeudamiento global: ", FontFactory.GetFont("Arial", 15, color: new BaseColor(77, 77, 77)));
                var endeudamientoGlobalValor = new Chunk($"{Cache.EndeudamientoGlobalCodeudor.ToString("P2")} ", FontFactory.GetFont("Arial", 15, new BaseColor(0, 0, 0)));

                var disponible = new Chunk("Disponible: ", FontFactory.GetFont("Arial", 15, color: new BaseColor(77, 77, 77)));
                var disponibleValor = new Chunk($"{string.Format("{0:#,0.00}", Cache.DisponibleCodeudor)} ", FontFactory.GetFont("Arial", 15, new BaseColor(0, 0, 0)));

                var leyLibranza = new Chunk("Ley de libranza: ", FontFactory.GetFont("Arial", 15, color: new BaseColor(77, 77, 77)));
                var leyLibranzaValor = new Chunk($"{Cache.AplicaLeyLibranzaCodeduor} ", FontFactory.GetFont("Arial", 15, new BaseColor(0, 0, 0)));

                CrearEspacios(3, document);
                document.Add(Titulo);
                CrearEspacios(2, document);

                document.Add(informacionFinanciera);
                CrearEspacios(2, document);
                document.Add(ingresos);
                document.Add(ingresosValor);
                document.Add(otrosIngresos);
                document.Add(otrosIngresosValor);
                document.Add(totalIngresos);
                document.Add(totalIngresosValor);
                document.Add(vivienda);
                document.Add(viviendaValor);
                CrearEspacios(2, document);

                document.Add(informacioEgresos);
                CrearEspacios(2, document);
                document.Add(deduccionesSeguridadSocial);
                document.Add(deduccionesSeguridadSocialValor);
                document.Add(otrasDeducciones);
                document.Add(otrasDeduccionesValor);
                document.Add(totalDeducciones);
                document.Add(totalDeduccionesValor);
                CrearEspacios(1, document);
                document.Add(cuotaCentrales);
                document.Add(cuotaCentralesValor);
                document.Add(valorCuotaLibranza);
                document.Add(valorCuotaLibranzaValor);
                document.Add(cuotasACancelar);
                document.Add(cuotasACancelarValor);
                CrearEspacios(2, document);

                document.Add(indicadoresCapacidad);
                CrearEspacios(2, document);
                document.Add(afectacionColilla);
                document.Add(afectacionColillaValor);
                document.Add(endeudamientoGlobal);
                document.Add(endeudamientoGlobalValor);
                document.Add(disponible);
                document.Add(disponibleValor);
                document.Add(leyLibranza);
                document.Add(leyLibranzaValor);
                CrearEspacios(2, document);

            }
        }
    }
}

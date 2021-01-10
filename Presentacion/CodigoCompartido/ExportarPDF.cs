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

namespace Presentacion.CodigoCompartido
{
    public class ExportarPDF
    {
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

            var TitulosLetra = FontFactory.GetFont("Arial", 15);
            TitulosLetra.SetColor(248, 100, 26);


            //Añadir titulo del plan de pagos

            var Titulo = new  Paragraph("Análisis de crédito", TitulosLetra);
            Titulo.Alignment = Element.ALIGN_CENTER;


            //cedula
            var cedula = new Chunk("Cédula: ", FontFactory.GetFont("Arial", 15,color: new BaseColor(248, 100, 26)));
            var cedulaValor = new Chunk($"{string.Format("{0:#,0}",Convert.ToDouble(Cache.Cedula))} ", FontFactory.GetFont("Arial", 15, new BaseColor(0, 0, 0)));

            //Tabla

            var tablaPrueba = new PdfPTable(4);
            tablaPrueba.AddCell(new Paragraph("Análisis de crédito", TitulosLetra));


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

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            using (FileStream stream = new FileStream(folderPath + "/Ejemplo.pdf", FileMode.Create))
            {

                Document document = new Document(PageSize.A2, 90f, 90f, 30f, 30f);
                PdfWriter.GetInstance(document, stream);
                document.Open();
                CrearEspacios(3, document);
                document.Add(Titulo);
                CrearEspacios(3, document);
                document.Add(cedula);
                document.Add(cedulaValor);
                CrearEspacios(3, document);
                document.Add(tablaPrueba);
                CrearEspacios(3, document);
                document.Add(pdfTable);
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
    }
}

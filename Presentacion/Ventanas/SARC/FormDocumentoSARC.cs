using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using Presentacion.CodigoCompartido;

namespace Presentacion.Ventanas.SARC
{
    public partial class FormDocumentoSARC : Form
    {
        public FormDocumentoSARC()
        {
            InitializeComponent();
        }

        private void FormDocumentoSARC_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.0;
        }

        private async System.Threading.Tasks.Task ImportarArchivoWord()
        {

            await System.Threading.Tasks.Task.Run(() =>
            {

                string ruta = Directory.GetCurrentDirectory();
                string rutaCompleta = ruta + @"\doc.docx";
                try
                {

                    if (this.btnImportar.InvokeRequired)
                    {
                        this.btnImportar.Invoke(new Action(() => this.btnImportar.Enabled = false));
                        this.btnImportar.Invoke(new Action(() => this.btnImportar.Text = "Importando, espere un momento ..."));
                    }

                    Microsoft.Office.Interop.Word.Application wordObject = new Microsoft.Office.Interop.Word.Application();
                    object File = rutaCompleta; //this is the path
                    object nullobject = System.Reflection.Missing.Value; Microsoft.Office.Interop.Word.Application wordobject = new Microsoft.Office.Interop.Word.Application();
                    wordobject.DisplayAlerts = Microsoft.Office.Interop.Word.WdAlertLevel.wdAlertsNone; Microsoft.Office.Interop.Word._Document docs = wordObject.Documents.Open(ref File, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject); docs.ActiveWindow.Selection.WholeStory();
                    docs.ActiveWindow.Selection.Copy();
                    if (this.richTextBox1.InvokeRequired)
                    {
                        this.btnImportar.Invoke(new Action(() => this.richTextBox1.Paste()));
                        this.btnImportar.Invoke(new Action(() => this.richTextBox1.Select(0, 0)));
                    }

                    docs.Close(ref nullobject, ref nullobject, ref nullobject);
                    wordobject.Quit(ref nullobject, ref nullobject, ref nullobject);


                    if (this.btnImportar.InvokeRequired)
                    {
                        this.btnImportar.Invoke(new Action(() => this.btnImportar.Enabled = false));
                        this.btnImportar.Invoke(new Action(() => this.btnImportar.Text = "Importar documento SARC"));
                    }

                }
                catch (Exception e)
                {

                    MessageBox.Show($"No se encontró archivo en la ruta: {rutaCompleta} o error tipo: {e}");
                }
            });

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await ImportarArchivoWord();

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timerForm_Tick(object sender, EventArgs e)
        {
            CodigoComun.Timer(this,timerForm);
        }

        private void FormDocumentoSARC_MouseDown(object sender, MouseEventArgs e)
        {
            this.Opacity = 0.6;
        }

        private void FormDocumentoSARC_MouseUp(object sender, MouseEventArgs e)
        {
            this.Opacity = 1;
        }

        private void FormDocumentoSARC_ResizeBegin(object sender, EventArgs e)
        {
            this.Opacity = 0.6;
        }

        private void FormDocumentoSARC_ResizeEnd(object sender, EventArgs e)
        {
            this.Opacity = 1;
        }

        private void FormDocumentoSARC_DragLeave(object sender, EventArgs e)
        {
            this.Opacity = 1;
        }

        private void FormDocumentoSARC_DragEnter(object sender, DragEventArgs e)
        {
            this.Opacity = 0.6;
        }
    }
}

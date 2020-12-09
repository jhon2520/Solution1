using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Presentacion.Ventanas.Documentacion
{
    public partial class FormDocumento : Form
    {
        public FormDocumento()
        {
            InitializeComponent();
        }

        private void btnRuta_Click(object sender, EventArgs e)
        {
            //string ruta = System.IO.Directory.GetCurrentDirectory(); //Environment.GetFolderPath(Environment.SpecialFolder.);
            //this.tbxRuta.Text = ruta;
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            //OpenFileDialog op = new OpenFileDialog();
        
            //if(op.ShowDialog() == DialogResult.OK)
            //{
            //    axAcroPDF1.src = op.FileName;
            //}

            string ruta = System.IO.Directory.GetCurrentDirectory();
            axAcroPDF1.src = ruta + @"\ley.pdf";
            //C: \Users\Jhon Romero\source\repos\Solution1\Presentacion\bin\Debug
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Ventanas.Calculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            
            try
            {
                InitializeComponent();
                ControladorFormCalculadora controladorFormCalculadora = new ControladorFormCalculadora(this);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }
    }
}

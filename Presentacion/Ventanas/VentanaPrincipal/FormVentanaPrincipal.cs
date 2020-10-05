using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Ventanas.VentanaPrincipal
{
    public partial class FormVentanaPrincipal : Form
    {
        public FormVentanaPrincipal()
        {
            InitializeComponent();
            ControladorFormVentanaPrincipal controladorFormVentanaPrincipal = new ControladorFormVentanaPrincipal(this);
        }

        private void btnComercial_Click(object sender, EventArgs e)
        {

        }
    }
}

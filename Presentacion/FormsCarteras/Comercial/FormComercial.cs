using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.FormsCarteras.Comercial
{
    public partial class FormComercial : Form
    {
        public FormComercial()
        {
            InitializeComponent();
            ControladorFormComercial controladorFormComercial = new ControladorFormComercial(this);
        }

        private void tbxMonto_TextChanged(object sender, EventArgs e)
        {

        }

        private void contadorPlazo_ValueChanged(object sender, EventArgs e)
        {

        }

        private void contadorTasa_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbxGarantia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

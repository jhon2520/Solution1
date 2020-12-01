using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.FormsCarteras.Comercial.VariablesAnalisisComercial
{
    public partial class FormVariablesAnalisisComercial : Form
    {
        public FormVariablesAnalisisComercial()
        {
            InitializeComponent();
            ControladorformVariablesAnalisisComercial controladorFormVariablesAnalisisComercial = new ControladorformVariablesAnalisisComercial(this);
        }
    }
}

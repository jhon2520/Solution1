using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.FormsCarteras.Consumo.VarialblesAnalisis
{
    public partial class FormVariablesAnalisisConsumo : Form
    {
        public FormVariablesAnalisisConsumo()
        {
            InitializeComponent();
            ControladorFormVariablesAnalisisConsumo controladorFormVariablesAnalisis = new ControladorFormVariablesAnalisisConsumo(this);
        }
    }
}

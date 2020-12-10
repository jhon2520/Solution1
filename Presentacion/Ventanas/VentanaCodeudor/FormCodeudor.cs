using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Ventanas.VentanaCodeudor
{
    public partial class FormCodeudor : Form
    {
        public FormCodeudor()
        {
            InitializeComponent();
            ControladorFormCodeudor controladorFormCodeudor = new ControladorFormCodeudor(this);
        }
    }
}

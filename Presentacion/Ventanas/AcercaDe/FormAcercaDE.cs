using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Ventanas.AcercaDe
{
    public partial class FormAcercaDE : Form
    {
        public FormAcercaDE()
        {
            InitializeComponent();
            ControladorFormAcercaDE formAcercaDE = new ControladorFormAcercaDE(this);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Ventanas.Salario
{
    public partial class FormSalario : Form
    {
        public FormSalario()
        {
            InitializeComponent();
            ControladorFormSalario controladorFormSalario = new ControladorFormSalario(this);
        }
    }
}

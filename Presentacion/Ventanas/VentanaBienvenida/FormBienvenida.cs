using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Ventanas.VentanaBienvenida
{
    public partial class FormBienvenida : Form
    {
        public FormBienvenida()
        {
            InitializeComponent();
            ControladorFormBienvenida controladorFormBienvenida = new ControladorFormBienvenida(this);
        }
    }
}

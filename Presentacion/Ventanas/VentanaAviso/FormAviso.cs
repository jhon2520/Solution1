using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Ventanas.VentanaAviso
{
    public partial class FormAviso : Form
    {
        public FormAviso(string mensaje)
        {
            InitializeComponent();
            lblMensaje.Text = mensaje;
            ControladorFormAviso controladorFormAviso = new ControladorFormAviso(this);
        }

    }
}

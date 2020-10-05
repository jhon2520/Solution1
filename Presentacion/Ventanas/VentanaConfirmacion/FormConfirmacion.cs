using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Ventanas.VentanaConfirmacion
{
    public partial class FormConfirmacion : Form
    {
        public FormConfirmacion(string mensaje)
        {
            InitializeComponent();
            lblMensaje.Text = mensaje;
            ControladorFormConfirmacion controladorFormConfirmacion = new ControladorFormConfirmacion(this);
        }
    }
}

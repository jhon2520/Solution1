﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Ventanas.VentanaError
{
    public partial class FormError : Form
    {
        public FormError(string mensaje)
        {
            InitializeComponent();
            lblMensaje.Text = mensaje;
            ControladorFormError controladorFormError = new ControladorFormError(this);
        }
    }
}

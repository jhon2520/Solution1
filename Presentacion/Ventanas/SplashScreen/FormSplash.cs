﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Ventanas.SplashScreen
{
    public partial class FormSplash : Form
    {
        public FormSplash(string mensaje)
        {
            InitializeComponent();
            ControladorFormSplash controladorFormSplash = new ControladorFormSplash(this);
            this.lblMensaje.Text = mensaje;
        }
    }
}

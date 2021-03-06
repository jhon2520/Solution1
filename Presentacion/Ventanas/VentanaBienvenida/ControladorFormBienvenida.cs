﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentacion.CodigoCompartido;
using SoporteUsuario.CacheUsuario;
using Presentacion.Ventanas.VentanaAviso;
using Presentacion.Ventanas.VentanaError;
using Presentacion.Ventanas.VentanaConfirmacion;
using Presentacion.Ventanas.VentanaPrincipal;
using Presentacion.Ventanas.VentanaEmergente;
using System.Threading;
using Presentacion.Ventanas.SplashScreen;

namespace Presentacion.Ventanas.VentanaBienvenida
{
    public class ControladorFormBienvenida
    {
        private FormBienvenida formBienvenida;
        private FormError formError;
        private FormSplash formSplash;
        private FormConfirmacion formConfirmacion;
        private FormVentanaPrincipal formVentanaPrincipal;

        public ControladorFormBienvenida(FormBienvenida formBienvenida)
        {
            this.formBienvenida = formBienvenida;
            this.formBienvenida.Opacity = 0.0;
            this.formBienvenida.btnCerrar.Click += new EventHandler(CerrarForm);
            this.formBienvenida.btnMinimizar.Click += new EventHandler(MinimizarForm);
            this.formBienvenida.tbxNombre.Click += new EventHandler(CambiosTbx);
            this.formBienvenida.btnIngresar.Click += new EventHandler(Ingresar);
            this.formBienvenida.timerForm.Tick += new EventHandler(EfectoLogin);
            this.formBienvenida.pnlSuperior.MouseDown += new MouseEventHandler(VolverTransparente);
            this.formBienvenida.pnlSuperior.MouseUp += new MouseEventHandler(RetornarOpacidad);
            this.formBienvenida.Load += new EventHandler(CargarForm);
            this.formBienvenida.KeyDown += new KeyEventHandler(CerrarformShortCut);
            MensajesTooltip();
        }

        private void CerrarForm(object sender, EventArgs args)
        {
            formConfirmacion = new FormConfirmacion("¿Desea salir del simulador?");
            DialogResult resultado = formConfirmacion.ShowDialog();

            if(resultado == DialogResult.OK)
            {
                CodigoComun.BtnCerrar(this.formBienvenida);
            }
            
        }
        private void CargarForm(object sender, EventArgs args)
        {
            this.formBienvenida.btnIngresar.Focus();
        }

        private void MinimizarForm(object sender, EventArgs args)
        {
            CodigoComun.BtnMinimizar(this.formBienvenida);
        }

        private void CambiosTbx(object sender, EventArgs args)
        {
            CodigoComun.CambiosTbx(this.formBienvenida.tbxNombre, "Ingrese su nombre", 248, 100, 26);
        }

        private void Ingresar(object sender, EventArgs args)
        {
            if(this.formBienvenida.tbxNombre.Text != "Ingrese su nombre" && this.formBienvenida.tbxNombre.Text != string.Empty)
            { 
                Cache.NombreAnalista = this.formBienvenida.tbxNombre.Text;
                //formAviso = new FormAviso("Bienvenido, " + Cache.NombreAnalista + " al sistema de análisis de crédito SENA");
                //formAviso.ShowDialog();
                this.formBienvenida.Hide();
                formSplash = new FormSplash("Bienvenido: " + Cache.NombreAnalista);
                formSplash.lblMensaje.Left = (formSplash.Width - formSplash.lblMensaje.Width) / 2;
                formSplash.ShowDialog();
                formVentanaPrincipal = new FormVentanaPrincipal();
                formVentanaPrincipal.ShowDialog();
            }
            else
            {
         
                formError = new FormError("Ingrese su nombre si desea ingresar al simulador.");
                formError.ShowDialog();
            }
        }

        private void EfectoLogin(object sender, EventArgs args)
        {
            CodigoComun.Timer(this.formBienvenida, this.formBienvenida.timerForm);
        }
        private void VolverTransparente(object sender, EventArgs args)
        {
            this.formBienvenida.Opacity = 0.6;
        }
        private void RetornarOpacidad(object sender, EventArgs args)
        {
            this.formBienvenida.Opacity = 1;
        }
        private void MensajesTooltip()
        {
            this.formBienvenida.ttFormBienvenida.SetToolTip(this.formBienvenida.tbxNombre, "Ingrese el nombre del analista.");
            this.formBienvenida.ttFormBienvenida.SetToolTip(this.formBienvenida.btnIngresar, "Ingresar al sistema de análisis de crédito.");
            this.formBienvenida.ttFormBienvenida.SetToolTip(this.formBienvenida.btnCerrar, "Cerrar aplicación (esc).");
            this.formBienvenida.ttFormBienvenida.SetToolTip(this.formBienvenida.btnMinimizar, "Minimizar aplicación.");

        }

        private void CerrarformShortCut(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.formBienvenida.btnCerrar.PerformClick();
            }
        }
    }
}

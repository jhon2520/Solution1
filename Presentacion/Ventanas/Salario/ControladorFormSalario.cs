﻿using Presentacion.CodigoCompartido;
using Presentacion.Ventanas.VentanaConfirmacion;
using Presentacion.Ventanas.VentanaError;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presentacion.Properties;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using Presentacion.Ventanas.VentanaAviso;
using System.Windows.Forms;


namespace Presentacion.Ventanas.Salario
{
    class ControladorFormSalario
    {
        private FormSalario formSalario;
        private FormAviso formAviso;
        private FormError formError;

        public ControladorFormSalario(FormSalario formSalario)
        {
            
            this.formSalario = formSalario;
            this.formSalario.Opacity = 0.0;
            this.formSalario.btnCerrar.Click += new EventHandler(CerrarForm);
            this.formSalario.Load += new EventHandler(CargarForm);
            this.formSalario.btnGuardarSalario.Click += new EventHandler(GuardarSalario);
            this.formSalario.tbxSalario.KeyPress += new KeyPressEventHandler(CodigoComun.ValidarTextBoxNumero);
            this.formSalario.tbxSalario.Leave += new EventHandler(FormatoNumeroTexBox);
            this.formSalario.timerForm.Tick += new EventHandler(EfectoLogin);
            this.formSalario.MouseDown += new MouseEventHandler(VolverTransparente);
            this.formSalario.MouseUp += new MouseEventHandler(RetornarOpacidad);
            MensajesTooltip();
        }

        private void CerrarForm(object sender, EventArgs args) => CodigoComun.BtnCerrar(this.formSalario);

        private void GuardarSalario(object sender, EventArgs args)
        {

            if (this.formSalario.tbxSalario.Text != string.Empty && this.formSalario.tbxSalario.Text != "0")
            {
                if (this.formSalario.tbxSalario.Text == Settings.Default.salario.ToString("N2"))
                {
                    this.formSalario.Close();
                }
                else
                {
                    Settings.Default.salario = double.Parse(this.formSalario.tbxSalario.Text);
                    Settings.Default.Save();
                    formAviso = new FormAviso("Salaraio actualizado y Guardado correctamente");
                    formAviso.ShowDialog();
                    this.formSalario.Close();
                }
            }

            else
            {
                formError = new FormError("Ingrese el dato del salario mínimo; No puede ser un valor nulo o cero");
                formError.ShowDialog();
            }
       
        }
        private void CargarForm(object sender, EventArgs args)=> this.formSalario.tbxSalario.Text = Settings.Default.salario.ToString("N2");
        private void FormatoNumeroTexBox(object sender, EventArgs args)
        {
            try
            {
                if (((TextBox)sender).Name == this.formSalario.tbxSalario.Name && this.formSalario.tbxSalario.Text != string.Empty)
                    this.formSalario.tbxSalario.Text = string.Format("{0:n0}", double.Parse(this.formSalario.tbxSalario.Text));
            }
            catch 
            {
                using (formError = new FormError("El valor de entrada no tiene el formato correcto"))
                {
                    formError.ShowDialog();
                    this.formSalario.tbxSalario.Text = string.Empty;
                }
            }
        

        }
        private void EfectoLogin(object sender, EventArgs args)
        {
            CodigoComun.Timer(this.formSalario, this.formSalario.timerForm);
        }
        private void VolverTransparente(object sender, EventArgs args)
        {
            this.formSalario.Opacity = 0.6;
        }
        private void RetornarOpacidad(object sender, EventArgs args)
        {
            this.formSalario.Opacity = 1;
        }
        private void MensajesTooltip()
        {
            this.formSalario.ttSalario.SetToolTip(this.formSalario.btnGuardarSalario, "Guarda el salario dentro de las variables del sistema.");
            this.formSalario.ttSalario.SetToolTip(this.formSalario.btnCerrar, "Cerrar.");
            this.formSalario.ttSalario.SetToolTip(this.formSalario.tbxSalario, "Ingrese el salario mínimo mensual legal vigente.");
        }
    }
}

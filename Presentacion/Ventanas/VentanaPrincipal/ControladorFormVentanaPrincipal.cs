using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentacion.CodigoCompartido;
using Presentacion.FormsCarteras.Comercial;
using Presentacion.FormsCarteras.Consumo;
using Presentacion.FormsCarteras.Micro;
using Presentacion.FormsCarteras.Vivienda;
using Presentacion.Ventanas.VentanaAviso;
using Presentacion.Ventanas.VentanaConfirmacion;
using Presentacion.Ventanas.VentanaError;
using SoporteUsuario.CacheUsuario;

namespace Presentacion.Ventanas.VentanaPrincipal
{
    class ControladorFormVentanaPrincipal
    {
        private FormVentanaPrincipal formVentanaPrincipal;
        private CodigoComun codigoComun = new CodigoComun();
        private FormConfirmacion formConfirmacion;
        private FormAviso formAviso;
        private FormError formError;

        public ControladorFormVentanaPrincipal(FormVentanaPrincipal formVentanaPrincipal)
        {
            this.formVentanaPrincipal = formVentanaPrincipal;
            this.formVentanaPrincipal.Opacity = 0.0;
            this.formVentanaPrincipal.timerFecha.Tick += new EventHandler(TimerFechaHora);
            this.formVentanaPrincipal.timerForm.Tick += new EventHandler(EfectoLogin);
            this.formVentanaPrincipal.Load += new EventHandler(CargarForm);
            this.formVentanaPrincipal.btnCerrar.Click += new EventHandler(CerrarForm);
            this.formVentanaPrincipal.btnMinimizar.Click += new EventHandler(MinimizarForm);
            this.formVentanaPrincipal.btnComercial.Click += new EventHandler(Flecha);
            this.formVentanaPrincipal.btnConsumo.Click += new EventHandler(Flecha);
            this.formVentanaPrincipal.btnVivienda.Click += new EventHandler(Flecha);
            this.formVentanaPrincipal.btnMicro.Click += new EventHandler(Flecha);
            this.formVentanaPrincipal.btnCerrarFormActivo.Click += new EventHandler(CerrarFormActivo);
        }
        private void TimerFechaHora(object sender, EventArgs args)
        {
            this.formVentanaPrincipal.lblHora.Text = DateTime.Now.ToString("h:mm:ss");
            this.formVentanaPrincipal.lblFecha.Text = DateTime.Today.ToString("d");
        }
        
        private void EfectoLogin(object sender, EventArgs args)
        {
            codigoComun.Timer(this.formVentanaPrincipal, this.formVentanaPrincipal.timerForm);
        }
        private void CargarForm(object sender, EventArgs args)
        {
            this.formVentanaPrincipal.lblNombre.Text = Cache.Nombre;
        }
        private void CerrarForm(object sender, EventArgs args)
        {
            formConfirmacion = new FormConfirmacion("¿Desea salir del simulador?");
            DialogResult resultado = formConfirmacion.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                codigoComun.BtnCerrar(this.formVentanaPrincipal);
                Application.Exit();
            }
        }
        private void MinimizarForm(object sender, EventArgs args)
        {
            codigoComun.BtnMinimizar(this.formVentanaPrincipal);
        }
       public  void FlechaIndicadora(Button button, Panel panel)
        {
            panel.Top = button.Top;
            panel.Height = button.Height;
        }
        private void Flecha(object sender, EventArgs args)
        {
            if (((Button)sender).Name == this.formVentanaPrincipal.btnComercial.Name)
            {
                BotonesCambioDeForm(248, 100, 26, this.formVentanaPrincipal.btnComercial, new FormComercial());
            }
            else if (((Button)sender).Name == this.formVentanaPrincipal.btnConsumo.Name)
            {
                BotonesCambioDeForm(108, 55, 159, this.formVentanaPrincipal.btnConsumo, new FormConsumo());
            }
            else if (((Button)sender).Name == this.formVentanaPrincipal.btnVivienda.Name)
            {
                BotonesCambioDeForm(32, 178, 170, this.formVentanaPrincipal.btnVivienda, new FormVivienda());
            }
            else if (((Button)sender).Name == this.formVentanaPrincipal.btnMicro.Name)
            {
                BotonesCambioDeForm(91, 155, 213, this.formVentanaPrincipal.btnMicro, new FormMicro());
            }
        }
        private void CerrarFormActivo(object sender, EventArgs args)
        {
            if(codigoComun.ActiveForm != null)
            {
                formConfirmacion = new FormConfirmacion("¿Desea volver a la ventana principal?");
                DialogResult resultado = formConfirmacion.ShowDialog();

                if (resultado == DialogResult.OK && codigoComun.ActiveForm != null)
                {
                    VisibilidadObjetos(true);
                    ColoresCambioDeSimulador(248, 100, 26);
                    if (codigoComun.ActiveForm != null || codigoComun.ActiveForm == null) codigoComun.ActiveForm.Close();
                    codigoComun.ActiveForm = null;
                    this.formVentanaPrincipal.pnlFlecha.Visible = false;
                }
            } 
        }
        private void VisibilidadObjetos(bool Visible)
        {
            this.formVentanaPrincipal.pnlCentro.Visible = Visible;
            this.formVentanaPrincipal.ptbLogo.Visible = Visible;
            this.formVentanaPrincipal.lblFecha.Visible = Visible;
            this.formVentanaPrincipal.lblHora.Visible = Visible;
            this.formVentanaPrincipal.lblSimulador.Visible = Visible;
        }
        private void ColoresCambioDeSimulador(int R, int G,int B)
        {
            this.formVentanaPrincipal.pnlSuperior.BackColor = Color.FromArgb(R, G, B);
            this.formVentanaPrincipal.btnCerrarFormActivo.BackColor = Color.FromArgb(R, G, B);
            this.formVentanaPrincipal.btnCerrar.BackColor = Color.FromArgb(R, G, B);
            this.formVentanaPrincipal.btnMinimizar.BackColor = Color.FromArgb(R, G, B);
            this.formVentanaPrincipal.pnlFlecha.BackColor = Color.FromArgb(R, G, B);
        }

        private void AbrirFormhijoEstilo(int R, int G, int B, Button buttonFormHijo, Form formHijo)
        {
            ColoresCambioDeSimulador(R, G, B);
            FlechaIndicadora(buttonFormHijo, this.formVentanaPrincipal.pnlFlecha);
            VisibilidadObjetos(false);
            codigoComun.AbrirFormHijo(formHijo, this.formVentanaPrincipal.pnlCentro);
            this.formVentanaPrincipal.pnlFlecha.Visible = true;
            this.formVentanaPrincipal.bunifuTransitionForm.Show(this.formVentanaPrincipal.pnlCentro);
        }

        private void BotonesCambioDeForm(int R, int G, int B, Button buttonFormHijo, Form formHijo)
        {
            if (codigoComun.ActiveForm == null) AbrirFormhijoEstilo(R,G,B, buttonFormHijo, formHijo);
            
            else if (codigoComun.ActiveForm != null)
            {
                FormConfirmacion formConfirmacion = new FormConfirmacion("¿Desea cambiar de simulador?");
                DialogResult dialogResult = formConfirmacion.ShowDialog();
                if (dialogResult == DialogResult.OK) AbrirFormhijoEstilo(R, G, B, buttonFormHijo, formHijo);
            }
        }
    }
}

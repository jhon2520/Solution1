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
using Presentacion.Properties;
using Presentacion.Ventanas.AcercaDe;
using Presentacion.Ventanas.Documentacion;
using Presentacion.Ventanas.Salario;
using Presentacion.Ventanas.VentanaAviso;
using Presentacion.Ventanas.VentanaConfirmacion;
using Presentacion.Ventanas.VentanaEmergente;
using Presentacion.Ventanas.VentanaError;
using SoporteUsuario.CacheUsuario;

namespace Presentacion.Ventanas.VentanaPrincipal
{
    class ControladorFormVentanaPrincipal
    {
        private FormVentanaPrincipal formVentanaPrincipal;
        private FormConfirmacion formConfirmacion;
        private FormAcercaDE formAcerca;
        private CodigoComun codigoComun = new CodigoComun();
        private FormError formError;
        private FormDocumento formDocumento;

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
            this.formVentanaPrincipal.btnInstagram.Click += new EventHandler(AbrirWeb);
            this.formVentanaPrincipal.btnFacebook.Click += new EventHandler(AbrirWeb);
            this.formVentanaPrincipal.btnTwitter.Click += new EventHandler(AbrirWeb);
            this.formVentanaPrincipal.btnYoutube.Click += new EventHandler(AbrirWeb);
            this.formVentanaPrincipal.btnPagina.Click += new EventHandler(AbrirWeb);
            this.formVentanaPrincipal.lblLinkAcercaDe.Click += new EventHandler(LlamarFormAcercaDE);
            this.formVentanaPrincipal.linkLblSalario.Click += new EventHandler(AbrirFormSalario);
            this.formVentanaPrincipal.pnlSuperior.MouseDown += new MouseEventHandler(VolverTransparente);
            this.formVentanaPrincipal.pnlSuperior.MouseUp += new MouseEventHandler(RetornarOpacidad);
            this.formVentanaPrincipal.KeyDown += new KeyEventHandler(AbrirFormSalarioShortCut);
            this.formVentanaPrincipal.btnDocumentacion.Click += new EventHandler(AbrirDocumento);
            MensajesTooltip();
        
           
        }
        private void TimerFechaHora(object sender, EventArgs args)
        {
            this.formVentanaPrincipal.lblHora.Text = DateTime.Now.ToString("h:mm:ss");
            this.formVentanaPrincipal.lblFecha.Text = DateTime.Today.ToString("d");
        }
        
        private void EfectoLogin(object sender, EventArgs args)
        {
            CodigoComun.Timer(this.formVentanaPrincipal, this.formVentanaPrincipal.timerForm);
        }
        private void CargarForm(object sender, EventArgs args)
        {
            using (formError = new FormError("El salario mínimo no está almacenado en el sistema o tiene un valor de 0."))
            {
                this.formVentanaPrincipal.lblNombre.Text = Cache.NombreAnalista;

                if (Settings.Default.salario == 0)
                {
                    formError.ShowDialog();
                }
            }
      
        }
        private void CerrarForm(object sender, EventArgs args)
        {
            using (formConfirmacion = new FormConfirmacion("¿Desea salir del simulador?"))
            {
                DialogResult resultado = formConfirmacion.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    CodigoComun.BtnCerrar(this.formVentanaPrincipal);
                    Application.Exit();
                }
            }
        }
        private void MinimizarForm(object sender, EventArgs args)
        {
            CodigoComun.BtnMinimizar(this.formVentanaPrincipal);
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
                BotonesCambioDeForm(248, 100, 26, this.formVentanaPrincipal.btnComercial, new FormConsumo());
                Cache.TipoDeCredito = 2;
                Cache.ColorInicio = Color.FromArgb(248, 100, 26);
            }
            else if (((Button)sender).Name == this.formVentanaPrincipal.btnConsumo.Name)
            {
                BotonesCambioDeForm(108, 55, 159, this.formVentanaPrincipal.btnConsumo, new FormConsumo());
                Cache.TipoDeCredito = 1;
                Cache.ColorInicio = Color.FromArgb(108, 55, 159);
            }
            else if (((Button)sender).Name == this.formVentanaPrincipal.btnVivienda.Name)
            {
                BotonesCambioDeForm(32, 178, 170, this.formVentanaPrincipal.btnVivienda, new FormConsumo());
                Cache.TipoDeCredito = 3;
                Cache.ColorInicio = Color.FromArgb(32, 178, 170);
            }
            else if (((Button)sender).Name == this.formVentanaPrincipal.btnMicro.Name)
            {
                BotonesCambioDeForm(90, 148, 201, this.formVentanaPrincipal.btnMicro, new FormConsumo());
                Cache.TipoDeCredito = 4;
                Cache.ColorInicio = Color.FromArgb(90, 148, 201);
            }
        }
        private void CerrarFormActivo(object sender, EventArgs args)
        {
            using (formConfirmacion = new FormConfirmacion("¿Desea volver a la ventana principal?"))
            {
                if (codigoComun.ActiveForm != null)
                {

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

      
        }
            private void VisibilidadObjetos(bool Visible)
        {
            this.formVentanaPrincipal.pnlCentro.Visible = Visible;
            this.formVentanaPrincipal.ptbLogo.Visible = Visible;
            this.formVentanaPrincipal.lblFecha.Visible = Visible;
            this.formVentanaPrincipal.lblHora.Visible = Visible;
            this.formVentanaPrincipal.btnFacebook.Visible = Visible;
            this.formVentanaPrincipal.btnInstagram.Visible = Visible;
            this.formVentanaPrincipal.btnPagina.Visible = Visible;
            this.formVentanaPrincipal.btnTwitter.Visible = Visible;
            this.formVentanaPrincipal.btnYoutube.Visible = Visible;
            this.formVentanaPrincipal.lblLinkAcercaDe.Visible = Visible;
            this.formVentanaPrincipal.linkLblSalario.Visible = Visible;
            this.formVentanaPrincipal.lblSenaCom.Visible = Visible;
            this.formVentanaPrincipal.lblSenaComunica.Visible = Visible;
            this.formVentanaPrincipal.panel1.Visible = Visible;
            this.formVentanaPrincipal.panel2.Visible = Visible;

        }
        private void ColoresCambioDeSimulador(int R, int G,int B)
        {
            this.formVentanaPrincipal.pnlSuperior.BackColor = Color.FromArgb(R, G, B);
            //this.formVentanaPrincipal.btnCerrarFormActivo.BackColor = Color.FromArgb(R, G, B);
            //this.formVentanaPrincipal.btnCerrar.BackColor = Color.FromArgb(R, G, B);
            //this.formVentanaPrincipal.btnMinimizar.BackColor = Color.FromArgb(R, G, B);
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
            using (FormConfirmacion formConfirmacion = new FormConfirmacion("¿Desea cambiar de simulador?"))
            {
                if (codigoComun.ActiveForm == null) AbrirFormhijoEstilo(R, G, B, buttonFormHijo, formHijo);

                else if (codigoComun.ActiveForm != null)
                {
                    DialogResult dialogResult = formConfirmacion.ShowDialog();
                    if (dialogResult == DialogResult.OK) AbrirFormhijoEstilo(R, G, B, buttonFormHijo, formHijo);
                }
            }

          
        }

        private void AbrirWeb(object sender, EventArgs args)
        {
            if (((Button)sender).Name == this.formVentanaPrincipal.btnInstagram.Name)
            {
                CodigoComun.Alerta("Correcto", FormVentanaEmergente.enmTipo.exito);
                CodigoComun.AbrirWebs("www.instagram.com/senacomunica/");
            }
            else if (((Button)sender).Name == this.formVentanaPrincipal.btnFacebook.Name)
            {
                CodigoComun.Alerta("Correcto", FormVentanaEmergente.enmTipo.exito);
                CodigoComun.AbrirWebs("www.facebook.com/SENA/");
            }
            else if (((Button)sender).Name == this.formVentanaPrincipal.btnTwitter.Name)
            {
                CodigoComun.Alerta("Correcto", FormVentanaEmergente.enmTipo.exito);
                CodigoComun.AbrirWebs("www.twitter.com/senacha2?lang=es");
            }
            else if (((Button)sender).Name == this.formVentanaPrincipal.btnYoutube.Name)
            {
                CodigoComun.Alerta("Correcto", FormVentanaEmergente.enmTipo.exito);
                CodigoComun.AbrirWebs("www.youtube.com/user/SENATV");
            }
            else if (((Button)sender).Name == this.formVentanaPrincipal.btnPagina.Name)
            {
                CodigoComun.Alerta("Correcto", FormVentanaEmergente.enmTipo.exito);
                CodigoComun.AbrirWebs("www.sena.edu.co/es-co/Paginas/default.aspx");
            }
        }

        private void LlamarFormAcercaDE(object sender, EventArgs args)
        {
            using (formAcerca = new FormAcercaDE())
            {
                formAcerca.ShowDialog();
            } 
        }
       
        private void AbrirFormSalario(object sender, EventArgs args)
        {
            using (FormSalario formSalario = new FormSalario())
            {
                formSalario.ShowDialog();
            }
               
        }

        private void AbrirFormSalarioShortCut(object sender, KeyEventArgs e)
        {
            using (FormSalario formSalario = new FormSalario())
            {
                if (e.Control && e.KeyCode == Keys.S)
                {

                    formSalario.ShowDialog();
                }
            
            }
            if (e.Control && e.KeyCode == Keys.Q)
            {
                this.formVentanaPrincipal.btnCerrarFormActivo.PerformClick();
            }

            if(e.KeyCode == Keys.Escape)
            {
                this.formVentanaPrincipal.btnCerrar.PerformClick();
            }


        }

        private void VolverTransparente(object sender, EventArgs args)
        {
            this.formVentanaPrincipal.Opacity = 0.6;
        }
        private void RetornarOpacidad(object sender, EventArgs args)
        {
            this.formVentanaPrincipal.Opacity = 1;
        }

        private void MensajesTooltip()
        {
            this.formVentanaPrincipal.ttFormPrincipal.SetToolTip(this.formVentanaPrincipal.btnConsumo, "Analizar un crédito bajo la modalidad de consumo.");
            this.formVentanaPrincipal.ttFormPrincipal.SetToolTip(this.formVentanaPrincipal.btnComercial, "Analizar un crédito bajo la modalidad de comercial.");
            this.formVentanaPrincipal.ttFormPrincipal.SetToolTip(this.formVentanaPrincipal.btnMicro, "Analizar un crédito bajo la modalidad de Microcrédito.");
            this.formVentanaPrincipal.ttFormPrincipal.SetToolTip(this.formVentanaPrincipal.btnVivienda, "Analizar un crédito bajo la modalidad de Vivienda.");

            this.formVentanaPrincipal.ttFormPrincipal.SetToolTip(this.formVentanaPrincipal.btnInstagram, "Ingresar al Instagram del SENA.");
            this.formVentanaPrincipal.ttFormPrincipal.SetToolTip(this.formVentanaPrincipal.btnFacebook, "Ingresar al Facebook del SENA.");
            this.formVentanaPrincipal.ttFormPrincipal.SetToolTip(this.formVentanaPrincipal.btnTwitter, "Ingresar al Twitter del SENA.");
            this.formVentanaPrincipal.ttFormPrincipal.SetToolTip(this.formVentanaPrincipal.btnYoutube, "Ingresar al canal de Youtube del SENA.");
            this.formVentanaPrincipal.ttFormPrincipal.SetToolTip(this.formVentanaPrincipal.btnPagina, "Ingresar a la página web del SENA.");
            this.formVentanaPrincipal.ttFormPrincipal.SetToolTip(this.formVentanaPrincipal.btnCerrarFormActivo, "Volver a la ventana principal. Ctrl + Q");
            this.formVentanaPrincipal.ttFormPrincipal.SetToolTip(this.formVentanaPrincipal.btnCerrar, "Cerrar aplicación (esc).");
            this.formVentanaPrincipal.ttFormPrincipal.SetToolTip(this.formVentanaPrincipal.btnMinimizar, "Minimizar aplicación.");

            this.formVentanaPrincipal.ttFormPrincipal.SetToolTip(this.formVentanaPrincipal.linkLblSalario, "Modificar el salario mínimo registrado en el sistema. Ctrl + S");
            this.formVentanaPrincipal.ttFormPrincipal.SetToolTip(this.formVentanaPrincipal.lblLinkAcercaDe, "Acerca del sistema.");
        }

        private void AbrirDocumento(object sender, EventArgs args)
        {
            using(formDocumento = new FormDocumento())
            {
                formDocumento.ShowDialog();
            }
        }
    }
}

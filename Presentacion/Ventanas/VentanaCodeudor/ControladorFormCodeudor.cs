using Presentacion.CodigoCompartido;
using SoporteUsuario.CacheUsuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Ventanas.VentanaCodeudor
{
    class ControladorFormCodeudor
    {
        FormCodeudor formCodeudor;

        public ControladorFormCodeudor(FormCodeudor formCodeudor)
        {
            this.formCodeudor = formCodeudor;
            this.formCodeudor.Opacity = 0.0;
            this.formCodeudor.btnCerrar.Click += new EventHandler(CerrarForm);
            this.formCodeudor.timerForm.Tick += new EventHandler(EfectoLogin);
            this.formCodeudor.pnlSuperior.MouseDown += new MouseEventHandler(VolverTransparente);
            this.formCodeudor.pnlSuperior.MouseUp += new MouseEventHandler(RetornarOpacidad);
            this.formCodeudor.pbx.MouseDown += new MouseEventHandler(VolverTransparente);
            this.formCodeudor.pbx.MouseUp += new MouseEventHandler(RetornarOpacidad);
            CargarForm();
            ValidacionSoloNumerosTextBox();
        }

        public void CargarForm()
        {
            this.formCodeudor.pnlSuperior.BackColor = Cache.ColorInicio;
            this.formCodeudor.panelColor1.BackColor = Cache.ColorInicio;
            this.formCodeudor.panelColor2.BackColor = Cache.ColorInicio;
            this.formCodeudor.panelColor3.BackColor = Cache.ColorInicio;
            this.formCodeudor.panelColor4.BackColor = Cache.ColorInicio;
        }

        private void CerrarForm(object sender, EventArgs args)
        {
            CodigoComun.BtnCerrar(this.formCodeudor);
        }
        private void EfectoLogin(object sender, EventArgs args)
        {
            CodigoComun.Timer(this.formCodeudor, this.formCodeudor.timerForm);
        }
        private void VolverTransparente(object sender, EventArgs args)
        {
            this.formCodeudor.Opacity = 0.6;
        }
        private void RetornarOpacidad(object sender, EventArgs args)
        {
            this.formCodeudor.Opacity = 1;
        }
        private void ValidacionSoloNumerosTextBox()
        {
            this.formCodeudor.tbxIngresos.KeyPress += new KeyPressEventHandler(CodigoComun.ValidarTextBoxNumero);
            this.formCodeudor.tbxOtrosIngresos.KeyPress += new KeyPressEventHandler(CodigoComun.ValidarTextBoxNumero);
            this.formCodeudor.tbxDeduccionesColilla.KeyPress += new KeyPressEventHandler(CodigoComun.ValidarTextBoxNumero);;
            this.formCodeudor.tbxValorCuotaLibranza.KeyPress += new KeyPressEventHandler(CodigoComun.ValidarTextBoxNumero);
            this.formCodeudor.tbxDeduccionesDeSeguridadSocial.KeyPress += new KeyPressEventHandler(CodigoComun.ValidarTextBoxNumero);
            this.formCodeudor.tbxOtrasDeduccionesColilla.KeyPress += new KeyPressEventHandler(CodigoComun.ValidarTextBoxNumero);
            this.formCodeudor.tbxCuotasCentralesDeRiesgo.KeyPress += new KeyPressEventHandler(CodigoComun.ValidarTextBoxNumero);
          
        }

    }
}

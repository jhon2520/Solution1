using Presentacion.CodigoCompartido;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Ventanas.VentanaCodeudor
{
    public class IndicadoresCaja:IDisposable
    {
        //debe Tener endeduamiento global y disponible, por caja los dos

        private double deduccionesColilla;
        private double cuotaCentrales;
        private double cuota;
        private double cuotaACancelar;
        private double ingresos;
        private double otrosIngresos;
        private RadioButton radioButtonCiudad;
        private ComboBox comboBoxVivienda;


        public IndicadoresCaja(double deduccionesColilla, double cuotaCentrales, double cuota, double cuotaACancelar, double ingresos, double otrosIngresos, RadioButton radioButtonCiudad, ComboBox comboBoxVivienda)
        {
            this.deduccionesColilla = deduccionesColilla;
            this.cuotaCentrales = cuotaCentrales;
            this.cuota = cuota;
            this.cuotaACancelar = cuotaACancelar;
            this.ingresos = ingresos;
            this.otrosIngresos = otrosIngresos;
            this.radioButtonCiudad = radioButtonCiudad;
            this.comboBoxVivienda = comboBoxVivienda;
        }

        public double RetornarEndeudamientoGlobal()
        {
            double endeudamientoGlobal;

            endeudamientoGlobal = EndeudamientoGlobal.CalcularEndeudamientoGlobalCaja(this.deduccionesColilla, this.cuotaCentrales, this.cuota, RetornarDANECiudadPueblo(),
                RetornarDANEVivienda(), this.cuotaACancelar, this.ingresos, this.otrosIngresos);
            return endeudamientoGlobal;

        }
        private double RetornarDANEVivienda()
        {
            double ValorDANEVivienda = 0;

            if (this.radioButtonCiudad.Checked == true)
            {
                if (this.comboBoxVivienda.Text == "Arrendada")
                    ValorDANEVivienda = GastosDANE.RetornarDANEViviendaCiudad(true, this.ingresos);
                else if (this.comboBoxVivienda.Text == "Familiar")
                    ValorDANEVivienda = GastosDANE.RetornarDANEViviendaCiudad(false, this.ingresos);
                else
                    ValorDANEVivienda = 0;
            }
            else if (this.radioButtonCiudad.Checked == false)
            {
                if (this.comboBoxVivienda.Text == "Arrendada")
                    ValorDANEVivienda = GastosDANE.RetornarDANEViviendaPueblo(true, this.ingresos);
                else if (this.comboBoxVivienda.Text == "Familiar")
                    ValorDANEVivienda = GastosDANE.RetornarDANEViviendaPueblo(false, this.ingresos);
                else
                    ValorDANEVivienda = 0;
            }
            return ValorDANEVivienda;
        }
        private double RetornarDANECiudadPueblo()
        {
            double ValorDANE;
            ValorDANE = GastosDANE.RetornarDANECiudadPueblo(this.radioButtonCiudad.Checked, this.ingresos);
            return ValorDANE;
        }

        public double RetornarDisponible()
        {
            double disponible;

            
            disponible = Disponible.CalcularDisponibleCaja(this.ingresos,
            this.otrosIngresos, this.deduccionesColilla,
            RetornarDANECiudadPueblo(), RetornarDANEVivienda(), this.cuotaACancelar);

            return disponible;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing) { }
      
    }
}

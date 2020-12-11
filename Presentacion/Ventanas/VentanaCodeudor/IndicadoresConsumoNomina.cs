using Presentacion.CodigoCompartido;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Ventanas.VentanaCodeudor
{
    public class IndicadoresConsumoNomina
    {
        private double ingresos;
        private double deduccionesDeSeguridadSocial;
        private double otrasDeduccionesColilla;
        private double deduccionesColilla;
        private double cuota;
        private double cuotaCentrales;
        private double cuotaLibranza;
        private double totalIngresos;

        private FormCodeudor formCodeudor = new FormCodeudor();

        
        public IndicadoresConsumoNomina(double ingresos, double deduccionesDeSeguridadSocial,double otrasDeduccionesColilla, double deduccionesColilla,double cuota,double cuotaCentrales, double cuotaLibranza,double totalIngresos)
        {
            this.ingresos = ingresos;
            this.deduccionesDeSeguridadSocial = deduccionesDeSeguridadSocial;
            this.otrasDeduccionesColilla = otrasDeduccionesColilla;
            this.deduccionesColilla = deduccionesColilla;
            this.cuotaCentrales = cuotaCentrales;
            this.cuota = cuota;
            this.cuotaLibranza = cuotaLibranza;
            this.totalIngresos = totalIngresos;
        }

        public double RetornarDisponibleConLibranza()
        {
            return Codeudor.RetornarDisponibleNominaConLibranza(this.ingresos, this.deduccionesDeSeguridadSocial, this.otrasDeduccionesColilla);
        }
        public double RetornarDisponibleSinLibranza()
        {
            return Codeudor.RetornarDisponibleNominaSinLibranza(this.ingresos, this.deduccionesColilla);
        }
        public double RetornarAfectacionColilla()
        {
            return Codeudor.RetornarAfectacionColillaNomina(this.deduccionesColilla, this.cuota, this.ingresos);
        }
        public double RetornarEndeudamientoGlobal()
        {
            return Codeudor.RetornarEndeudamientoGlobalNomina(this.deduccionesColilla, this.cuotaCentrales, this.cuota, this.cuotaLibranza, this.totalIngresos);
        }

    }
}

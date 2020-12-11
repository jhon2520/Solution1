using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion.CodigoCompartido
{
    public static class Codeudor
    {
        public static double RetornarDisponibleNominaSinLibranza(double ingresoBasico, double deduccionesColilla)=> ((ingresoBasico / 2) - deduccionesColilla);
        public static double RetornarDisponibleNominaConLibranza(double ingresoBasico, double deduccionesSeguridadSocial ,double otrasDeduccionesColilla) => (((ingresoBasico - deduccionesSeguridadSocial) / 2) - otrasDeduccionesColilla);
        public static double RetornarAfectacionColillaNomina(double deduccionesColilla, double CuotaCredito, double ingresoBasico) => ((deduccionesColilla + CuotaCredito) / ingresoBasico);
        public static double RetornarEndeudamientoGlobalNomina(double deduccionesColilla, double cuotaCentrales, double cuotaCredito, double cuotaLibranza, double totalIngresos) => ((deduccionesColilla + cuotaCentrales + cuotaCredito - cuotaLibranza) / totalIngresos);

    }
}

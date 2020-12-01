using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion.CodigoCompartido
{
    public static class EndeudamientoGlobal
    {
        public static double CalcularEndeudamientoGlobalNomina(double deduccionesColilla, double cuotasCentrales, double cuotaCredito, double cuotasACancerlar,
           double ingresoBasico, double otrosIngresos)
        {
            return ((deduccionesColilla + cuotasCentrales + cuotaCredito - cuotasACancerlar) / (ingresoBasico + otrosIngresos));
        }
        public static double CalcularEndeudamientoGlobalCaja(double deduccionesColilla, double cuotasCentrales, double cuotaCredito,double valorDANECiudadPueblo, double valorDANEArriendo,  double cuotasACancerlar,
        double ingresoBasico, double otrosIngresos)
        {
            return ((deduccionesColilla + cuotasCentrales + cuotaCredito + (ingresoBasico * valorDANECiudadPueblo) + (ingresoBasico * valorDANEArriendo) - cuotasACancerlar) / (ingresoBasico + otrosIngresos));
        }
    }

}

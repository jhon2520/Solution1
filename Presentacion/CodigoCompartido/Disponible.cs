using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion.CodigoCompartido
{
    public static class Disponible
    {
        public static double CalcularDisponibleNominaSinLibranza(double salario, double deduccionesDeColilla, double cuotasDeCreditoACancerlaPorNomina)
        {
            return (salario / 2) - (deduccionesDeColilla + cuotasDeCreditoACancerlaPorNomina);
        }
        public static double CalcularDisponibleNominaConLibranza(double salario, double deduccionesSeguridadSocial, double otrasDeduccionesColilla, double cuotasDeCreditoACancerlaPorNomina)
        {
            return ((salario - deduccionesSeguridadSocial) / 2) - (otrasDeduccionesColilla + cuotasDeCreditoACancerlaPorNomina);
        }
        public static double CalcularDisponibleCaja(double salario,double otrosIngresos, double deduccionesColilla, double valorDANECiudaPueblo, double valorDANETipoVivienda, double cuotaCreditoACancelar)
        {
            return (salario + otrosIngresos - deduccionesColilla - (valorDANECiudaPueblo * salario) - (valorDANETipoVivienda * salario) + cuotaCreditoACancelar);
        }

    }
}

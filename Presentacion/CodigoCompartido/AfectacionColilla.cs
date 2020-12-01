using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion.CodigoCompartido
{
    public static class AfectacionColilla
    {
        public static double CalcularAfectacionColilla(double deduccionesColilla, double cuotaDelCredito, double cuotasACancelarPorNomina, double ingresoBasico)
        {
            return (deduccionesColilla + cuotaDelCredito - cuotasACancelarPorNomina) / (ingresoBasico);
        }
    }
}

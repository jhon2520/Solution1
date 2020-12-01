using Presentacion.Properties;
using SoporteUsuario.CacheUsuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion.CodigoCompartido
{
    public static class GastosDANE
    {
        private static double salario = Settings.Default.salario;
        private static double RetornarValorDANECiudad(double salarioBasico)
        {
            if (salarioBasico <= (4 * salario)) return 0.4468;
            else if (salarioBasico > (4 * salario) && salarioBasico < (11 * salario)) return 0.3468;
            else if (salarioBasico >= (11 * salario)) return 0.2768;
            else return 0;
        }
        private static double RetornarValorDANEPueblo(double salarioBasico)
        {
            if (salarioBasico <= (4 * salario)) return 0.4157;
            else if (salarioBasico > (4 * salario) && salarioBasico < (11 * salario)) return 0.3116;
            else if (salarioBasico >= (11 * salario)) return 0.2119;
            else return 0;
        }

        private static double RetornarValorDANEPCasaArrendadaCiudad(double salarioBasico)
        {
            if (salarioBasico <= (4 * salario)) return 0.23;
            else if (salarioBasico > (4 * salario) && salarioBasico < (11 * salario)) return 0.2068;
            else if (salarioBasico >= (11 * salario)) return 0.2068;
            else return 0;
        }
        private static double RetornarValorDANECasaFamiliarCiudad(double salarioBasico)
        {
            if (salarioBasico <= (4 * salario)) return 0.12;
            else if (salarioBasico > (4 * salario) && salarioBasico < (11 * salario)) return 0.12;
            else if (salarioBasico >= (11 * salario)) return 0.12;
            else return 0;
        }

        private static double RetornarValorDANEPCasaArrendadaPueblo(double salarioBasico)
        {
            if (salarioBasico <= (4 * salario)) return 0.1227;
            else if (salarioBasico > (4 * salario) && salarioBasico < (11 * salario)) return 0.15;
            else if (salarioBasico >= (11 * salario)) return 0.1227;
            else return 0;
        }
        private static double RetornarValorDANECasaFamiliarPueblo(double salarioBasico)
        {
            if (salarioBasico <= (4 * salario)) return 0.07;
            else if (salarioBasico > (4 * salario) && salarioBasico < (11 * salario)) return 0.07;
            else if (salarioBasico >= (11 * salario)) return 0.07;
            else return 0;
        }

        public static double RetornarDANECiudadPueblo(bool Ciudad,double salario)
        {
            double valorDANE;

            if (Ciudad == true) valorDANE = RetornarValorDANECiudad(salario);
            else if (Ciudad == false) valorDANE = RetornarValorDANEPueblo(salario);
            else valorDANE = 0;

            return valorDANE;
        }

        public static double RetornarDANEViviendaCiudad(bool viviendaArrendada, double salario)
        {
            double valorDANE;
            if (viviendaArrendada == true) valorDANE = RetornarValorDANEPCasaArrendadaCiudad(salario);
            else if (viviendaArrendada == false) valorDANE = RetornarValorDANECasaFamiliarCiudad(salario);
            else valorDANE = 0;

            return valorDANE;
        }
        public static double RetornarDANEViviendaPueblo(bool viviendaArrendada, double salario)
        {
            double valorDANE;
            if (viviendaArrendada == true) valorDANE = RetornarValorDANEPCasaArrendadaPueblo(salario);
            else if (viviendaArrendada == false) valorDANE = RetornarValorDANECasaFamiliarPueblo(salario);
            else valorDANE = 0;

            return valorDANE;
        }
    }
}

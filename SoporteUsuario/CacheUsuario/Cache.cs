﻿using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoporteUsuario.CacheUsuario
{
    public static class Cache
    {
        private static string nombreAnalista;
        private static string nombre;
        private static string apellido;
        private static string cedula;
        private static double monto;
        private static decimal plazo;
        private static decimal tasa;
        private static double cuota;


        private static double totalIngresos;
        private static double score;
        private static double antLaboral;
        private static string tipoDeContrato;
        private static double deduccionesColilla;
        private static double cuotaCentrales;
        private static double ingresoBasico;
        private static double otrosIngresos;
        private static string formaDePago;
        private static int edad;
        private static string garantia;
        private static string cumplimientoDePoliticias;
        private static string criterioDelAnalista;
        private static string periodicidad;
        private static string fechaDeNaciento;
        private static string profesion;
        private static string cargo;
        private static string ocupacion;
        private static string estadoCivil;
        private static int personasAcargo;
        private static string vivienda;
        private static int estrato;
        private static string ciudadMunicipio;
        private static string empresa;
        private static string actividadEconomica;
        private static double valorCuotaLibranza;
        private static double cuotasACancelar;
        private static double estimacionCupoRotativo;
        private static double cuotasDeCreditoACancelarPorNomina;
        private static double estimacionTarjetasDeCredito;
        private static string calificacion;
        private static int numeroDeMoras;
        private static int diasDeMora;
        private static double deduccionesDeSeguridadSocial;
        private static double otrasDeduccionesColilla;
        private static double disponible;
        private static double endeudamientoGlobal;
        private static double afectacionColilla;
        private static int tipoDeCredito;
        private static string tipoDePersona;
        private static string destinoDelCredito;
        private static string tipoDeCreditoVivienda;
        private static int tiempoUnidadProductiva;
        private static Color colorInicio;
        private static string aplicaLeyLibranza;
        private static string comportamientoDePagos;

        //Variables básicas para el crédito
        public static string Nombre { get => nombre; set => nombre = value; }
        public static string Cedula { get => cedula; set => cedula = value; }
        public static double Monto { get => monto; set => monto = value; }
        public static decimal Plazo { get => plazo; set => plazo = value; }
        public static decimal Tasa { get => tasa; set => tasa = value; }
        public static double Cuota { get => cuota; set => cuota = value; }

        

     

        //Variables para el análisis de crédito

        public static double TotalIngresos { get => totalIngresos; set => totalIngresos = value; }
        public static double Score { get => score; set => score = value; }
        public static double AntLaboral { get => antLaboral; set => antLaboral = value; }
        public static string TipoDeContrato { get => tipoDeContrato; set => tipoDeContrato = value; }
        public static double DeduccionesColilla { get => deduccionesColilla; set => deduccionesColilla = value; }
        public static double CuotaCentrales { get => cuotaCentrales; set => cuotaCentrales = value; }
        public static double IngresoBasico { get => ingresoBasico; set => ingresoBasico = value; }
        public static double OtrosIngresos { get => otrosIngresos; set => otrosIngresos = value; }
        public static string FormaDePago { get => formaDePago; set => formaDePago = value; }
        public static int Edad { get => edad; set => edad = value; }
        public static string Garantia { get => garantia; set => garantia = value; }
        public static string CumplimientoDePoliticias { get => cumplimientoDePoliticias; set => cumplimientoDePoliticias = value; }
        public static string CriterioDelAnalista { get => criterioDelAnalista; set => criterioDelAnalista = value; }
        public static string Periodicidad { get => periodicidad; set => periodicidad = value; }
        public static string Apellido { get => apellido; set => apellido = value; }
        public static string FechaDeNaciento { get => fechaDeNaciento; set => fechaDeNaciento = value; }
        public static string Profesion { get => profesion; set => profesion = value; }
        public static string Cargo { get => cargo; set => cargo = value; }
        public static string Ocupacion { get => ocupacion; set => ocupacion = value; }
        public static string EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
        public static int PersonasAcargo { get => personasAcargo; set => personasAcargo = value; }
        public static string Vivienda { get => vivienda; set => vivienda = value; }
        public static int Estrato { get => estrato; set => estrato = value; }
        public static string CiudadMunicipio { get => ciudadMunicipio; set => ciudadMunicipio = value; }
        public static string Empresa { get => empresa; set => empresa = value; }
        public static string ActividadEconomica { get => actividadEconomica; set => actividadEconomica = value; }
        public static double ValorCuotaLibranza { get => valorCuotaLibranza; set => valorCuotaLibranza = value; }
        public static double CuotasACancelar { get => cuotasACancelar; set => cuotasACancelar = value; }
        public static double EstimacionCupoRotativo { get => estimacionCupoRotativo; set => estimacionCupoRotativo = value; }
        public static double CuotasDeCreditoACancelarPorNomina { get => cuotasDeCreditoACancelarPorNomina; set => cuotasDeCreditoACancelarPorNomina = value; }
        public static double EstimacionTarjetasDeCredito { get => estimacionTarjetasDeCredito; set => estimacionTarjetasDeCredito = value; }
        public static string Calificacion { get => calificacion; set => calificacion = value; }
        public static string NombreAnalista { get => nombreAnalista; set => nombreAnalista = value; }
        public static int NumeroDemoras { get => numeroDeMoras; set => numeroDeMoras = value; }
        public static int DiasDeMora { get => diasDeMora; set => diasDeMora = value; }
        public static double DeduccionesDeSeguridadSocial { get => deduccionesDeSeguridadSocial; set => deduccionesDeSeguridadSocial = value; }
        public static double Disponible { get => disponible; set => disponible = value; }
        public static double EndeudamientoGlobal { get => endeudamientoGlobal; set => endeudamientoGlobal = value; }
        public static double AfectacionColilla { get => afectacionColilla; set => afectacionColilla = value; }
        public static int TipoDeCredito { get => tipoDeCredito; set => tipoDeCredito = value; }
        public static string TipoDePersona { get => tipoDePersona; set => tipoDePersona = value; }
        public static string DestinoDelCredito { get => destinoDelCredito; set => destinoDelCredito = value; }
        public static string TipoDeCreditoVivienda { get => tipoDeCreditoVivienda; set => tipoDeCreditoVivienda = value; }
        public static int TiempoUnidadProductiva { get => tiempoUnidadProductiva; set => tiempoUnidadProductiva = value; }
        public static Color ColorInicio { get => colorInicio; set => colorInicio = value; }
        public static double OtrasDeduccionesColilla { get => otrasDeduccionesColilla; set => otrasDeduccionesColilla = value; }
        public static string AplicaLeyLibranza { get => aplicaLeyLibranza; set => aplicaLeyLibranza = value; }
        public static string ComportamientoDePagos { get => comportamientoDePagos; set => comportamientoDePagos = value; }
    }
}

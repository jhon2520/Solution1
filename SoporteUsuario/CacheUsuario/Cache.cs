using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoporteUsuario.CacheUsuario
{
    public static class Cache
    {
        private static string nombre;

        public static string Nombre { get => nombre; set => nombre = value; }
       
    }
}

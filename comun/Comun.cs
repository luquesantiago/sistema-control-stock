using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comun
{
    public static class Comun
    {

        public static string NombreUsuario { get; set; }
        public static string Contrasena { get; set; }
        public static int UserID { get; set; }
        public static bool Nuevo { get; set; }
        public static bool bloqueado { get; set; }
        public static string NombrePermiso { get; set; }
        public static DateTime FechaIntento { get; set; }
        public static int? Intento { get; set; }
        public static DateTime FechaInicio { get; set; }
        public static DateTime FechaFin { get; set; }
        public static string Gmail { get; set; }
        // agregar el mail del usuario y tmb se podria agregar su id
    }
}

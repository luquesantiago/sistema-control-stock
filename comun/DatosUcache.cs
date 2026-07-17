using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comun
{
    public static class DatosUcache
    {
        public static int UserID { get; set; }
        public static bool bloqueado { get; set; }
        public static string Nombre { get; set; }
        public static string Usuario { get; set; }
        public static string Contrasena { get; set; }
        public static string Permiso { get; set; }
        public static DateTime FechaFin { get; set; }
    }
}

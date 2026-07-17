using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using comun;
using datos;

namespace logica
{
    public static class ObtenerConfigSis
    {
        public static void obtener()
        {
            datos.ObtenerConfigSis obtenerConfigSis = new datos.ObtenerConfigSis();
            DataTable dt = obtenerConfigSis.sentencia();
            SistemCache.minChar = Convert.ToBoolean(dt.Rows[0][0].ToString());
            SistemCache.MayusyMin = Convert.ToBoolean(dt.Rows[1][0].ToString());
            SistemCache.Especiales = Convert.ToBoolean(dt.Rows[2][0].ToString());
            SistemCache.Validacion = Convert.ToBoolean(dt.Rows[3][0].ToString());
            SistemCache.repetirC = Convert.ToBoolean(dt.Rows[4][0].ToString());
        }
    }
}

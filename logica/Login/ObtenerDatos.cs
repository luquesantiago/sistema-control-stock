using System;
using System.Data;
using datos;
using comun;
namespace logica
{
    public static class ObtenerDatos
    {
        public static bool obtener(string user)
        {
            try
            {
                obtenerDatosU obtenerDatosU = new obtenerDatosU();
                DataTable dt = obtenerDatosU.obtener(user);
                foreach (DataRow row in dt.Rows)
                {
                    DatosUcache.Nombre = row[0].ToString();
                    DatosUcache.UserID= Convert.ToInt32(row[1]);
                    DatosUcache.Usuario = user;
                    DatosUcache.Contrasena = row[2].ToString();
                    DatosUcache.bloqueado = Convert.ToBoolean(row[3]);
                    DatosUcache.Permiso = row[4].ToString();
                    DatosUcache.FechaFin = Convert.ToDateTime(row[5]);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
           
        }
    }
}

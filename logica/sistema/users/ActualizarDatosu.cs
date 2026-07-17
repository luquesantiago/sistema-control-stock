using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using datos;
using comun;
using servicios;
using datos.procedimientos_almacenados;

namespace logica
{
    public static class ActualizarDatosu
    {
        public static bool intentar( bool bloqueado,string username, string password, string permiso, DateTime fechaFin)
        {
            if(fechaFin<=DateTime.Today)
            {
                if (Comun.FechaFin >= DateTime.Today)
                {
                    BorrarinfoPersonal.borrar(DatosUcache.UserID);
                  
                }
            }
            string passwordE = password;
            if (password!=DatosUcache.Contrasena)
            {
                passwordE = PasswordEncryptor.EncryptPassword(password);
                ActualizarPassword.actualizar(username,passwordE+PasswordEncryptor.EncryptPassword(username));

            }
            editarUsers editarusers = new editarUsers();
            if (editarusers.EjecutarYDevolver(DatosUcache.UserID, bloqueado,  username, permiso, fechaFin))
            {
                return true;
            }
            else
            { 
                return false; 
            }


        }
    }
}

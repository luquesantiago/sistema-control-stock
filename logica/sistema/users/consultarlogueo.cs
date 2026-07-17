using servicios;
using datos;
using comun;
using System.Data;
using System;

namespace logica
{
    public class consultarlogueo
    {
        public bool preguntar(string Username, string Password)
        {

            string PasswordE = PasswordEncryptor.EncryptPassword(Password);
            consultarlogueod ex = new consultarlogueod(); 
            DataTable dt = ex.sentencia(Username, PasswordE+PasswordEncryptor.EncryptPassword(Username));
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    Comun.Nuevo = Convert.ToBoolean(row[0]);
                    Comun.bloqueado = Convert.ToBoolean(row[1]);
                    Comun.UserID = Convert.ToInt32(row[2]);
                    Comun.NombrePermiso = row[3].ToString();
                    Comun.FechaInicio = Convert.ToDateTime(row[4]);
                    Comun.FechaFin = Convert.ToDateTime(row[5]);
                    Comun.Intento = Convert.ToInt16(row[6]);
                    Comun.Gmail = row[7].ToString();

                }
                Comun.NombreUsuario = Username;
                Comun.Contrasena = Password;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

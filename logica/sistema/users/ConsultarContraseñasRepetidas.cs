using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using datos;
using datos.consultar;
using servicios;

namespace logica.consultar
{
    public static class ConsultarContraseñasRepetidas
    {
        public static bool consultar(string nombre, string Password)
        {
            ConsultarContraseñasRep consultarContraseñasRep = new ConsultarContraseñasRep();
            if(consultarContraseñasRep.sentencia(nombre,PasswordEncryptor.EncryptPassword(Password)+PasswordEncryptor.EncryptPassword(nombre)).Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
    }
}

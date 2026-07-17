using datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica
{
    public static class UsuarioValidator
    {

            public static bool Preguntar(string Username)
            {
                consultarUsuario ex = new consultarUsuario();
                if (ex.sentencia(Username).Rows.Count > 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica
{
    public static class validarUsuarioExistente
    {
        public static bool ValidarUsuarioExistente(string Username)
        {
            DataTable dt = creardt.crear();

            foreach (DataRow row in dt.Rows)
            {
                if (Username == row[1].ToString())
                {
                    return true;
                }
            }
            return false;
        }
    }
}

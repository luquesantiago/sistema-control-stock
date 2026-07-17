using comun;
using datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica
{
    public static class BorrarinfoPersonal
    {
        public static bool borrar(int UserID)
        {

           BorrarInfoPersonal borrarInfoPersonal = new BorrarInfoPersonal();
            if (borrarInfoPersonal.Ejecutar(UserID))
            {

                return true;
            }
            return false;
        }
    }
}

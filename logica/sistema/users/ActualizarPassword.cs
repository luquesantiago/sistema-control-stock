using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using datos;
using comun;
using servicios;

namespace logica
{
    public static class ActualizarPassword
    {
        public static bool actualizar(string nombre ,string Password)
        {
            ActualizarContraseñas actualizarContraseñas = new ActualizarContraseñas();
            if( actualizarContraseñas.Ejecutar(nombre, Password))
            {
                Comun.Nuevo = false;
                return true;

            }
            return false;
        }

    }
}

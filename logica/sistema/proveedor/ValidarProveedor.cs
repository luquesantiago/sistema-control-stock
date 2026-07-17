using datos;
using datos.procedimientos_almacenados.proveedor;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica.sistema.proveedor
{
    public static class ValidarProveedor
    {
        public static bool Preguntar(string numerodocumento)
        {
            validarproveedor ex = new validarproveedor();
            if (ex.EjecutarYDevolver(numerodocumento).Rows.Count> 0)
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

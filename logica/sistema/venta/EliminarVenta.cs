using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using datos;
using datos.procedimientos_almacenados;

namespace logica.sistema.baja
{
    public static class EliminarVenta
    {
        public static bool eliminar(int idventa)
        {
            eliminarVenta eliminarventa = new eliminarVenta();
            return eliminarventa.EjecutarYDevolver(idventa);
        }
    }
}

using datos.procedimientos_almacenados.ingreso;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica.sistema.ingreso
{
    public static class EliminarOrdendecompra
    {
        public static bool eliminar(int idingreso)
        {
            eliminarOrdendecompra eliminar = new eliminarOrdendecompra();
            return eliminar.EjecutarYDevolver(idingreso);
        }
    }
}

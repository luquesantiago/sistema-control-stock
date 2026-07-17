using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using datos;
using datos.procedimientos_almacenados;

namespace logica.sistema
{
    public static class BuscarProveedorNumDocumento
    {
        public static DataTable Buscar(string textobuscar)
        {
            buscarProveedorNumDocumento buscarProveedor = new buscarProveedorNumDocumento();
            return buscarProveedor.EjecutarYDevolver(textobuscar);
        }
    }
}

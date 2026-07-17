using datos.procedimientos_almacenados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica.sistema.baja
{
    public static class EliminarCliente
    {
        public static bool eliminar(int nroDocumento)
        {
            Cliente cliente = new Cliente();
            return cliente.eliminarCliente(nroDocumento);
        }
    }
}

using datos.procedimientos_almacenados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica.sistema.cliente
{
    public static class ValidarCliente
    {
        public static bool Preguntar(string numerodocumento)
        {
            Cliente cliente = new Cliente();
            
            if (cliente.validarCliente(numerodocumento).Rows.Count > 0)
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

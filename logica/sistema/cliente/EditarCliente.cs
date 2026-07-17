using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using datos;
using datos.procedimientos_almacenados;

namespace logica.sistema.modificacion
{
    public static class EditarCliente
    {
        public static bool editar(string localidad, string nombre, DateTime fechadenacimiento, string tipodocumento, string numdocumento, int altura, string calle, string telefono, string gmail)
        {
            Cliente cliente = new Cliente();
            return cliente.editarCliente(localidad, nombre, fechadenacimiento,tipodocumento, numdocumento,altura, calle, telefono, gmail );
        }
    }
}

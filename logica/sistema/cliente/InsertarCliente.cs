using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using datos;
using datos.procedimientos_almacenados;

namespace logica.sistema.alta
{
    public static class InsertarCliente
    {
        public static bool insertar( string nombre, DateTime fechaNacimiento, string tipodocumento, string numdocumento, string telefono, string gmail, string calle, int altura, string localidad)
        {
            Cliente cliente = new Cliente();
            return cliente.insertarCliente(nombre, fechaNacimiento, tipodocumento, numdocumento, telefono, gmail, calle, altura, localidad);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using datos;
using datos.procedimientos_almacenados;

namespace logica.sistema.alta
{
    public class InsertarProveedor
    {
        public bool insertar(string localidad, string nombre, string sectorcomercial, string tipodocumento, string numdocumento, string calle, int altura, string telefono, string gmail, string tipotelefono)
        {
            insertarProveedor insertarproveedor = new insertarProveedor();
            return insertarproveedor.EjecutarYDevolver(localidad, nombre, sectorcomercial, tipodocumento, numdocumento, calle, altura, telefono, gmail, tipotelefono);
        }
    }
}

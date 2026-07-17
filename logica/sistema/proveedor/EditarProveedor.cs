using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using datos;
using datos.procedimientos_almacenados;

namespace logica.sistema.modificacion
{
    public class EditarProveedor
    {
        public bool editar(string localidad,string razonsocial_old,string razonSocial, string sectorComercial, string tipoDocumento, string numDocumento, string calle, int altura, string telefono, string gmail)
        {
            editarProveedor editarproveedor = new editarProveedor();
            return editarproveedor.EjecutarYDevolver(localidad,razonsocial_old,razonSocial, sectorComercial, tipoDocumento, numDocumento, calle, altura, telefono, gmail);
        }
    }
}

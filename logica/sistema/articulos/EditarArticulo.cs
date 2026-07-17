using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using datos;
using datos.procedimientos_almacenados;

namespace logica.sistema.modificacion
{
    public static class EditarArticulo
    {
        public static bool editar(string idarticulo, string nombre, string descripcion, string idcategoria, string prov, string puntoreaprov)
        {
            Articulos articulos = new Articulos();
            return articulos.editarArticulo(Convert.ToInt32( idarticulo), nombre, descripcion, Convert.ToInt32(idcategoria),prov,Convert.ToInt32( puntoreaprov));
        }
    }
}

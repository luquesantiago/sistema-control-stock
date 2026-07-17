using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using datos;
using datos.procedimientos_almacenados;
    
namespace logica.sistema.baja
{
    public static class EliminarArticulo
    {
        public static bool eliminar (int idarticulo)
        {
            Articulos articulos = new Articulos();
            return articulos.eliminarArticulo(idarticulo);
        }
    }
}

using datos.procedimientos_almacenados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica.sistema.baja
{
    public static class EliminarCategoria
    {
        public static bool eliminar(int idarticulo)
        {
            Categoria categoria = new Categoria();
            return categoria.eliiminarCategoria(idarticulo);
        }
    }
}

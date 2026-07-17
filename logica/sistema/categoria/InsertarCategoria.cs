using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using datos;
using datos.procedimientos_almacenados;

namespace logica.sistema.alta
{
    public static class InsertarCategoria
    {
        public static bool insertar(string nombre, string descripcion)
        {
            Categoria categoria = new Categoria();
            return categoria.insertarCategoria(nombre, descripcion);
        }

    }
}

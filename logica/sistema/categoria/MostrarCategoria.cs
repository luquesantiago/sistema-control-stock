using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using datos;
using datos.procedimientos_almacenados;

namespace logica.sistema
{
    public static class MostrarCategoria
    {
        public static DataTable mostrar()
        {
            Categoria categoria = new Categoria();
            return categoria.mostrarCategoria();
        }
    }
}
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
    public static class BuscarCategoria
    {
        public static DataTable Buscar(string textobuscar)
        {
            Categoria categoria = new Categoria();
            return categoria.buscarCategoria(textobuscar);
        }
    }
}

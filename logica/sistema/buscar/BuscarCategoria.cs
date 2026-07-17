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
    public class BuscarCategoria
    {
        public DataTable Buscar(string textobuscar)
        {
            buscarCategoria buscarcategoria = new buscarCategoria();
            return buscarcategoria.EjecutarYDevolver(textobuscar);
        }
    }
}

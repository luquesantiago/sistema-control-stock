using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using datos;
using datos.procedimientos_almacenados;


namespace logica.sistema.buscar
{
    public class BuscarArticuloVentaCodigo
    {
        public DataTable Buscar(string textobuscar)
        {
            buscarArticuloVentaCodigo buscarArticulo = new buscarArticuloVentaCodigo();
            return buscarArticulo.EjecutarYDevolver(textobuscar);
        }
    }
}

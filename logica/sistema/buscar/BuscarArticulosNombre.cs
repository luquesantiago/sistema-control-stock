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
    public class BuscarArticulosNombre
    {
        public DataTable Buscar(string textobuscar)
        { 
            buscarArticuloNombre buscarArticulo= new buscarArticuloNombre();
            return buscarArticulo.EjecutarYDevolver(textobuscar);
        }
    }
}

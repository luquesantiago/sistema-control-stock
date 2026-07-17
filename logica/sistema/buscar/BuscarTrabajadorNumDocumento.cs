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
    public class BuscarTrabajadorNumDocumento
    {
        public DataTable Buscar(string textobuscar)
        {
            buscarTrabajadorNumDocumento buscarTrabajador = new buscarTrabajadorNumDocumento();
            return buscarTrabajador.EjecutarYDevolver(textobuscar);
        }
    }
}

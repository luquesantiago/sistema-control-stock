using datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica
{
    public class MostrarLocalidad
    {
        public DataTable mostrar()
        {
            mostrarLocalidad localidad = new mostrarLocalidad();
            return localidad.EjecutarYDevolver();
        }
    }
}

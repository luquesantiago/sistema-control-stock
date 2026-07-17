using datos.procedimientos_almacenados;
using datos.procedimientos_almacenados.ingreso;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica.sistema.ingreso
{
    public class Mostrar_Ingreso
    {
        public static DataTable mostrar()
        {
            mostrar_Ingreso mostraringreso = new mostrar_Ingreso();
            return mostraringreso.EjecutarYDevolver();
        }
    }
}

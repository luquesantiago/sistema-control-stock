using datos.procedimientos_almacenados.ingreso;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica.sistema.ingreso
{
    public class buscar_Ingreso_Fecha
    {
        public static DataTable Buscar(DateTime fechainicio, DateTime fechafin)
        {
            Buscar_Ingreso_Fecha buscar_ingreso = new Buscar_Ingreso_Fecha();

            return buscar_ingreso.EjecutarYDevolver(fechainicio, fechafin);
        }
    }
}

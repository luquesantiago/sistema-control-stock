using datos.procedimientos_almacenados.ingreso;
using datos.procedimientos_almacenados.venta;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica.sistema.venta
{
    public class Buscar_venta_fecha
    {
        public static DataTable Buscar(DateTime fechainicio, DateTime fechafin)
        {
            Buscar_Venta_Fecha buscar = new Buscar_Venta_Fecha();

            return buscar.EjecutarYDevolver(fechainicio, fechafin);
        }
    }
}

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
    public static class Buscar_ordendecompra_fecha
    {
        public static DataTable Buscar(DateTime fechainicio,DateTime fechafin)
        {
            Buscar_ordendecompra_Fecha buscar_ingreso_fecha = new Buscar_ordendecompra_Fecha();
        
            return buscar_ingreso_fecha.EjecutarYDevolver(fechainicio,fechafin);
        }
    }
}

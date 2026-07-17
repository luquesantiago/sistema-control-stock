using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datos.procedimientos_almacenados.ingreso
{
    public class Buscar_ordendecompra_Fecha
    {
        public DataTable EjecutarYDevolver(DateTime fechainicio,DateTime fechafin )
        {
            ejecutar_procedimientos__almacenados ejecutar_Procedimientos__Almacenados = new ejecutar_procedimientos__almacenados();

            SqlParameter[] parametros = new SqlParameter[]
            {
            new SqlParameter("@fechaInicio", SqlDbType.Date) { Value = fechainicio },
            new SqlParameter("@fechaFin", SqlDbType.Date)    { Value = fechafin },
            };
            return ejecutar_Procedimientos__Almacenados.EjecutarProcedimientoYDevolverDataTable("spbuscar_ingreso_fecha", parametros);
        }
    }
}

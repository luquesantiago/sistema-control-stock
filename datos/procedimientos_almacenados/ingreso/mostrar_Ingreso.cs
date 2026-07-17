using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datos.procedimientos_almacenados.ingreso
{
    public class mostrar_Ingreso
    {
        public DataTable EjecutarYDevolver()
        {
            ejecutar_procedimientos__almacenados ejecutar_Procedimientos__Almacenados = new ejecutar_procedimientos__almacenados();

            SqlParameter[] parametros = new SqlParameter[]
            {
            };
            return ejecutar_Procedimientos__Almacenados.EjecutarProcedimientoYDevolverDataTable("spmostrar_ingreso_confirmado", parametros);
        }
    }
}

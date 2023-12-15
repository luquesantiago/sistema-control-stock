using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datos.procedimientos_almacenados.proveedor
{
    public class validarproveedor
    {
        public DataTable EjecutarYDevolver(string numerodoc)
        {
            ejecutar_procedimientos__almacenados ejecutar_Procedimientos__Almacenados = new ejecutar_procedimientos__almacenados();

            SqlParameter[] parametros = new SqlParameter[]
            {
                 new SqlParameter("@numero_documento", SqlDbType.NVarChar) { Value = numerodoc},
            };
            return ejecutar_Procedimientos__Almacenados.EjecutarProcedimientoYDevolverDataTable("spvalidarprov", parametros);
        }
    }
}

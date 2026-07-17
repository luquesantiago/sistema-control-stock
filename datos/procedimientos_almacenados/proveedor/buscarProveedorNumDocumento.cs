using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datos.procedimientos_almacenados
{
    public class buscarProveedorNumDocumento
    {
        public DataTable EjecutarYDevolver(string textobuscar)
        {
            ejecutar_procedimientos__almacenados ejecutar_Procedimientos__Almacenados = new ejecutar_procedimientos__almacenados();

            SqlParameter[] parametros = new SqlParameter[]
            {
            new SqlParameter("@textobuscar", SqlDbType.VarChar) { Value = textobuscar },

            };
            return ejecutar_Procedimientos__Almacenados.EjecutarProcedimientoYDevolverDataTable("spbuscar_proveedor_num_documento", parametros);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datos.procedimientos_almacenados.venta
{
    public class MostrarPrecio
    {
        public DataTable EjecutarYDevolver(int idarticulo)
        {
            ejecutar_procedimientos__almacenados ejecutar_Procedimientos__Almacenados = new ejecutar_procedimientos__almacenados();

            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@idarticulo", SqlDbType.Int) { Value = idarticulo},
            };
            return ejecutar_Procedimientos__Almacenados.EjecutarProcedimientoYDevolverDataTable("spmostrar_precio", parametros);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datos.procedimientos_almacenados
{
    public class eliminarVenta
    {
        public bool EjecutarYDevolver(int idventa)
        {
            try
            {
                ejecutar_procedimientos__almacenados ejecutar_Procedimientos__Almacenados = new ejecutar_procedimientos__almacenados();

                SqlParameter[] parametros = new SqlParameter[]
                {
                     new SqlParameter("@idventa", SqlDbType.Int) { Value = idventa},

                };
                ejecutar_Procedimientos__Almacenados.EjecutarProcedimiento("speliminar_venta", parametros);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datos.procedimientos_almacenados.ingreso
{
    public class eliminarOrdendecompra
    {
        public bool EjecutarYDevolver(int idingreso)
        {
            try
            {
                ejecutar_procedimientos__almacenados ejecutar_Procedimientos__Almacenados = new ejecutar_procedimientos__almacenados();

                SqlParameter[] parametros = new SqlParameter[]
                {
                     new SqlParameter("@idingreso", SqlDbType.Int) { Value = idingreso},

                };
                ejecutar_Procedimientos__Almacenados.EjecutarProcedimiento("speliminar_ingreso", parametros);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datos.procedimientos_almacenados
{
    public class editarUsers
    {
        public bool EjecutarYDevolver(int userid, bool bloqueado,string username,string permiso, DateTime fechaFin)
        {

            try
            {
                ejecutar_procedimientos__almacenados ejecutar_Procedimientos__Almacenados = new ejecutar_procedimientos__almacenados();

                SqlParameter[] parametros = new SqlParameter[]
                {
                     new SqlParameter("@UserID", SqlDbType.Int) { Value = userid},
                     new SqlParameter("@bloqueado", SqlDbType.Bit) { Value = bloqueado },
                     new SqlParameter("@username", SqlDbType.NVarChar) { Value = username },
                     new SqlParameter("@Permiso", SqlDbType.NVarChar) { Value = permiso},
                     new SqlParameter("@fechaFin", SqlDbType.DateTime) { Value = fechaFin},

                };
                ejecutar_Procedimientos__Almacenados.EjecutarProcedimiento("speditar_users", parametros);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datos.procedimientos_almacenados
{
    public class eliminarProveedor
    {

        public bool EjecutarYDevolver(int numerodoc)
        {
            try
            {
                ejecutar_procedimientos__almacenados ejecutar_Procedimientos__Almacenados = new ejecutar_procedimientos__almacenados();

                SqlParameter[] parametros = new SqlParameter[]
                {
                     new SqlParameter("@numeroDoc", SqlDbType.VarChar) { Value = numerodoc},

                };
                ejecutar_Procedimientos__Almacenados.EjecutarProcedimiento("speliminar_proveedor", parametros);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datos
{
    public class ejecutar_procedimientos__almacenados:conn
    {
        public void EjecutarProcedimiento(string nombreProcedimiento, params SqlParameter[] parametros)
        {
            using (SqlConnection conexion = crear())
            {
                using (SqlCommand comando = new SqlCommand(nombreProcedimiento, conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    if (parametros != null)
                    {
                        comando.Parameters.AddRange(parametros);
                    }

                    conexion.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }
        public DataTable EjecutarProcedimientoYDevolverDataTable(string nombreProcedimiento, params SqlParameter[] parametros)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection conexion = crear())
            {
                using (SqlCommand comando = new SqlCommand(nombreProcedimiento, conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    if (parametros != null)
                    {
                        comando.Parameters.AddRange(parametros);
                    }

                    conexion.Open();

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        dataTable.Load(reader);
                    }
                }
            }

            return dataTable;
        }
    }
}

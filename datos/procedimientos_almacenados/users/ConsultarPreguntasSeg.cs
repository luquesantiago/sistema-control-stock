using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datos
{
    public class ConsultarPreguntasSeg:conn
    {
        public DataTable sentencia(string Username, string pregunta,string respuesta)
        {
            using (SqlConnection conexion = crear())
            {
                using (SqlCommand command = new SqlCommand("spConsultarPreguntasSeguridad", conexion))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@nombre", Username);
                    command.Parameters.AddWithValue("@pregunta", pregunta);
                    command.Parameters.AddWithValue("@respuesta", respuesta);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }
    }
}

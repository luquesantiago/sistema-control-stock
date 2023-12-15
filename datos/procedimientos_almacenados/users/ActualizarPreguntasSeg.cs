using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datos
{
    public class ActualizarPreguntasSeg:conn
    {
        public bool Ejecutar(string nombre, string pregunta, string respuesta)
        {
            try
            {
                using (SqlConnection conexion = crear())
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand("spActualizarPreguntaSeguridad", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@nombre", nombre);
                        comando.Parameters.AddWithValue("@pregunta", pregunta);
                        comando.Parameters.AddWithValue("@respuesta", respuesta);
                        comando.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}

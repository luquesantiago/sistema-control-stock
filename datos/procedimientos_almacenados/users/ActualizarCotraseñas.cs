using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datos
{
    public class ActualizarContraseñas:conn
    {
        public bool Ejecutar(string nombre, string password)
        {
            try
            {
                using (SqlConnection conexion = crear())
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand("spActualizarContraseñas", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@nombre", nombre);
                        comando.Parameters.AddWithValue("@Password", password);
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

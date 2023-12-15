using System;
using System.Data;
using System.Data.SqlClient;

namespace datos
{
    public class ActualizarDatosU:conn
    {
        public bool Ejecutar(bool bloqueado,int userID, string username, string permiso, DateTime fechaFin)
        {
            try
            {
                using (SqlConnection conexion = crear())
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand("spActualizarUser", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@UserID", userID);
                        comando.Parameters.AddWithValue("@Username", username);
                        comando.Parameters.AddWithValue("@Permiso", permiso);
                        comando.Parameters.AddWithValue("@FechaFin", fechaFin);
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

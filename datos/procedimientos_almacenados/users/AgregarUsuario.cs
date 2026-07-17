using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace datos
{
    public class AgregarUsuario : conn
    {
        public bool nuevo(string username, string password, string nombre, string gmail, string numeroTelefono, string tipoTelefono, DateTime fechaInicio, DateTime fechaFin, string permiso, string localidad)
        {
            try
            {

                using (SqlConnection conexion = crear())
                {
                    conexion.Open();


                    SqlCommand command = new SqlCommand("spAgregarUsuario", conexion);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Gmail", gmail);
                    command.Parameters.AddWithValue("@NumeroTelefono", numeroTelefono);
                    command.Parameters.AddWithValue("@TipoTelefono", tipoTelefono);
                    command.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                    command.Parameters.AddWithValue("@FechaFin", fechaFin);
                    command.Parameters.AddWithValue("@Permiso", permiso);
                    command.Parameters.AddWithValue("@localidad", localidad);


                    command.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}

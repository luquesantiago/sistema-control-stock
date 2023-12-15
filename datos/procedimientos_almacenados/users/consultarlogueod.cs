            
using System.Data;
using System.Data.SqlClient;

namespace datos
{
    public class consultarlogueod:conn
    {
        public DataTable sentencia(string Username, string Password)
        {
            using (SqlConnection conexion = crear())
            {
                using (SqlCommand command = new SqlCommand("spConsultarLogueo", conexion))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Username", Username);
                    command.Parameters.AddWithValue("@Password", Password);

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

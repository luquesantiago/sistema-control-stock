using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datos.consultar
{
    public class ConsultarContraseñasRep:conn
    {
        public DataTable sentencia(string nombre,string Password)
        {
            using (SqlConnection conexion = crear())
            {
                using (SqlCommand command = new SqlCommand("spConsultarContraseñasRepetidas", conexion))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@nombre", nombre);
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

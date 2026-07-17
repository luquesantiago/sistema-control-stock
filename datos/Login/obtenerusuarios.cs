using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datos
{
    public class obtenerusuarios:conn
    {
        public DataTable sentencia()
        {

                using (SqlConnection conexion = crear())
                {
                    using (SqlCommand command = new SqlCommand("spobtenerUsuarios", conexion))
                    {
                        command.CommandType = CommandType.StoredProcedure;
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


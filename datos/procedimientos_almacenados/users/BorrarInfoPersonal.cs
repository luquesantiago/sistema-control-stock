using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datos
{
    public class BorrarInfoPersonal:conn
    {
        public bool Ejecutar(int UserID)
        {
            try
            {
                using (SqlConnection conexion = crear())
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand("spBorrarInfoPersonal", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@UsesrID", UserID);
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

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datos
{
    public class ActualizarConfigSis:conn
    {
        public bool Ejecutar(bool Minchar ,bool MayusyMin ,bool Especiales,bool Validacion ,bool repetirC)
        {
            try
            {
                using (SqlConnection conexion = crear())
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand("spActualizarConfiguracionSistema", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@Minchar", Minchar);
                        comando.Parameters.AddWithValue("@MayusyMin", MayusyMin);
                        comando.Parameters.AddWithValue("@Especiales",Especiales);
                        comando.Parameters.AddWithValue("@Validacion",Validacion);
                        comando.Parameters.AddWithValue("@RepetirC",repetirC);
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

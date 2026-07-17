using System.Configuration;
using System.Data.SqlClient;

namespace datos
{
    public abstract class conn
    {
        // La cadena de conexión se define en el App.config del proyecto Login
        // (connectionStrings → "dbventas") para no hardcodear datos del entorno.
        private static readonly string cadena =
            ConfigurationManager.ConnectionStrings["dbventas"].ConnectionString;

        public SqlConnection crear()
        {
            return new SqlConnection(cadena);
        }
    }
}

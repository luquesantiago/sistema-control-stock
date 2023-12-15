using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace datos
{
    public abstract class conn
    {
        // Cadena para la compu de casa
        //private static string cadena = "Server=TOSTADORA3\\SQLEXPRESS;Database=dbventas;Integrated Security=True;";

        // Cadena para la nesbu
        private static string cadena = "Server=TOSTADORA3\\SQLEXPRESS;Database=dbventas;Integrated Security=True;";


        public SqlConnection crear()
        {
            return new SqlConnection(cadena);
        }
    }
}

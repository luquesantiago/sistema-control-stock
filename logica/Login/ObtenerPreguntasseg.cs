using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using datos;

namespace logica
{
    public static class ObtenerPreguntasseg
    {
        public static DataTable pregunta(string username)
        {
            ObtenerPreguntaSeg obtenerPreguntaSeg= new ObtenerPreguntaSeg();
            DataTable dt = obtenerPreguntaSeg.obtener(username);

            return dt;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using datos;

namespace logica
{
    public static class ConsultarPreguntasseg
    {
        public static bool coincide(string username,string pregunta, string respuesta)
        {
        ConsultarPreguntasSeg consultarPreguntasSeg = new ConsultarPreguntasSeg();
           if( consultarPreguntasSeg.sentencia(username, pregunta, respuesta).Rows.Count > 0)
            {
                return true;
            }
           return false;
        }

    }
}

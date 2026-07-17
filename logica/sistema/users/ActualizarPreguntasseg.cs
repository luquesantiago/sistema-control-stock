using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using datos;
using comun;

namespace logica
{
    public static class ActualizarPreguntasseg
    {
        public static bool actualizar(string pregunta,string respuesta)
        {

            ActualizarPreguntasSeg actualizarPreguntasSeg = new ActualizarPreguntasSeg();
           if(actualizarPreguntasSeg.Ejecutar(Comun.NombreUsuario, pregunta, respuesta))
            {
                return true;
            }
            return false;
        }
    }
}

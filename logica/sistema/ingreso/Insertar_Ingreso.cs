using datos.procedimientos_almacenados.ingreso;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica.sistema.ingreso
{
    public class Insertar_Ingreso
    {
        public static bool insertar(string tipo ,string numero, string idingreso, DateTime produccion, DateTime vencimiento)
        {
            
            insertar_ingreso insertar_ing = new insertar_ingreso();
            return insertar_ing.EjecutarYDevolver(tipo, Convert.ToInt32(numero), Convert.ToInt32(idingreso),produccion,vencimiento);


        }
    }
}

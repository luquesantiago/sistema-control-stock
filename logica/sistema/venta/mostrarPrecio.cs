using datos.procedimientos_almacenados;
using datos.procedimientos_almacenados.venta;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica.sistema.venta
{
    public class mostrarPrecio
    {
        public static double mostrar(string idarticulo)
        {
            MostrarPrecio mostrar = new MostrarPrecio();
            
            return  Convert.ToDouble( mostrar.EjecutarYDevolver(Convert.ToInt32( idarticulo)).Rows[0][0]);
        }
    }
}

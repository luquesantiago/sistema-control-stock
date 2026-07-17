using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using datos;
using datos.procedimientos_almacenados;

namespace logica.sistema.alta
{
    public class InsertarVenta
    {
        public bool insertar(int idcliente, int UserID, DateTime fecha, string tipo_comprobante, int numero, int idarticulo, int cantidad)
        {
            insertarVenta insertarventa = new insertarVenta();
            return insertarventa.EjecutarYDevolver(idcliente, UserID, fecha, tipo_comprobante,numero,idarticulo,cantidad);
        }
    }
}

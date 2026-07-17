using comun;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica.sistema.venta
{
    public class carritoVenta
    {
      
        public static DataTable CrearDataTableCarrito(List<carrito> listaCarrito)
        {
            DataTable dt = new DataTable();

            // Agregar columnas al DataTable
            dt.Columns.Add("Fecha", typeof(DateTime));
            dt.Columns.Add("Usuario", typeof(string));
            dt.Columns.Add("IdCliente", typeof(int));
            dt.Columns.Add("Cliente", typeof(string));
            dt.Columns.Add("IdArticulo", typeof(int));
            dt.Columns.Add("Articulo", typeof(string));
            dt.Columns.Add("cantidad", typeof(int));
            dt.Columns.Add("PrecioVenta", typeof(double));
            dt.Columns.Add("Total", typeof(double));
            dt.Columns.Add("TipoComprobante", typeof(string));
            dt.Columns.Add("Numero_Comprobante", typeof(int));
          
           

            // Agregar filas al DataTable
            foreach (var carrito in listaCarrito)
            {
                dt.Rows.Add(
                    carrito.fecha,
                    carrito.users,
                     carrito.idcliente,
                    carrito.cliente,
                    carrito.idarticulo,
                    carrito.articulo,
                    carrito.stock_ingreso,
                    carrito.precio,
                    carrito.total,
                    carrito.tipo_comprobante,
                    carrito.Numero_Comprobante
                   
                );
            }

            return dt;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using comun;
namespace logica.sistema
{
    public static class carritoIngreso
    {
 
        public static DataTable CrearDataTableCarrito(List<carrito> listaCarrito)
        {
            DataTable dt = new DataTable();

            // Agregar columnas al DataTable
            dt.Columns.Add("Fecha", typeof(DateTime));
            dt.Columns.Add("Usuario", typeof(string));
            dt.Columns.Add("IdProveedor", typeof(int));
            dt.Columns.Add("Proveedor", typeof(string));
            dt.Columns.Add("IdArticulo", typeof(int));
            dt.Columns.Add("Articulo", typeof(string));
            dt.Columns.Add("StockIngreso", typeof(int));
            dt.Columns.Add("PrecioCompra", typeof(int));
            dt.Columns.Add("Total", typeof(int));


            // Agregar filas al DataTable
            foreach (var carrito in listaCarrito)
            {
                dt.Rows.Add(
                    carrito.fecha,
                    carrito.users,
                    carrito.idproveedor,
                    carrito.proveedor,
                    carrito.idarticulo,
                    carrito.articulo,
                    carrito.stock_ingreso,
                    carrito.precio,
                    carrito.total

                );
            }

            return dt;
        }
    }
}

using comun;
using datos.procedimientos_almacenados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica.sistema
{
    public static class carritoconfig
    {
        private static List<carrito> listaCarrito = new List<carrito>();
        public static void AgregarElementoCarrito(carrito nuevoCarrito)
        {
            listaCarrito.Add(nuevoCarrito);
        }
        public static List<carrito> ObtenerListaCarrito()
        {
            return listaCarrito;
        }
        public static void EliminarElementoCarrito(int index)
        {
            listaCarrito.RemoveAt(index);
        }
        public static bool agregar_carrito_al_historial_ingreso()
        {
            try
            {
                foreach (var carrito in listaCarrito)
                {
                    insertar_Ordendecompra insertaringreso = new insertar_Ordendecompra();
                    insertaringreso.EjecutarYDevolver(Comun.UserID, carrito.idproveedor, carrito.fecha, carrito.idarticulo, carrito.precio, carrito.stock_ingreso, carrito.total);
                }
                    vaciar_carrito();               
                    return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static bool agregar_carrito_al_historial_venta()
        {
            try
            {
                foreach (var carrito in listaCarrito)
                {
                    insertarVenta insertarventa = new insertarVenta();
                    insertarventa.EjecutarYDevolver(carrito.idcliente, Comun.UserID,  carrito.fecha, carrito.tipo_comprobante, carrito.Numero_Comprobante,carrito.idarticulo, carrito.stock_ingreso);
                }
                vaciar_carrito();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static void vaciar_carrito()
        {
            listaCarrito.Clear();
        }

    }
}

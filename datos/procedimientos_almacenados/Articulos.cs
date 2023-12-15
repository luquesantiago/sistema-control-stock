using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datos.procedimientos_almacenados
{
    public class Articulos
    {
            public DataTable avisoStock()
            {
                ejecutar_procedimientos__almacenados ejecutar_Procedimientos__Almacenados = new ejecutar_procedimientos__almacenados();

                SqlParameter[] parametros = new SqlParameter[]
                {
                };
                return ejecutar_Procedimientos__Almacenados.EjecutarProcedimientoYDevolverDataTable("spaviso_stock", parametros);
            }
            public DataTable stockArticulos(int idarticulo)
            {
                ejecutar_procedimientos__almacenados ejecutar_Procedimientos__Almacenados = new ejecutar_procedimientos__almacenados();

                SqlParameter[] parametros = new SqlParameter[]
                {
                new SqlParameter("@idarticulo", SqlDbType.Int) { Value = idarticulo },
                };
                return ejecutar_Procedimientos__Almacenados.EjecutarProcedimientoYDevolverDataTable("spmostrar_stock_articulo", parametros);
            }
            public DataTable buscarArticuloNombre(string textobuscar)
            {
                ejecutar_procedimientos__almacenados ejecutar_Procedimientos__Almacenados = new ejecutar_procedimientos__almacenados();

                SqlParameter[] parametros = new SqlParameter[]
                {
            new SqlParameter("@textobuscar", SqlDbType.VarChar) { Value = textobuscar },

                };
                return ejecutar_Procedimientos__Almacenados.EjecutarProcedimientoYDevolverDataTable("spbuscar_articulo_nombre", parametros);
            }
            public DataTable mostrarArticulo()
            {
                ejecutar_procedimientos__almacenados ejecutar_Procedimientos__Almacenados = new ejecutar_procedimientos__almacenados();

                SqlParameter[] parametros = new SqlParameter[]
                {
                };
                return ejecutar_Procedimientos__Almacenados.EjecutarProcedimientoYDevolverDataTable("spmostrar_articulo", parametros);
            }
            public DataTable mostrarArticuloCbo(int idprov)
            {
                ejecutar_procedimientos__almacenados ejecutar_Procedimientos__Almacenados = new ejecutar_procedimientos__almacenados();

                SqlParameter[] parametros = new SqlParameter[]
                {
            new SqlParameter("@idprov", SqlDbType.Int) { Value = idprov },

                };
                return ejecutar_Procedimientos__Almacenados.EjecutarProcedimientoYDevolverDataTable("spmostrar_articulo_combo", parametros);
            }
            public bool insertarArticulo(string nombre, string descripcion, int idcategoria, string prov, int puntoreaprov)
            {
                try
                {
                    ejecutar_procedimientos__almacenados ejecutar_Procedimientos__Almacenados = new ejecutar_procedimientos__almacenados();

                    SqlParameter[] parametros = new SqlParameter[]
                    {
                     new SqlParameter("@nombre", SqlDbType.VarChar) { Value = nombre},
                     new SqlParameter("@descripcion", SqlDbType.VarChar) { Value = descripcion},
                     new SqlParameter("@idcategoria", SqlDbType.Int) { Value = idcategoria},
                     new SqlParameter("@proveedor", SqlDbType.VarChar) { Value = prov},
                     new SqlParameter("@puntoreaprov", SqlDbType.Int) { Value = puntoreaprov},
                    };
                    ejecutar_Procedimientos__Almacenados.EjecutarProcedimiento("spinsertar_articulo", parametros);
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }

            }
            public bool eliminarArticulo(int idarticulo)
            {
                try
                {
                    ejecutar_procedimientos__almacenados ejecutar_Procedimientos__Almacenados = new ejecutar_procedimientos__almacenados();

                    SqlParameter[] parametros = new SqlParameter[]
                    {
                     new SqlParameter("@idarticulo", SqlDbType.Int) { Value = idarticulo},

                    };
                    ejecutar_Procedimientos__Almacenados.EjecutarProcedimiento("speliminar_articulo", parametros);
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }

            }
            public bool editarArticulo(int idarticulo, string nombre, string descripcion, int idcategoria, string prov, int puntoreaprov)
            {
                try
                {
                    ejecutar_procedimientos__almacenados ejecutar_Procedimientos__Almacenados = new ejecutar_procedimientos__almacenados();

                    SqlParameter[] parametros = new SqlParameter[]
                    {
                     new SqlParameter("@idarticulo", SqlDbType.Int) { Value = idarticulo },
                     new SqlParameter("@nombre", SqlDbType.VarChar) { Value = nombre },
                     new SqlParameter("@descripcion", SqlDbType.VarChar) { Value = descripcion },
                     new SqlParameter("@idcategoria", SqlDbType.Int) { Value = idcategoria },
                     new SqlParameter("@proveedor", SqlDbType.VarChar) { Value = prov },
                     new SqlParameter("@puntoreaprov", SqlDbType.Int) { Value = puntoreaprov},
                    };
                    ejecutar_Procedimientos__Almacenados.EjecutarProcedimiento("speditar_articulo", parametros);
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }

            }






    }
}



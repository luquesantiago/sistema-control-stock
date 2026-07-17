using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datos.procedimientos_almacenados
{
    public class Categoria
    {
        public DataTable buscarCategoria(string textobuscar)
        {
            ejecutar_procedimientos__almacenados ejecutar_Procedimientos__Almacenados = new ejecutar_procedimientos__almacenados();

            SqlParameter[] parametros = new SqlParameter[]
            {
            new SqlParameter("@textobuscar", SqlDbType.VarChar) { Value = textobuscar },

            };
            return ejecutar_Procedimientos__Almacenados.EjecutarProcedimientoYDevolverDataTable("spbuscar_categoria", parametros);
        }
        public DataTable mostrarCategoria()
        {
            ejecutar_procedimientos__almacenados ejecutar_Procedimientos__Almacenados = new ejecutar_procedimientos__almacenados();

            SqlParameter[] parametros = new SqlParameter[]
            {
            };
            return ejecutar_Procedimientos__Almacenados.EjecutarProcedimientoYDevolverDataTable("spmostrar_categoria", parametros);
        }
        public bool insertarCategoria(string nombre, string descripcion)
        { 
            try
            {
                ejecutar_procedimientos__almacenados ejecutar_Procedimientos__Almacenados = new ejecutar_procedimientos__almacenados();

                SqlParameter[] parametros = new SqlParameter[]
                {

                     new SqlParameter("@nombre", SqlDbType.VarChar) { Value = nombre},
                     new SqlParameter("@descripcion", SqlDbType.VarChar) { Value = descripcion},

                };
                ejecutar_Procedimientos__Almacenados.EjecutarProcedimiento("spinsertar_categoria", parametros);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public bool editar_Categoria(int idcategoria, string nombre, string descripcion)
        {
            try
            {
                ejecutar_procedimientos__almacenados ejecutar_Procedimientos__Almacenados = new ejecutar_procedimientos__almacenados();

                SqlParameter[] parametros = new SqlParameter[]
                {
                     new SqlParameter("@idcategoria", SqlDbType.Int) { Value = idcategoria },
                     new SqlParameter("@nombre", SqlDbType.VarChar) { Value = nombre },
                     new SqlParameter("@descripcion", SqlDbType.VarChar) { Value = descripcion },

                };
                ejecutar_Procedimientos__Almacenados.EjecutarProcedimiento("speditar_categoria", parametros);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public bool eliiminarCategoria(int idcategoria)
        {
            try
            {
                ejecutar_procedimientos__almacenados ejecutar_Procedimientos__Almacenados = new ejecutar_procedimientos__almacenados();

                SqlParameter[] parametros = new SqlParameter[]
                {
                     new SqlParameter("@idcategoria", SqlDbType.Int) { Value = idcategoria},

                };
                ejecutar_Procedimientos__Almacenados.EjecutarProcedimiento("speliminar_categoria", parametros);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

    }
}



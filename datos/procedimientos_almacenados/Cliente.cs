using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datos.procedimientos_almacenados
{
    public class Cliente
    {
        public DataTable mostrarCliente()
        {
            ejecutar_procedimientos__almacenados ejecutar_Procedimientos__Almacenados = new ejecutar_procedimientos__almacenados();

            SqlParameter[] parametros = new SqlParameter[]
            {
            };
            return ejecutar_Procedimientos__Almacenados.EjecutarProcedimientoYDevolverDataTable("spmostrar_cliente", parametros);
        }
        public DataTable buscarClienteNumDocumento(string textobuscar)
        {
            ejecutar_procedimientos__almacenados ejecutar_Procedimientos__Almacenados = new ejecutar_procedimientos__almacenados();

            SqlParameter[] parametros = new SqlParameter[]
            {
            new SqlParameter("@textobuscar", SqlDbType.VarChar) { Value = textobuscar },

            };
            return ejecutar_Procedimientos__Almacenados.EjecutarProcedimientoYDevolverDataTable("spbuscar_cliente_num_documento", parametros);
        }
    
        public bool editarCliente(string localidad, string nombre, DateTime fechadenacimiento, string tipodocumento, string numdocumento, int altura, string calle, string telefono, string gmail)
    {
        try
        {
            ejecutar_procedimientos__almacenados ejecutar_Procedimientos__Almacenados = new ejecutar_procedimientos__almacenados();

            SqlParameter[] parametros = new SqlParameter[]
            {
                     new SqlParameter("@localidad", SqlDbType.NVarChar) { Value = localidad },
                     new SqlParameter("@nombre", SqlDbType.VarChar) { Value = nombre },
                     new SqlParameter("@fecha_nacimiento", SqlDbType.DateTime) { Value = fechadenacimiento },
                     new SqlParameter("@tipo_documento", SqlDbType.VarChar) { Value =tipodocumento},
                     new SqlParameter("@num_documento", SqlDbType.VarChar) { Value = numdocumento },
                     new SqlParameter("@altura", SqlDbType.Int) { Value = altura},
                     new SqlParameter("@calle", SqlDbType.VarChar) { Value = calle },
                     new SqlParameter("@telefono", SqlDbType.VarChar) { Value = telefono },
                     new SqlParameter("@gmail", SqlDbType.VarChar) { Value = gmail},
            };
            ejecutar_Procedimientos__Almacenados.EjecutarProcedimiento("speditar_cliente", parametros);
            return true;
        }
        catch (Exception)
        {
            return false;
        }

    }
        public bool eliminarCliente(int nroDocumento)
    {
        try
        {
            ejecutar_procedimientos__almacenados ejecutar_Procedimientos__Almacenados = new ejecutar_procedimientos__almacenados();

            SqlParameter[] parametros = new SqlParameter[]
            {
                     new SqlParameter("@nroDocumento", SqlDbType.Int) { Value = nroDocumento},

            };
            ejecutar_Procedimientos__Almacenados.EjecutarProcedimiento("speliminar_cliente", parametros);
            return true;
        }
        catch (Exception)
        {
            return false;
        }

    }
        public bool insertarCliente(string nombre, DateTime fechaNacimiento, string tipodocumento, string numdocumento, string telefono, string gmail, string calle, int altura, string localidad)
    {
        try
        {
            ejecutar_procedimientos__almacenados ejecutar_Procedimientos__Almacenados = new ejecutar_procedimientos__almacenados();

            SqlParameter[] parametros = new SqlParameter[]
            {
                     new SqlParameter("@nombre", SqlDbType.VarChar) { Value = nombre},
                     new SqlParameter("@fecha_nacimiento", SqlDbType.DateTime) { Value = fechaNacimiento},
                     new SqlParameter("@tipo_documento", SqlDbType.VarChar) { Value = tipodocumento},
                     new SqlParameter("@num_documento", SqlDbType.VarChar) { Value = numdocumento},
                     new SqlParameter("@telefono", SqlDbType.VarChar) { Value = telefono},
                     new SqlParameter("@gmail", SqlDbType.VarChar) { Value = gmail},
                     new SqlParameter("@calle", SqlDbType.VarChar) { Value = calle},
                     new SqlParameter("@altura", SqlDbType.Int) { Value = altura},
                     new SqlParameter("@localidad", SqlDbType.VarChar) { Value = localidad},
            };
            ejecutar_Procedimientos__Almacenados.EjecutarProcedimiento("spinsertar_cliente", parametros);
            return true;
        }
        catch (Exception)
        {
            return false;
        }

    }
        
        public DataTable validarCliente(string numerodoc)
        {
            ejecutar_procedimientos__almacenados ejecutar_Procedimientos__Almacenados = new ejecutar_procedimientos__almacenados();

            SqlParameter[] parametros = new SqlParameter[]
            {
                 new SqlParameter("@numero_documento", SqlDbType.NVarChar) { Value = numerodoc},
            };
            return ejecutar_Procedimientos__Almacenados.EjecutarProcedimientoYDevolverDataTable("spvalidarcliente", parametros);
        }

    }
}



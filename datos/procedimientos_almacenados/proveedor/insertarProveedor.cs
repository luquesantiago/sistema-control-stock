using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datos.procedimientos_almacenados
{
    public class insertarProveedor
    {
        public bool EjecutarYDevolver(string localidad, string nombre, string sectorcomercial, string tipodocumento, string numdocumento, string calle, int altura, string telefono, string gmail, string tipotelefono)
        {
            try
            {
                ejecutar_procedimientos__almacenados ejecutar_Procedimientos__Almacenados = new ejecutar_procedimientos__almacenados();

                SqlParameter[] parametros = new SqlParameter[]
                {
                     new SqlParameter("@nombre", SqlDbType.VarChar) { Value = nombre},
                     new SqlParameter("@localidad", SqlDbType.VarChar) { Value = localidad},
                     new SqlParameter("@sector_comercial", SqlDbType.VarChar) { Value = sectorcomercial},
                     new SqlParameter("@tipo_documento", SqlDbType.VarChar) { Value = tipodocumento},
                     new SqlParameter("@num_documento", SqlDbType.VarChar) { Value = numdocumento},
                     new SqlParameter("@calle", SqlDbType.VarChar) { Value = calle},
                     new SqlParameter("@altura", SqlDbType.Int) { Value = altura},
                     new SqlParameter("@telefono", SqlDbType.VarChar) { Value = telefono},
                        new SqlParameter("@Gmail", SqlDbType.VarChar) { Value = gmail},
                     new SqlParameter("@TipoTelefono", SqlDbType.NVarChar) { Value = tipotelefono},
                };
                ejecutar_Procedimientos__Almacenados.EjecutarProcedimiento("spinsertar_proveedor", parametros);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}

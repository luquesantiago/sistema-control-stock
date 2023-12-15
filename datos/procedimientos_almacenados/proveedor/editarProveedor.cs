using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace datos.procedimientos_almacenados
{
    public class editarProveedor
    {
        public bool EjecutarYDevolver(string localidad,string razonsocial_old, string razonSocial,string sectorComercial, string tipoDocumento, string numDocumento, string calle,int altura, string telefono, string gmail)
        {
            try
            {
                ejecutar_procedimientos__almacenados ejecutar_Procedimientos__Almacenados = new ejecutar_procedimientos__almacenados();

                SqlParameter[] parametros = new SqlParameter[]
                {
                     new SqlParameter("@localidad", SqlDbType.NVarChar) { Value = localidad},
                     new SqlParameter("@razon_social_old", SqlDbType.VarChar) { Value = razonsocial_old },
                     new SqlParameter("@razon_social", SqlDbType.VarChar) { Value = razonSocial },
                     new SqlParameter("@sector_comercial", SqlDbType.VarChar) { Value = sectorComercial},
                     new SqlParameter("@tipo_documento", SqlDbType.VarChar) { Value = tipoDocumento },
                     new SqlParameter("@num_documento", SqlDbType.VarChar) { Value = numDocumento },
                     new SqlParameter("@calle", SqlDbType.VarChar) { Value = calle},
                     new SqlParameter("@altura", SqlDbType.Int) { Value = altura },
                     new SqlParameter("@telefono", SqlDbType.VarChar) { Value = telefono },
                     new SqlParameter("@gmail", SqlDbType.VarChar) { Value = gmail},
               
                };
                ejecutar_Procedimientos__Almacenados.EjecutarProcedimiento("speditar_proveedor", parametros);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}

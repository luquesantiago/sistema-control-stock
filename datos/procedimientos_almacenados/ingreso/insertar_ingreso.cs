using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datos.procedimientos_almacenados.ingreso
{
    public class insertar_ingreso
    {
        public bool EjecutarYDevolver(string tipo,int numero,int id_ingreso,DateTime produccion,DateTime vencimiento)
        {
            try
            {
                ejecutar_procedimientos__almacenados ejecutar_Procedimientos__Almacenados = new ejecutar_procedimientos__almacenados();

                SqlParameter[] parametros = new SqlParameter[]
                {
                     new SqlParameter("@tipo_comprobante", SqlDbType.VarChar ){ Value = tipo},
                     new SqlParameter("@numero", SqlDbType.Int) { Value = numero},
                     new SqlParameter("@idingreso", SqlDbType.Int) { Value = id_ingreso},
                     new SqlParameter("@fecha", SqlDbType.Date) { Value = DateTime.Now},
                     new SqlParameter("@fechaproduccion", SqlDbType.Date) { Value = produccion},
                     new SqlParameter("@fechavencimiento", SqlDbType.Date) { Value = vencimiento},
                };
                ejecutar_Procedimientos__Almacenados.EjecutarProcedimiento("spconfirmar_ingreso", parametros);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}

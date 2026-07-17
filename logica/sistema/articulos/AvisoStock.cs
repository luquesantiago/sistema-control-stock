using datos.procedimientos_almacenados;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica.sistema.articulos
{
    public static class AvisoStock
    {
        public static string aviso()
        {
            Articulos a = new Articulos();
            DataTable dt = a.avisoStock();
            if (dt.Rows.Count>0 ) 
            {
                StringBuilder articulos = new StringBuilder();

                foreach (DataRow row in dt.Rows)
                {
                    string nombreProducto = Convert.ToString(row["nombre"]);
                    articulos.Append(nombreProducto);
                    articulos.Append(", ");
                }

                if (articulos.Length >= 2)
                {
                    articulos.Remove(articulos.Length - 2, 2);
                }

                return "estos articulos estan por debajo del punto de reaprovisionamiento:"+articulos.ToString();
            }
            return "";
        }
    }
}

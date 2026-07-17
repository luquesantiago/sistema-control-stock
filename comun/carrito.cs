using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comun
{
    public class carrito
    {
        public string  users { get; set; }
        public DateTime fecha { get; set; }
        public int  idproveedor { get; set; }
        public string proveedor {  get; set; }
        public int idcliente { get; set; }
        public string cliente { get; set; }
        public int idarticulo { get; set; }
        public string articulo { get; set; }
        public string tipo_comprobante { get; set; }
        public long Numero_Comprobante { get; set; }
        public double total { get; set; }
        public double precio{ get; set; }
        public int stock_ingreso { get; set; }


    }
}

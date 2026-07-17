using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using datos;
using datos.procedimientos_almacenados;

namespace logica.sistema.alta
{
    public static class InsertarArticulo
    {
            public static bool insertar( string nombre, string descripcion, string idcategoria,string prov,string puntoreaprov)
            {
                Articulos articulos = new Articulos();

            return articulos.insertarArticulo(nombre,descripcion,Convert.ToInt32(idcategoria), prov,Convert.ToInt32(puntoreaprov));
            }
    }
}

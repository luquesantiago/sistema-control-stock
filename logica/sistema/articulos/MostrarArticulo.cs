using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using datos;
using datos.procedimientos_almacenados;
using logica.sistema.alta;

namespace logica.sistema
{
    public static class MostrarArticulo
    {
        public static DataTable Mostrar()
        {
            Articulos articulos = new Articulos();
            return articulos.mostrarArticulo();
        }
        public static DataTable mostrar_combo(int idprov)
        {
            Articulos articulos = new Articulos();
            return articulos.mostrarArticuloCbo(idprov);
        }
    }
}

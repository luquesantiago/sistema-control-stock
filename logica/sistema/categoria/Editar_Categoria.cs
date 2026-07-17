using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using datos;
using datos.procedimientos_almacenados;

namespace logica.sistema.modificacion
{
    public static class Editar_Categoria
    {
        public static bool editar (int idcategoria, string nombre, string descripcion)
        {
            Categoria categoria = new Categoria();
            
            return categoria.editar_Categoria(idcategoria, nombre, descripcion); 
        }
    }
}

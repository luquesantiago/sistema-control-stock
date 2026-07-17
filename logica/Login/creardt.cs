using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using datos;

namespace logica
{
    public static class creardt
    {
        public static DataTable crear()
        {
            obtenerusuarios obtenerusuarios = new obtenerusuarios();
            return obtenerusuarios.sentencia();
        }
    }
}
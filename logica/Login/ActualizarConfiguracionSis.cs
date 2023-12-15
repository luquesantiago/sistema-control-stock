using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using comun;
using datos;
namespace logica
{
    public static class ActualizarConfiguracionSis
    {
        public static bool ejecutar()
        {
            ActualizarConfigSis actualizarConfigSis = new ActualizarConfigSis();
			if (actualizarConfigSis.Ejecutar(SistemCache.minChar, SistemCache.MayusyMin, SistemCache.Especiales, SistemCache.Validacion, SistemCache.repetirC)==true)
			{
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
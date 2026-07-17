using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using comun;
using logica.consultar;

namespace logica
{
    public static class ValidarContraseña
    {
        public static bool Validar(string nombre,string Password)
        {

            if (SistemCache.minChar) { if (Password.Length < 8) return false; }
            if (SistemCache.MayusyMin) { if (Regex.IsMatch(Password, "(?=.*[a-z])(?=.*[A-Z])")) { } else { return false; } }
            if (!SistemCache.Especiales) { if (Regex.Match(Password, @"[^a-zA-Z0-9\s]").Success) { } else { return false; } }
            if (SistemCache.repetirC) { if (ConsultarContraseñasRepetidas.consultar(nombre,Password)) { return false; } }
            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace servicios
{
    public static class FullNameValidator
    {
        public static bool IsValidFullName(string fullName)
        {
            // Expresión regular para validar el formato del nombre completo
            string pattern = @"^[a-zA-Z]+(\s[a-zA-Z]+)+$";

            // Comprobación de la cadena de texto con la expresión regular
            Regex regex = new Regex(pattern);
            return regex.IsMatch(fullName);
        }
    }

}

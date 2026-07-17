using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace servicios.validaciones
{
    public static class AddressValidator
    {
        public static bool istValidStreet(string street)
        {
            // Expresión regular para validar el formato de la calle
            string streetPattern = @"^[A-Za-z\s\d]+$";

            // Comprobación de la cadena de texto con la expresión regular para la calle
            bool isStreetValid = Regex.IsMatch(street, streetPattern);
            return isStreetValid;
        }
        public static bool IsValidNumber(string streetNumber)
        {
          if( double.TryParse(streetNumber, out _))
            {
                return Convert.ToDouble(streetNumber)>0;
            }
            return false;
        }
        
    }

}

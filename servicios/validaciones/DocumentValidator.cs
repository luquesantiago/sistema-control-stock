using System.Text.RegularExpressions;

namespace servicios.validaciones
{
    public static class DocumentValidator
    {
        public static bool IsValidDNI(string DNI)
        {
            string pattern = @"^\d{8}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(DNI);
        }
        public static bool IsValidCUIL(string DNI)
        {

            string pattern = @"^\d{11}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(DNI);
        }
    }
}

using System.Text.RegularExpressions;
using comun;
using logica.consultar;

namespace logica
{
    public static class ValidarContraseña
    {
        // Valida la contraseña contra las políticas configuradas en el sistema
        // (SistemCache se carga desde la tabla de configuración al iniciar sesión).
        public static bool Validar(string nombre, string Password)
        {
            // Largo mínimo de 8 caracteres
            if (SistemCache.minChar && Password.Length < 8)
                return false;

            // Debe contener mayúsculas y minúsculas
            if (SistemCache.MayusyMin && !Regex.IsMatch(Password, "(?=.*[a-z])(?=.*[A-Z])"))
                return false;

            // Debe contener al menos un caracter especial
            // (el flag se guarda invertido en la configuración)
            if (!SistemCache.Especiales && !Regex.IsMatch(Password, @"[^a-zA-Z0-9\s]"))
                return false;

            // No puede repetir contraseñas usadas anteriormente
            if (SistemCache.repetirC && ConsultarContraseñasRepetidas.consultar(nombre, Password))
                return false;

            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace servicios
{
    public static class crearContraseña
    {
            private static string caracteres;

            // Metodo que arma un string de N cantidad de caracteres alfanumericos
            // recibiendo la cantidad de caracteres a devolver y devolviendo un string
            // con la cantidad de caracteres indicados seleccionados y ordenados aleatoriamente
            public static string ArmarCadena(int CantCaracteres)
            {
                caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
                return ArmarString(CantCaracteres);
            }

            // Igual al metodo anterior pero solo numerico. DEVUELVE UN ENTERO
            public static int ArmarCodNumerico(int CantDigitos)
            {
                caracteres = "0123456789";
                return Convert.ToInt32(ArmarString(CantDigitos));
            }

            private static string ArmarString(int cant)
            {
                char[] arrayCaracteres = new char[cant];
                Random random = new Random();
                for (int i = 0; i < arrayCaracteres.Length; i++)
                {
                    arrayCaracteres[i] = caracteres[random.Next(caracteres.Length)];
                }
                string resultado = new String(arrayCaracteres);
                return resultado;
            }
    }
}

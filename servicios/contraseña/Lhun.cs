using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace servicios
{
    // no funina con contraseñas con caracteres y numeros( osea que no se hace lo de los numeritos)
    public static class Lhun
    {
            // Metodo que genera un digito verificador numerico a partir de un numero de N cantidad de
            // digitos o a partir de un hexadecimal de N longitud, utilizando el "algoritmo de Lhun".
            // Utilizado por las tarjetas de credito/debito bancarias entre otras. Recibe por parametro
            // el numero o exadecimal devolviendo un entero decimal.
            public static int Calcular(string Hexa)
            {
                int[] decimales = new int[Hexa.Length];
                int i = 0;

                foreach (char caracter in Hexa)
                {
                    decimales[i] = Convert.ToInt32(caracter.ToString(), 16); //Convierto los hexa en decimal
                    i++;
                }

                // ALGORITMO DE LHUN
                // PASO 1 - Invertir los numeros
                Array.Reverse(decimales);

                // PASO 2 - Multiplicar por 2 las posiciones pares comenzando por la 0
                int[] decimalesxDos = new int[decimales.Length];
                for (int x = 0; x <= decimales.Length - 1; x++)
                {
                    if (x % 2 == 0)
                    {
                        decimalesxDos[x] = decimales[x] * 2;
                    }
                    else
                    {
                        decimalesxDos[x] = decimales[x];
                    }
                }

                // PASO 3 - Sumar los digitos de los nros que quedaron con mas de un digito
                for (int x = 0; x <= decimalesxDos.Length - 1; x++)
                {
                    if (Convert.ToString(decimalesxDos[x]).Length > 1)
                    {
                        int a = Convert.ToInt32(Convert.ToString(decimalesxDos[x]).Substring(0, 1));
                        int b = Convert.ToInt32(Convert.ToString(decimalesxDos[x]).Substring(1, 1));
                        decimalesxDos[x] = a + b;
                        if (Convert.ToString(decimalesxDos[x]).Length > 1)
                        {
                            a = Convert.ToInt32(Convert.ToString(decimalesxDos[x]).Substring(0, 1));
                            b = Convert.ToInt32(Convert.ToString(decimalesxDos[x]).Substring(1, 1));
                            decimalesxDos[x] = a + b;
                        }
                    }
                }

                // PASO 4 - Sumar todos los digitos del array
                int SubTotal = decimalesxDos.Sum();

                // PASO 5 - Multiplicamos por 9 el resultado de la puma anterior
                int Total = SubTotal * 9;

                // Paso 6 - Al resultado anterior le calculamos el MOD 10

                return Total % 10;
        }
    }
}

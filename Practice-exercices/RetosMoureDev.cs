using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_exercices
{
    public static class RetosMoureDev
    {

        /*
             * Enunciado: Escribe un programa que imprima los 50 primeros números de la sucesión de Fibonacci empezando en 0.
             * La serie Fibonacci se compone por una sucesión de números en la que el siguiente siempre es la suma de los dos anteriores.
             * 0, 1, 1, 2, 3, 5, 8, 13...
             *
         */
        public static void Fibonacci()
        {

        }

        /*
            * Enunciado: Escribe una función que reciba dos palabras (String) y retorne verdadero o falso (Bool) según sean o no anagramas.
             * Un Anagrama consiste en formar una palabra reordenando TODAS las letras de otra palabra inicial.
             * NO hace falta comprobar que ambas palabras existan.
             * Dos palabras exactamente iguales no son anagrama.
             *
         */

        public static bool EsAnagrama(string str1, string str2)
        {
            if (str1.ToLower() == str2.ToLower()) return false;

            var arr1 = str1.ToLower().ToCharArray();
            var arr2 = str2.ToLower().ToCharArray();
            Array.Sort(arr1);
            Array.Sort(arr2);
            return arr1.SequenceEqual(arr2);
        }


        /*
         * Enunciado: Escribe un programa que muestre por consola(con un print) 
         * los números de 1 a 100 (ambos incluidos y con un salto de línea entre cada impresión), 
         * sustituyendo los siguientes:
         * - Múltiplos de 3 por la palabra "fizz".
         * - Múltiplos de 5 por la palabra "buzz".
         * - Múltiplos de 3 y de 5 a la vez por la palabra "fizzbuzz".
         *
        */
        public static void FizzBuzz()
        {
            for (int i = 1; i <= 100; i++)
            {
                var value = i.ToString();

                    if(EsMultiploDeTres(i) && EsMultiploDeCinco(i))
                    {
                        value = "fizzbuzz";
                    }
                    else if (EsMultiploDeTres(i))
                    {
                        value = "fizz";
                    } else if(EsMultiploDeCinco(i))
                    {
                        value = "buzz";
                    }
                    Console.WriteLine(value);
            }
        }

        private static bool EsMultiploDeTres(int n)
        {
            var multiplosDeTres = new int[101];
            for (int i = 1; i <= 100; i++)
            {
                multiplosDeTres[i] = (i * 3);
            }
            return multiplosDeTres.Contains(n);
        }

        private static bool EsMultiploDeCinco(int n)
        {
            var multiplosDeCinco = new int[101];
            for (int i = 1; i <= 100; i++)
            {
                multiplosDeCinco[i] = (i * 5);
            }
            return multiplosDeCinco.Contains(n);
        }
    }
}

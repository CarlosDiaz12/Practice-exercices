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

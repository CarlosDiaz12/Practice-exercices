using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice_exercices
{
    public class Program
    {
        static void Main(string[] args)
        {
            var texto = "8298692565 - 8098692565 HOLA 8295694523";
            var codigosAreas = new string[] { "829", "809", "849" };
            var numerosEncontrados = new List<string>();

            for (int i = 0; i < texto.Length; i++)
            {
                try
                {
                    var index = i;
                    var codigoArea = texto.ElementAt(index).ToString() + texto[index + 1].ToString() + texto[index + 2].ToString();
                    var esCodigoArea = codigosAreas.Any(x => x == codigoArea);
                    if (!esCodigoArea) continue;
                    var numeroCompleto = texto.Substring(index, 10);

                    numerosEncontrados.Add(numeroCompleto);

                    if ((index + 10) >= texto.Length) 
                        break;     
                    
                    i = index + 10;
                    
                }
                catch (Exception)
                {
                    continue;
                }
            }

            numerosEncontrados.ForEach(x => Console.WriteLine(x));
            Console.ReadKey();
        }
    }
}

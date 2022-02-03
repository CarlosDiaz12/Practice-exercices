using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice_exercices
{
   public class Program
    {
        static void Main(string[] args)
        {
            var x = "sihT si na !elpmaxe";
            var result = "";
            foreach (var item in x.Split())
            {
                result = result + $"{string.Join("", item.Reverse())} ";
            }
            Console.WriteLine(result.TrimEnd());
            Console.ReadKey();
        }


    }
}

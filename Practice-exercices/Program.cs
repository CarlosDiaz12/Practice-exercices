using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice_exercices
{
   public class Program
    {
        static void Main(string[] args)
        {
            Hackerrank.hourglassSum(new List<List<int>>
            {
                new List<int>{ 1, 1, 1, 0, 0, 0},
                new List<int>{ 0, 1, 0, 0, 0, 0 },
                new List<int>{ 1, 1, 1, 0, 0, 0 },
                new List<int>{ 0, 0, 2, 4, 4, 0 },
                new List<int>{ 0, 0, 0, 2, 0, 0 },
                new List<int>{ 0, 0, 1, 2, 4, 0 }
            });
            Console.ReadKey();
        }
    }
}

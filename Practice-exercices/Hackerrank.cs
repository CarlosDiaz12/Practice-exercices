using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_exercices
{
    public static class Hackerrank
    {
        public static int hourglassSum(List<List<int>> arr)
        {
            int maxHourGlassSum = int.MinValue;
            List<int> glassHourSum = new List<int>();
            for (int i = 0; i < arr.Count; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i <= 3)
                    {
                        int fValueRow = j;
                        int sValueRow = j + 1;
                        int tValueRow = j + 2;

                        var firstValue = arr[i][fValueRow];
                        var secondValue = arr[i][sValueRow];
                        var thirdValue = arr[i][tValueRow];

                       
                        int firstValueSecondRow = arr[i + 1][sValueRow];

                        var firstValueThirdRow = arr[i + 2][fValueRow];
                        var secondValueThirdRow = arr[i + 2][sValueRow];
                        var thirdValueThirdRow = arr[i + 2][tValueRow];

                        var actualSum = firstValue + secondValue + thirdValue + firstValueSecondRow + firstValueThirdRow + secondValueThirdRow + thirdValueThirdRow;

                        glassHourSum.Add(actualSum);
                    }
                }
            }

            for (int i = 0; i < glassHourSum.Count; i++)
            {
                if(glassHourSum[i] > maxHourGlassSum)
                {
                    maxHourGlassSum = glassHourSum[i];
                }
            }

            
            return maxHourGlassSum;
        }
    }
}

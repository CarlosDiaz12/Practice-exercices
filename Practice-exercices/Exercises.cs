using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_exercices
{
    public class Exercises
    {

        public static List<string> GetValidPhoneNumbers(string texto)
        {
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
            return numerosEncontrados;
        }

        /*
         Write a function that accepts an array of 10 integers (between 0 and 9), 
        that returns a string of those numbers in the form of a phone number.
         */
        public static string CreatePhoneNumber(int[] numbers)
        {
            var str = string.Join("", numbers);
            return $"({str.Substring(0, 3)}) {str.Substring(3, 3)}-{str.Substring(6, 4)}";
            /* another approach
               return long.Parse(string.Concat(numbers)).ToString("(000) 000-0000")
            */
        }
        /*
         If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.

        Finish the solution so that it returns the sum of all the multiples of 3 or 5 below the number passed in. 
        Additionally, if the number is negative, return 0 (for languages that do have them).

        Note: If the number is a multiple of both 3 and 5, only count it once.
         */

        public static int MultiplesOf3Or5(int value)
        {
            if (value < 0) return 0;

            List<int> result = new List<int>();
            for (int i = 1; i < value; i++)
            {
                if ((i % 3 == 0) || (i % 5 == 0))
                {
                    if(!result.Contains(i))
                    {
                        result.Add(i);
                    }
                }
            }

            return result.Sum();
        }

        /*
         Write a function that takes in a string of one or more words, and returns the same string, 
        but with all five or more letter words reversed (Just like the name of this Kata). 
        Strings passed in will consist of only letters and spaces. Spaces will be included only when 
        more than one word is present.

        Examples: 
        spinWords( "Hey fellow warriors" ) => returns "Hey wollef sroirraw" 
        spinWords( "This is a test") => returns "This is a test" 
        spinWords( "This is another test" )=> returns "This is rehtona test"
         */
        public static string SpinWords(string sentence)
        {
            var words = sentence.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                var word = words[i];
                if(word.Length >= 5)
                {               
                    words[i] = new string(words[i].Reverse().ToArray());
                }
            }

            return string.Join(" ", words);
        }
        /*
         Implemente una funcion twoSum, tal que dado un array de enteros y un numero K, devuelva los pares de 
            numeros que suman K
            k = 12
            ex. [0,9,7,12,5,8,3]
            res: [0,12], [3,9],[5,7]
         */
        public static List<int[]> TwoSum(int [] arr, int target)
        {
            var results = new List<int[]>();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i +1; j < arr.Length; j++)
                {
                    if(arr[i] + arr[j] == target)
                    {
                        results.Add(new int[] { arr[i], arr[j]});
                    }
                }
            }
            return results;
        }

         /*
         Write a function which takes a list of strings and returns each line prepended by the correct number.
         The numbering starts at 1. The format is n: string. Notice the colon and space in between.
         */

       public static List<string> LinesCounter(List<string> lines)
        {
            if (lines.Count == 0) return lines;
            List<string> result = new List<string>();
            for (int i = 0; i < lines.Count; i++)
            {
                string template = $"{i + 1}: {lines[i]}";
                result.Add(template);
            }
            return result;
        }

        /*
         This time no story, no theory.
         The examples below show you how to write function accum:
         Exercises:
         accum("abcd") -> "A-Bb-Ccc-Dddd"
         accum("RqaEzty") -> "R-Qq-Aaa-Eeee-Zzzzz-Tttttt-Yyyyyyy"
         accum("cwAt") -> "C-Ww-Aaa-Tttt"
         */
       public static string Accum(string s)
        {
            string result = string.Empty;
            for (int i = 0; i < s.Length; i++)
            {
                if (i == 0)
                {
                    result += s[0].ToString().ToUpper() + "-";
                    continue;
                }

                string temp = new string(s[i], i + 1).ToLower();
                string first = temp[0].ToString();
                var temp2 = temp.ToCharArray();
                temp2[0] = Convert.ToChar(first.ToUpper());
                result += new string(temp2);

                if ((i + 1) != s.Length)
                {
                    result += "-";
                }
            }
            return result;
        }


        /*
         Your task is to return number of people who are still in the bus after
         the last bus station (after the last array). Even though
         it is the last bus stop,
         the bus is not empty and some people are still in the bus,
         and they are probably sleeping there :D 
        */

       public static int Number(List<int[]> peopleListInOut)
        {
            int peoplesInsideCount = 0;
            for (int i = 0; i < peopleListInOut.Count; i++)
            {
                int temp = peoplesInsideCount + peopleListInOut.ElementAt(i)[0];
                peoplesInsideCount = temp - peopleListInOut.ElementAt(i)[1];
            }
            return peoplesInsideCount;
        }

        /*Print an array of objects without using loops*/
        public static void recursiveLogArray(int[] items)
        {
            if (items.Count() == 0) return;
            int item = items[0];
            Console.WriteLine(item);
            int index = Array.IndexOf(items, item);
            items = items.Where((value, idx) => idx != index).ToArray();
            recursiveLogArray(items);
        }

        /*Print a list of objects without using loops*/
        public static void recursiveLog(List<int> list)
        {
            if (list.Count() == 0) return;
            int item = list.ElementAt(0);
            int index = list.IndexOf(item);
            Console.WriteLine(item);
            list.RemoveAt(index);
            recursiveLog(list);
        }
        /*
        Moving Zeros To The End:
        Write an algorithm that takes an array and moves
        all of the zeros to the end, preserving the order of the other elements.
        */

        public static int[] MoveZeroes(int[] arr)
        {

            var temp = arr.ToList();
            for (int i = 0; i < temp.Count; i++)
            {
                if (temp.ElementAt(i) == 0)
                {
                    //temp.Add(temp.ElementAt(i));
                    temp.RemoveAt(i);
                    temp.Add(0);
                }
            }
            return temp.ToArray();
        }


        /*EXERCISE 5*/
        /*
        Return the words of the initial song that Polycarpus used to make a dubsteb remix.
        Separate the words with a space. 

        EXAMPLE:
        songDecoder("WUBWEWUBAREWUBWUBTHEWUBCHAMPIONSWUBMYWUBFRIENDWUB")
        OUTPUT =>  WE ARE THE CHAMPIONS MY FRIEND
        */
        public static string songDecoder(string input)
        {
            return input.Replace("WUB", " ").Replace("   ", "  ").Replace("  ", " ").Trim();
        }


        /*EXERCISE 4*/
        /*
        Simple, given a string of words, return the length of the shortest word(s).
        String will never be empty and you do not need to account for different data types. 
        */

        public static int findShort(string s)
        {
            int shortest = int.MaxValue;

            foreach (var item in s.Split(' '))
            {
                if(item.Trim().Length < shortest)
                {
                    shortest = item.Trim().Length;
                }
            }
            return shortest;
        }

        /*EXERCISE 3*/
        /*Implement a method that accepts 3 integer values a, b, c.
         * The method should return true if a triangle can be built with
         * the sides of given length and false in any other case.*/
        public static bool isTriangle(int a, int b, int c)
        {
            return (a > 0 && b > 0 && c > 0 && a != 1 && b != 1 && c != 1);
 
        }

        /*EXERCISE 2*/
        /*Welcome. In this kata, you are asked to square every digit of a number.*/
        public static int squareDigits(int n)
        {
            string number = n.ToString();
            string result = string.Empty;
            int squareN = 0;
            
            foreach (var num in number)
            {
                squareN = int.Parse(num.ToString()) * int.Parse(num.ToString());
                result += squareN.ToString();
            }

            return int.Parse(result);
        }

        /*EXERCISE 1*/
         /*EXERCISE 1, CLOSEST NUMBER TO THE TARGET, BY THE SUM OF THE VALUES OF TWO ARRAYS
        
          */
       public static int closestSum(int[] arr1, int[] arr2, int target)
        {

            int i = 0;
            int j = 0;
            int x = 0;
            int closest = 0;
            int closest2 = int.MaxValue;
            while (true)
            {    
                if (i == arr1.Length)
                {
                    break;
                }

                if (arr1[i] > 0 && arr2[j] > 0)
                {
                    int suma = arr1[i] + arr2[j];
                
                    if (suma < target)
                    {
                        j++;
                       if(suma > closest)
                        {
                            closest = suma;                     
                        }                       
                    }
                    else
                    {
                        j++;
                        if (suma < closest2)
                        {
                            closest2 = suma;                  
                        }
  
                    }   
                }
                else
                {
                    i++;
                }

                if (j == arr2.Length)
                {
                    i++;
                    j = 0;
                }

                x++;
                if (x == arr1.Length * arr2.Length - 2)
                {
                    Console.WriteLine("end");

                    break;
                }

            }

            if((target - closest) < (closest2 - target))
            {
                return closest;
            }
            else
            {
                return closest2;
            }
            
        }
    }
}

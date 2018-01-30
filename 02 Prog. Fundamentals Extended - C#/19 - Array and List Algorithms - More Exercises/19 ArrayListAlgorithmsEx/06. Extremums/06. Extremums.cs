using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Extremums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                           .Split()
                           .Select(int.Parse)
                           .ToArray();
            bool searchedMin = Console.ReadLine().Equals("Min");

            int[] extremeNums = numbers.Select(a => FindExtreme(a, searchedMin)).ToArray();

            Console.WriteLine(string.Join(", ", extremeNums));

            Console.WriteLine(extremeNums.Sum());
        }

        private static int FindExtreme(int a, bool searchedMin)
        {
            int extreme = a;
            int digits = GetDigits(a);
            for (int i = 0; i < digits; i++)
            {
                string aText = a.ToString();
                int rotated = int.Parse(RotateNumber(a, i));
                if (searchedMin && rotated < extreme)
                {
                    extreme = rotated;
                }
                else if (!searchedMin && rotated > extreme)
                {
                    extreme = rotated;
                }
            }
            return extreme;
        }

        private static string RotateNumber(int a, int times)
        {
            List<char> digits = a.ToString().ToList();
            for (int i = 0; i < times; i++)
            {
                char first = digits[0];
                digits.RemoveAt(0);
                digits.Add(first);
            }
            return string.Join("", digits);
        }

        private static int GetDigits(int a)
        {
            int counter = 0;
            while (a > 0)
            {
                a /= 10;
                counter++;
            }
            return counter;
        }
    }
}

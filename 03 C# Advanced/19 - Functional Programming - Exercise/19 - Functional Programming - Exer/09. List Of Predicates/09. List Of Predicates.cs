using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.List_Of_Predicates
{
    class Program
    {
        static void Main(string[] args)
        {

            int borderNum = int.Parse(Console.ReadLine());

            var dividers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Func<int, int, bool> filter = (n, d) => n % d == 0;

            OperatingAndPring(borderNum, dividers, filter);
        }

        private static void OperatingAndPring(int borderNum, int[] dividers, Func<int, int, bool> filter)
        {
            var result = new List<int>();

            for (int i = 1; i <= borderNum; i++)
            {
                var hasPassed = true;

                foreach (var div in dividers)
                {
                    //Predicate<int> predFilter = n => i % n == 0;

                    if (!filter(i, div))   // if (!predFilter(div)) poveche pamet
                    {
                        hasPassed = false;
                        break;
                    }
                }

                if (hasPassed)
                {
                    result.Add(i);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}

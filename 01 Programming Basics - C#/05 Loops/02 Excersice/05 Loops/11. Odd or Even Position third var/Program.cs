using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Odd_or_Even_Position_third_var
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double OddSum = 0.0;
            double OddMin = double.MaxValue;
            double OddMax = double.MinValue;

            double EvenSum = 0.0;
            double EvenMin = double.MaxValue;
            double EvenMax = double.MinValue;

            for (int i = 0; i < n; i++)
            {
                double number = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    OddSum += number;
                    OddMin = number < OddMin ? number : OddMin;
                    OddMax = number > OddMax ? number : OddMax;
                }
                else
                {
                    EvenSum += number;
                    EvenMin = number < EvenMin ? number : EvenMin;
                    EvenMax = number > EvenMax ? number : EvenMax;
                }
            }

            Console.WriteLine($"OddSum = {OddSum},");

            if (OddMin == double.MaxValue || OddMax == double.MinValue)
            {
                Console.WriteLine($"OddMin= No,");
                Console.WriteLine($"OddMax= No,");
            }

            else
            {
                Console.WriteLine($"OddMin= {OddMin},");
                Console.WriteLine($"OddMax= {OddMax},");
            }

            Console.WriteLine($"EvenSum = {EvenSum},");

            if (EvenMin == double.MaxValue && EvenMax == double.MinValue)
            {
                Console.WriteLine($"EvenMin = No,");
                Console.WriteLine($"EvenMax = No");
            }
            else
            {
                Console.WriteLine($"EvenMin = {EvenMin},");
                Console.WriteLine($"EvenMax = {EvenMax}");
            }

        }
    }
}

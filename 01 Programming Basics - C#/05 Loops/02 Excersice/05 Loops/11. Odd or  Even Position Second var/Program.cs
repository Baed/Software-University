using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Odd_or__Even_Position_Second_var
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double oddsum = 0.0;
            double oddmin = double.MaxValue;
            double oddmax = double.MinValue;

            double evensum = 0.0;
            double evenmin = double.MaxValue;
            double evenmax = double.MinValue;
      
            for (int i = 0; i < n; i++)
            {
                var number = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    oddsum += number;
                    oddmin = oddmin > number ? number : oddmin;
                    oddmax = oddmax < number ? number : oddmax;
                }

                else
                {
                    evensum += number;
                    evenmin = evenmin > number ? number : evenmin;
                    evenmax = evenmax < number ? number : evenmax;
                }
            }

            Console.WriteLine($"OddSum={oddsum}");
            Console.WriteLine($"OddMin={oddmin}", oddmin == double.MaxValue ? "No" : oddmin.ToString());
            Console.WriteLine($"OddMax={oddmax}", oddmax == double.MinValue ? "No" : oddmax.ToString());
            Console.WriteLine($"EvenSum={evensum}");
            Console.WriteLine($"EvenMin={evenmin}", evenmin == double.MaxValue ? "No" : evenmin.ToString());
            Console.WriteLine($"EvenMax={evenmax}", evenmax == double.MinValue ? "No" : evenmax.ToString());

        }
    }
}

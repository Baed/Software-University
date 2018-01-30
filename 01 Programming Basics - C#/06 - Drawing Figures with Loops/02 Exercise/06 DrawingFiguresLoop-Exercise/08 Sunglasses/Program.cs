using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string stars = new string('*', 2 * n);
            string dashes = new string('/', 2 * n - 2);
            string space = new string(' ', n);
            string pipe = new string('|', n);

            Console.WriteLine($"{stars}{space}{stars}");

            for (int row = 0; row < n - 2; row++)
            {
                if (n % 2 == 0 && row == n / 2 - 2 || n % 2 == 1 && row == n / 2 - 1) //(row == (n - 1)/2 - 1)
                {
                    Console.WriteLine($"*{dashes}*{pipe}*{dashes}*");
                }
                else
                {
                    Console.WriteLine($"*{dashes}*{space}*{dashes}*");
                }
            }

            Console.WriteLine($"{stars}{space}{stars}");
        }
    }
}

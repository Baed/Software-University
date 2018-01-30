using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Houses_3_Optimum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int width = n;
            //int dashesCount = (n - 1) / 2;

            for (int dashesCount = (n - 1) / 2; dashesCount >= 0; dashesCount--)
            {
                string dashes = new string('-', dashesCount);
                string stars = new string('*', n - 2 * dashesCount);

                Console.WriteLine($"{dashes}{stars}{dashes}");
                dashesCount--;
            }

            for (int row = 0; row < n - (n + 1) / 2; row++)
            {
                Console.WriteLine("|{0}|", new string('*', n - 2));
            }
        }
    }
}

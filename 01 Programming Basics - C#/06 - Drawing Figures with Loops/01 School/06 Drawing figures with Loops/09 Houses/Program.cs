using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Houses
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            int starsCount = 1;
            if (n % 2 == 0)
            {
                starsCount++;
            }

            for (int row = 0; row < (n + 1) / 2; row++)
            {
                string dashes = new string('-', (n - starsCount) / 2);
                string stars = new string('*', starsCount);

                Console.WriteLine($"{dashes}{stars}{dashes}");
                starsCount += 2;
            }

            for (int row = 0; row < n - (n + 1) / 2; row++)
            {
                Console.WriteLine("|{0}|", new string ('*', n - 2));
            }
        }
    }
}

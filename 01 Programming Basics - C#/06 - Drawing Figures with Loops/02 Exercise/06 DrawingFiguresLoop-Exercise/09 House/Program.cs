using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_House
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var starsCount = 1;
           
            if (n % 2 == 0)
            {
                starsCount++;   
            }

            for (int i = 0; i < (n+1)/2; i++)
            {           
                string dashes = new string('-', (n - starsCount) / 2);
                string stars = new string('*', starsCount);
                Console.WriteLine($"{dashes}{stars}{dashes}");
                starsCount += 2;
            }

            for (int i = 0; i < n/2; i++)
            { 
                Console.WriteLine("|{0}|", new string('*', n - 2));
            }
            
        }
    }
}

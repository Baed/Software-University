using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Check_Prime
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            bool isPrime = true;
            /* first type
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    break; // spestqvame si povtoreniq koito ne sa nujni
                }
            }

            if (n < 2)
            {
                isPrime = false;
            }
            */

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    break; // spestqvame si povtoreniq koito ne sa nujni
                }
            }

            if (isPrime && n > 1)
            {
                Console.WriteLine("Prime");
            }
            else
            {
               Console.WriteLine("iS not prime");
            }
            
        }
    }
}

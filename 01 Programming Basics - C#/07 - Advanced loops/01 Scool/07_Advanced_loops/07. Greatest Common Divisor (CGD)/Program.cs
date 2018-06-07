using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Greatest_Common_Divisor__CGD_
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            /*  first type
            int GCD = 1;
            int min_Number = Math.Min(a, b);

            for (int i = 2; i < min_Number; i++)
            {
                if (a % i == 0 && b % i == 0)
                {
                    GCD = i;
                }
            }
            Console.WriteLine(GCD);
        */
            // second type  -- greshka za vreme
            /* 
               
               int current_number = Math.Min(a, b);

               while ( !(a % current_number == 0 && b % current_number == 0))
               {
               current_number--;
               }
           */

            // third type
            int bigger = Math.Max(a, b);
            int smaller = Math.Min(a, b);

            while (smaller != 0) // zas6toto 6te dava true kogato 4isloto ne e nula i mqma da izleze
            {
                int nextSmall = bigger % smaller;
                bigger = smaller;
                smaller = nextSmall;
            }

            Console.WriteLine(bigger);
        }
    }
}

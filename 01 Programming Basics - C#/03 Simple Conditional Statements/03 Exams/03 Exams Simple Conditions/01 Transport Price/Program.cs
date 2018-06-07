using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Transport_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string daytime = Console.ReadLine();

            //var distance = 0;
            var daytimeTax = 0m; // dnevna = 0,79 ; noshtna = 0,90 ;
            
            if (daytime == "day")
            {
                daytimeTax = 0.79m;
            }
            if (daytime == "night")
            {
                daytimeTax = 0.90m;
            }

            var taxi = daytimeTax * n + 0.70m;

            var bus = n * 0.09; // dnevna i noshtna ; distance >= 20 ; 
            var train = n * 0.06; // dnevna i noshtna ; distance >= 100 

            if (n < 20)
            {
                Console.WriteLine(taxi);
            }

            if ( 100 >= n && n >= 20 )
            {
                Console.WriteLine(bus);
            }

            if ( n >= 100)
            {
                Console.WriteLine(train);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string yeartype = Console.ReadLine();
            int p = int.Parse(Console.ReadLine()); // praznika 
            int h = int.Parse(Console.ReadLine()); // weekend v rodniq grad
            var normalyear = (((48m - h) * 3 / 4m + h + p * 2 / 3m));
            var leapyear = (((48m - h) * 3 / 4m + h + p * 2 / 3m) * 0.15m);

            if (yeartype == "leap")
            {

               Console.WriteLine(Math.Floor(normalyear + leapyear));
                
            }

            else if (yeartype == "normal")
            {
                Console.WriteLine(Math.Floor(normalyear));
            }

        }
    }
}

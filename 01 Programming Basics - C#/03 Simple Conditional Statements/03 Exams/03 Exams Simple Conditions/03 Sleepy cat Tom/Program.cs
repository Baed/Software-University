using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Sleepy_cat_Tom
{
    class Program
    {
        static void Main(string[] args)
        {

            var hollyDays = int.Parse(Console.ReadLine());
            var workDays = 365 - hollyDays;
            var play = workDays * 63 + hollyDays * 127;
            var limit = Math.Abs(30000 - play);

            if (play > 30000)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{limit/60} hours and {limit%60} minutes more for play");
            }

            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{limit / 60} hours and {limit % 60} minutes less for play");
            }


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Traveling_At_Light_Speed
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal kmPerLY = 9450000000000;
            decimal kmPerSec = 300000;
            decimal lightYears = decimal.Parse(Console.ReadLine());

            decimal secondTotal = (lightYears * kmPerLY) / kmPerSec;
            int minutes = (int)secondTotal / 60;
            secondTotal %= 60;
            int hours = (minutes / 60);
            minutes %= 60;
            int days = hours / 24;
            hours %= 24;
            int weeks = days / 7;
            days %= 7;

            Console.WriteLine($"{weeks} weeks");
            Console.WriteLine($"{days} days");
            Console.WriteLine($"{hours} hours");
            Console.WriteLine($"{minutes} minutes");
            Console.WriteLine($"{Math.Floor(secondTotal)} seconds");         
        }
    }
}

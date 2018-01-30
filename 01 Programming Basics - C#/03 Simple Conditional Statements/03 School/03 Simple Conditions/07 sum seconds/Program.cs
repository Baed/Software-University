using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_sum_seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int secondsSum = num1 + num2 + num3;

            int minutes = secondsSum / 60;
            int seconds = secondsSum % 60;

            if (seconds < 10)
            {
                Console.WriteLine($"{minutes}:0{seconds}"); // zaradi zapisa s 0
            }

            else      // if ( seconds >= 10)
            {
                Console.WriteLine("{0}:{1}", minutes, seconds);
            }

        }
    }
}

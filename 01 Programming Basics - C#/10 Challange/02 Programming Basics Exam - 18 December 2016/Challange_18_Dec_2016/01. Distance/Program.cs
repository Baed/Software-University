using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Distance
{
    class Program
    {
        static void Main(string[] args)
        {

            int speed = int.Parse(Console.ReadLine());
            double first_time = double.Parse(Console.ReadLine());
            double second_time = double.Parse(Console.ReadLine());
            double third_time = double.Parse(Console.ReadLine());

            double distance = speed * first_time / 60;
            double distance_up_10 = (speed + speed * 0.10) * second_time / 60;
            double distance_low_5 = ((speed + speed * 0.10) - (speed + speed * 0.10) * 0.05) * third_time / 60;
            double sum = distance + distance_up_10 + distance_low_5;
            Console.WriteLine($"{sum:f2}");

        }
    }
}

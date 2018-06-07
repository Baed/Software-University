using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Metric_Convertor
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = double.Parse(Console.ReadLine());
            string first = Console.ReadLine();
            string second = Console.ReadLine();

            double toMeters = 0;
            double converted = 0;

            if (first == "m")
            {
                toMeters = num;
            }

            else if (first == "mm")
            {
                toMeters = num / 1000;
            }

            else if (first == "cm")
            {
                toMeters = num / 100;
            }
            else if (first == "mi")
            {
                toMeters = num / 0.000621371192;
            }

            else if (first == "in")
            {
                toMeters = num / 39.3700787;
            }

            else if (first == "km")
            {
                toMeters = num * 1000; //  deleno na 0.0001
            }

            else if (first == "ft")
            {
                toMeters = num / 3.2808399;
            }

            else if (first == "yd")
            {
                toMeters = num / 1.0936133;
            }

            if (second == "m")
            {
                converted = toMeters;
            }

            else if (second == "mm")
            {
                 converted = toMeters * 1000;
            }

            else if (second == "cm")
            {
                 converted = toMeters * 100;                  
            }
            else if (second == "mi")
            {
                 converted = toMeters * 0.000621371192;
            }

            else if (second == "in")
            {
                 converted = toMeters * 39.3700787;
            }

            else if (second == "km")
            {
                 converted = toMeters * 0.001; //  deleno na 1000
            }

            else if (second == "ft")
            {
                 converted = toMeters * 3.2808399;
            }

            else if (second == "yd")
            {
                 converted = toMeters * 1.0936133;
            }

            Console.WriteLine($"{converted:f8}");
        }
    }
}

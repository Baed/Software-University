using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _01.Sino_The_Walker
{
    class Program
    {
        static void Main(string[] args)
        {
            // 80/100
            // TimeSpan time = TimeSpan.Parse(Console.ReadLine());
            // int step = int.Parse(Console.ReadLine()); // maybe int == BigInteger
            // int seconds = int.Parse(Console.ReadLine());
            //
            // TimeSpan stepPerSecondr = TimeSpan.FromSeconds(step * seconds);
            //
            // TimeSpan timeSum = time + stepPerSecondr;
            //
            // Console.WriteLine("Time Arrival: {0:hh\\:mm\\:ss}", timeSum);

            // 90/100
            //  DateTime starttime = DateTime.ParseExact(Console.ReadLine(), "HH:mm:ss", null);
            //
            //  double steps = double.Parse(Console.ReadLine()) % 86400;              //86400 секунди = 1 ден
            //  double secsonsperstep = double.Parse(Console.ReadLine()) % 86400;     //86400 секунди = 1 ден
            //  double res = steps * secsonsperstep;
            //
            //  DateTime Arrival = starttime.AddSeconds(res);
            //  Console.WriteLine("Time Arrival: {0}", Arrival.ToString("HH:mm:ss"));

            // 100/100
            string[] timeInput = Console.ReadLine().Split(':');
            int hours = int.Parse(timeInput[0]) * 3600;
            int minutes = int.Parse(timeInput[1]) * 60;
            int seconds = int.Parse(timeInput[2]);
            int totalInputInSeconds = hours + minutes + seconds;

            BigInteger steps = int.Parse(Console.ReadLine());
            BigInteger secPerStep = int.Parse(Console.ReadLine());

            BigInteger totalTimeInSeconds = (steps * secPerStep) + totalInputInSeconds;

            BigInteger arriveHour = (totalTimeInSeconds / 3600) % 24;
            BigInteger arriveMinute = (totalTimeInSeconds / 60) % 60;
            BigInteger arriveSecond = totalTimeInSeconds % 60;

            Console.WriteLine($"Time Arrival: {arriveHour:00}:{arriveMinute:00}:{arriveSecond:00}");

        }
    }
}


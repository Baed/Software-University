using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___Game_Of_Intervals
{
    class Program
    {
        static void Main(string[] args)
        {
            int move = int.Parse(Console.ReadLine());

            var counter_points = 0.0;
            var numinvalid = 0.0;
            var num40to50 = 0.0;
            var num30to40 = 0.0;
            var num20to30 = 0.0;
            var num10to20 = 0.0;
            var num0to10 = 0.0;

            for (int i = 1; i <= move; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num > 50 || num < 0)
                {
                    numinvalid++;
                    counter_points -= counter_points / 2;
                }
                else if (num >= 40)
                {
                    num40to50++;
                    counter_points += 100;
                }
                else if (num >= 30)
                {
                    num30to40++;
                    counter_points += 50;
                }
                else if (num >= 20)
                {
                    num20to30++;
                    counter_points += num * 0.40;
                }
                else if (num >= 10)
                {
                    num10to20++;
                    counter_points += num * 0.30;
                }
                else if (num >= 0)
                {
                    num0to10++;
                    counter_points += num * 0.20;
                }
            }
            Console.WriteLine($"{counter_points:f2}");          
            Console.WriteLine($"From 0 to 9: {100 * num0to10 / move:f2}%");
            Console.WriteLine($"From 10 to 19: {100 * num10to20 / move:f2}%");
            Console.WriteLine($"From 20 to 29: {100 * num20to30 / move:f2}%");
            Console.WriteLine($"From 30 to 39: {100 * num30to40 / move:f2}%");
            Console.WriteLine($"From 40 to 50: {100 * num40to50 / move:f2}%");
            Console.WriteLine($"Invalid numbers: {100 * numinvalid / move:f2}%");

        }
    }
}

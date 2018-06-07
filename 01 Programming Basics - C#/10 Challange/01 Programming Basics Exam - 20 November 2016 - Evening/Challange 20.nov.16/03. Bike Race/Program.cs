using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Bike_Race
{
    class Program
    {
        static void Main(string[] args)
        {

            double junior_group = double.Parse(Console.ReadLine());
            double senior_group = double.Parse(Console.ReadLine());
            string road_type = Console.ReadLine().ToLower();

            var juniors = 0.00;
            var seniors = 0.00;

            if (road_type == "trail")
            {
                juniors = 5.50;
                seniors = 7.00;
            }
            else if (road_type == "cross-country")
            {
                juniors = 8.00;
                seniors = 9.50;
            }
            else if (road_type == "downhill")
            {
                juniors = 12.25;
                seniors = 13.75;
            }
            else if (road_type == "road")
            {
                juniors = 20.00;
                seniors = 21.50;
            }

            if (junior_group + senior_group >= 50 && road_type == "cross-country")
            {
                var sum = (junior_group*juniors + senior_group*seniors) - ((junior_group * juniors + senior_group * seniors) * 0.25);
                var sum_with_vat = sum - (sum * 0.05);
                Console.WriteLine($"{sum_with_vat:f2}");
            }
            else
            {
                var sum = junior_group * juniors + senior_group * seniors;
                var sum_with_vat = sum - (sum * 0.05);
                Console.WriteLine($"{sum_with_vat:f2}");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Flowers
{
    class Program
    {
        static void Main(string[] args)
        {


            int hrizantemi = int.Parse(Console.ReadLine());
            int rozi = int.Parse(Console.ReadLine());
            int laleta = int.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();
            string holliday_type = Console.ReadLine().ToLower();
            var opakovka = 2.0;

            var hrizantemi_value = 0.0;
            var laleta_value = 0.0;
            var rozi_value = 0.0;
            
            if ((season == "spring" || season == "summer"))
            {
                hrizantemi_value = 2.00;
                laleta_value = 2.50;
                rozi_value =  4.10;
            }

            else if ((season == "autumn" || season == "winter"))
            {
                hrizantemi_value = 3.75;
                laleta_value =  4.15;
                rozi_value = 4.50;
            }

            var buket = hrizantemi * hrizantemi_value + laleta * laleta_value + rozi * rozi_value;

            if (holliday_type == "y")
            {
                buket += buket * 0.15;
            }


            if (laleta > 7 && season == "spring")
            {
                buket -= buket * 0.05;
            }

            if ((rozi >= 10 && season == "winter"))
            {
                buket -= buket * 0.1;
            }

            if (hrizantemi + rozi + laleta > 20)
            {
                buket -= buket * 0.2;
            }


            Console.WriteLine($"{(buket + opakovka):f2}");

        }
    }
}

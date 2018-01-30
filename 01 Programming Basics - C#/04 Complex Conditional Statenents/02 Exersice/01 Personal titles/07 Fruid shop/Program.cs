using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Fruid_shop
{
    class Program
    {
        static void Main(string[] args)
        {

            var fruid = Console.ReadLine().ToLower();
            var weekday = Console.ReadLine().ToLower();
            var quantity = double.Parse(Console.ReadLine());

            var price = 0.0; // nai dobre da e = -1.0

            if (weekday == "monday" || weekday == "tuesday" || weekday == "wednesday" || weekday == "thursday" || weekday == "friday")
            {
                if (fruid == "banana")
                {
                    price = 2.50;
                }
                else if (fruid == "apple")
                {
                    price = 1.20;
                }
                else if (fruid == "orange")
                {
                    price = 0.85;
                }
                else if (fruid == "grapefruit")
                {
                    price = 1.45;
                }
                else if (fruid == "kiwi")
                {
                    price = 2.70;
                }
                else if (fruid == "pineapple")
                {
                    price = 5.50;
                }
                else if (fruid == "grapes")
                {
                    price = 3.85;
                }
            }

            else if (weekday == "saturday" || weekday == "sunday")
            {
                if (fruid == "banana")
                {
                    price = 2.70;
                }
                else if (fruid == "apple")
                {
                    price = 1.25;
                }
                else if (fruid == "orange")
                {
                    price = 0.90;
                }
                else if (fruid == "grapefruit")
                {
                    price = 1.60;
                }
                else if (fruid == "kiwi")
                {
                    price = 3.0;
                }
                else if (fruid == "pineapple")
                {
                    price = 5.60;
                }
                else if (fruid == "grapes")
                {
                    price = 4.20;
                }
            }

            if (price > 0) // price = - 1 (price >=0)
            {
                Console.WriteLine($"{(price * quantity):f2}");
            }

            else
            {
                Console.WriteLine("error");
            }

        }
    }
}

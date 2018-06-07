using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Day_of_week
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string day = Console.ReadLine();
            double price = double.Parse(Console.ReadLine());

            bool weekend = day == "Saturday" || day == "Sunday";
            bool weekday =
                day == "Monday" ||
                day == "Thuesday" ||
                day == "Wednesday" ||
                day == "Thursday" ||
                day == "Friday";

            double productprice = 0;

            if (weekend)
            {
                if (product == "banana")
                {
                    productprice = 2.50;
                }
                if (product == "apple")
                {
                    productprice = 1.20;
                }
                if (product == "orange")
                {
                    productprice = 0.85;
                }
                if (product == "grapefruit")
                {
                    productprice = 1.45;
                }
                if (product == "kiwi")
                {
                    productprice = 2.70;
                }
                if (product == "pineapple")
                {
                    productprice = 5.50;
                }
                if (product == "pineapple")
                {
                    productprice = 3.85;
                }

            }

            else if (weekday)
            {
                if (product == "banana")
                {
                    productprice = 2.70;
                }
                if (product == "apple")
                {
                    productprice = 1.25;
                }
                if (product == "orange")
                {
                    productprice = 0.90;
                }
                if (product == "grapefruit")
                {
                    productprice = 1.60;
                }
                if (product == "kiwi")
                {
                    productprice = 3.00;
                }
                if (product == "pineapple")
                {
                    productprice = 5.60;
                }
                if (product == "pineapple")
                {
                    productprice = 4.20;
                }

            }
        }
    }
}

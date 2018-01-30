using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Small_shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine().ToLower();
            string city = Console.ReadLine().ToLower();
            double quanity = double.Parse(Console.ReadLine());
            
            if (city == "sofia")
            {
                if (product == "coffee")
                {
                    Console.WriteLine(quanity * 0.50);
                }
                else if (product == "water")
                {
                    Console.WriteLine(quanity * 0.80);
                }
                else if (product == "beer")
                {
                    Console.WriteLine(quanity * 1.20);
                }
                else if (product == "sweets")
                {
                    Console.WriteLine(quanity * 1.45);
                }
                else if (product == "peanuts")
                {
                    Console.WriteLine(quanity * 1.60);
                }
            }
            
            else if (city == "plovdiv")
            {
                if (product == "coffee")
                {
                    Console.WriteLine(quanity * 0.40);
                }
                else if (product == "water")
                {
                    Console.WriteLine(quanity * 0.70);
                }
                else if (product == "beer")
                {
                    Console.WriteLine(quanity * 1.15);
                }
                else if (product == "sweets")
                {
                    Console.WriteLine(quanity * 1.30);
                }
                else if (product == "peanuts")
                {
                    Console.WriteLine(quanity * 1.50);
                }
            }

            else if (city == "varna")
            {
                if (product == "coffee")
                {
                    Console.WriteLine(quanity * 0.45);
                }
                else if (product == "water")
                {
                    Console.WriteLine(quanity * 0.70);
                }
                else if (product == "beer")
                {
                    Console.WriteLine(quanity * 1.10);
                }
                else if (product == "sweets")
                {
                    Console.WriteLine(quanity * 1.35);
                }
                else if (product == "peanuts")
                {
                    Console.WriteLine(quanity * 1.55);
                }
            }

            else
            {
                Console.WriteLine("error");
            }

        }
    }
}

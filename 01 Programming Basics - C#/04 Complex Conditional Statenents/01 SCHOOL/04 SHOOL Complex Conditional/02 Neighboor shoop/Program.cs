using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Neighboor_shoop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine().ToLower();
            string town = Console.ReadLine().ToLower();
            var quantity = double.Parse(Console.ReadLine());

            if (product == "coffee")
            {
                if (town == "sofia")
                {
                    quantity = quantity * 0.5;
                    Console.WriteLine(quantity);
                }

                else if (town == "plovdiv")
                {
                    quantity = quantity * 0.4;
                    Console.WriteLine(quantity);
                }

                else if (town == "varna")
                {
                    quantity = quantity * 0.45;
                    Console.WriteLine(quantity);
                }

            }

            else if (product == "water")
            {
                if (town == "sofia")
                {
                   Console.WriteLine(quantity * 0.8);
                }

                else if (town == "plovdiv")
                { 
                    Console.WriteLine(quantity * 0.7);
                }

                else if (town == "varna")
                {
                    Console.WriteLine(quantity * 0.7);
                }
            } 

            else if (product == "beer")
            {
                if (town == "sofia")
                {
                    Console.WriteLine(quantity * 1.20);
                }

                else if (town == "plovdiv")
                {
                    Console.WriteLine(quantity * 1.15);
                }

                else if (town == "varna")
                {
                    Console.WriteLine(quantity * 1.10);
                }
            }

            else if (product == "sweets")
            {
                if (town == "sofia")
                {
                    Console.WriteLine(quantity * 1.45);
                }

                else if (town == "plovdiv")
                {
                    Console.WriteLine(quantity * 1.30);
                }

                else if (town == "varna")
                {
                    Console.WriteLine(quantity * 1.35);
                }
            }

            else if (product == "peanuts")
            {
                if (town == "sofia")
                {
                    Console.WriteLine(quantity * 1.6);
                }

                else if (town == "plovdiv")
                {
                    Console.WriteLine(quantity * 1.50);
                }

                else if (town == "varna")
                {
                    Console.WriteLine(quantity * 1.55);
                }
            }
        }
    }
}

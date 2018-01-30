using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Training_Hall_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int Num = int.Parse(Console.ReadLine());
            double moneyCtr = 0;

            while (Num - 1 >= 0)
            {
                string Type = Console.ReadLine();
                double Price = double.Parse(Console.ReadLine());
                double itemCount = double.Parse(Console.ReadLine());
                moneyCtr += Price * itemCount;
                if (itemCount > 1)
                {
                    Console.WriteLine($"Adding {itemCount} {Type}s to cart.");
                }
                else
                {
                    Console.WriteLine($"Adding {itemCount} {Type} to cart.");
                }
                
                Num--;
            }
            Console.WriteLine($"Subtotal: ${moneyCtr:f2}");
            if (budget >= moneyCtr)
            {
                Console.WriteLine($"Money left: ${budget - moneyCtr:f2}");
            }
            else
            {
                Console.WriteLine($"Not enough. We need ${moneyCtr - budget:f2} more.");

            }
        }
    }
}

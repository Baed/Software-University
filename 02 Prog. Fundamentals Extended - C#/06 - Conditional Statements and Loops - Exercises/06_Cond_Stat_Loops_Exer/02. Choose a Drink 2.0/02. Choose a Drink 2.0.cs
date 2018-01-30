using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Choose_a_Drink_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            double num = double.Parse(Console.ReadLine());

            if (profession == "Athlete")
            {
                num *= 0.70;
            }
            else if (profession == "Businessman" || profession == "Businesswoman")
            {
                num *= 1.00;
            }
            else if (profession == "SoftUni Student")
            {
                num *= 1.70;
            }
            else
            {
                num *= 1.20;
            }
            Console.WriteLine($"The {profession} has to pay {num:f2}.");
        }
    }
}

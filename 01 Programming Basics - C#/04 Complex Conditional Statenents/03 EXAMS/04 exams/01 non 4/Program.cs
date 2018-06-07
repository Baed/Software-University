using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_non_4
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal budjet = decimal.Parse(Console.ReadLine());
            string type = Console.ReadLine().ToLower();
            int n = int.Parse(Console.ReadLine());

            decimal moneyy = 0;
            decimal koef = 0;

            if (type == "normal")
            {
                moneyy = 249.99M;
            }
            else if (type == "vip")
            {
                moneyy = 499.99M;
            }
            if (n >= 1 && n <= 4)
            {
                koef = (decimal)0.75;
            }
            else if (n >= 5 && n <= 9)
            {
                koef = (decimal)0.60;
            }
            else if (n >= 10 && n <= 24)
            {
                koef = (decimal)0.50;
            }
            else if (n >= 25 && n <= 49)
            {
                koef = (decimal)0.40;
            }
            else if (n >= 50)
            {
                koef = (decimal)0.25;
            }
            decimal dasdas = budjet - (koef * budjet);
            Console.WriteLine(dasdas);
            Console.WriteLine(moneyy * n);

            if (moneyy * n <= dasdas)
            {
                Console.WriteLine("Yes! You have {0:f2} leva left.", dasdas - moneyy * n);
            }
            else
            {
                Console.WriteLine("Not enough money! You need {0:f2} leva.", moneyy * n - dasdas);
            }
        }
    }
}

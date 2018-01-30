using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Умната_Лили_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double priceOfWashingMachine = double.Parse(Console.ReadLine());
            double priceOfToys = double.Parse(Console.ReadLine());

            int moneyStart = 0; // = 10
            int moneySaved = 0;
            int toys = 0;
            int brother = 0;
            

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0 && i != 1)
                {
                    moneySaved += moneyStart + 10; // bez 10
                    moneyStart += 10;
                    brother++;
                }
                else if (i % 2 != 0 || i == 1)
                {
                    toys++;
                }
            }
            var allMoney = toys * priceOfToys + moneySaved - brother;

            if (allMoney >= priceOfWashingMachine)
            {
                allMoney -= priceOfWashingMachine;
                Console.WriteLine($"Yes! {allMoney:f2}");
            }
            else
            {
                Console.WriteLine($"No! {Math.Abs(allMoney - priceOfWashingMachine):f2}");
            }
        }
    }
}

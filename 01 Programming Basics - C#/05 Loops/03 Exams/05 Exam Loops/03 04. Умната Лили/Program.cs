using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_04.Умната_Лили
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double machinePrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            var Start = 10; // = 0
            var Saved = 0;
            var Toys = 0;
            var Brother = 0;
            

            for (int i = 1; i <= age; i++) // zapochva ot 1 zaradi 1-ta godina na lili
            {             
                if (i % 2 == 0)
                {
                    Saved += Start; // + 10 
                    Start += 10;
                    Brother++;
                }

                else 
                {
                    Toys++;
                }
            }

            var Account = Toys * toyPrice + Saved - Brother;

            if (Account >= machinePrice)
            {
                Console.WriteLine($"Yes! {Math.Abs(Account - machinePrice):f2}");
            }
            else
            {
                Console.WriteLine($"No! {Math.Abs(Account - machinePrice):f2}");
            }
        }
    }
}

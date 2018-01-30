using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_01
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int guestsCnt = int.Parse(Console.ReadLine());
            double bananasPrice = double.Parse(Console.ReadLine());
            double eggsPrice = double.Parse(Console.ReadLine());
            double berriesPrice = double.Parse(Console.ReadLine());

            int portions = guestsCnt / 6;

            if (guestsCnt % 6 != 0)
            {
                portions++;
            }

            int bananasNeeded = 2 * portions;
            int eggsNeeded = 4 * portions;
            double berriesNeeded = 0.2 * portions;

            double totalPrice = (bananasNeeded * bananasPrice) + 
                (eggsNeeded * eggsPrice) + (berriesNeeded * berriesPrice);

            if (totalPrice <= money)
            {
                Console.WriteLine
                    ($"Ivancho has enough money - it would cost {totalPrice:F2}lv.");
            }
            else
            {
                Console.WriteLine
                    ($"Ivancho will have to withdraw money - he will need {totalPrice - money:F2}lv more.");
            }
        }
    }
}

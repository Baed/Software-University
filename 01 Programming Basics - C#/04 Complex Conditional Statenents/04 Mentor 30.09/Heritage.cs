using System;
using System.Collections.Generic;

namespace Heritage
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal year = 18m;
            decimal money = decimal.Parse(Console.ReadLine());
            decimal finalYear = decimal.Parse(Console.ReadLine());

            decimal expenses = 0m;

            for (int i = 1800; i <= finalYear; i++)
            {
                if (i % 2 == 0)
                {
                    expenses += 12000;

                }
                else
                {
                    expenses += 12000 + (50 * year);

                }

                year++;
            }

            decimal diff = money - expenses;

            if (diff >= 0)
            {
                Console.WriteLine
                    ($"Yes! He will live a carefree life and will have {diff:f2} dollars left.");
            }
            else
            {
                Console.WriteLine
                    ($"He will need {Math.Abs(diff):f2} dollars to survive.");
            }
        }
    }
}

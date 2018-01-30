using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            double bonuses = 0;
            double totalScore = number;

            if (number > 1000)
            {
                bonuses += number * 0.1;
                totalScore += number * 0.1;
            }
            else if (number > 100)
            {
                bonuses += number * 0.2;
                totalScore += number * 0.2;
            }
            else if (number <= 100)
            {
                bonuses += 5;
                totalScore += 5;
            }

            if (number % 2 == 0)
            {
                bonuses += 1;
                totalScore += 1;
            }

            if (number % 10 == 5)
            {
                bonuses += 2;
                totalScore += 2;
            }

            Console.WriteLine($"Bonus score: {bonuses}");
            Console.WriteLine($"Total score: {totalScore}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());
            int CurrentMax = int.MinValue; // vrushta nai-malkata stoinost na int koqto ima. Inache pri otricatelni 6te grumne
            // 
            for (int i = 0; i < numbersCount; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number >= CurrentMax)
                {
                    CurrentMax = number;
                }
            }

            Console.WriteLine(CurrentMax);
        }
    }
}

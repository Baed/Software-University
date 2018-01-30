using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());
            int CurrentMin = int.MaxValue; // vrushta nai-golqmata stoinost na int koqto ima. Inache pri otricatelni 6te grumne
            // 
            for (int i = 0; i < numbersCount; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number <= CurrentMin)
                {
                    CurrentMin = number;
                }
            }

            Console.WriteLine(CurrentMin);




        }
    }
}

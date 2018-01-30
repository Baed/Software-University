using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Vowels_Sum
{
    class Program
    {
        static void Main(string[] args)

        {
            string text = Console.ReadLine();

            var sumSymbol = 0;

            for (int i = 0; i < text.Length; i++)
            {
                char symbol = text[i];

                if (symbol == 'a')
                {
                    sumSymbol += 1;
                }
                else if (symbol == 'e')
                {
                    sumSymbol += 2;
                }
                else if (symbol == 'i')
                {
                    sumSymbol += 3;
                }
                else if (symbol == 'o')
                {
                    sumSymbol += 4;
                }
                else if (symbol == 'u')
                {
                    sumSymbol += 5;
                }

            }

            Console.WriteLine(sumSymbol);

        }
    }
}

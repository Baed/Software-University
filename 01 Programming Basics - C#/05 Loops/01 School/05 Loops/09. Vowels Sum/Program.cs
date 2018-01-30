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

            var Sum = 0;

            for (int i = 0; i < text.Length; i++) //  text.Length - spazva duljinata na teksta ot string
            {
                char current = text[i]; // string text

                if (current == 'a')
                {
                    Sum += 1;
                }

                else if (current == 'e')
                {
                    Sum += 2;
                }

                else if (current == 'i')
                {
                    Sum += 3;
                }

                else if (current == 'o')
                {
                    Sum += 4;
                }

                else if (current == 'u')
                {
                    Sum += 5;
                }
            }

            Console.WriteLine(Sum);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Character_Multiplier
{
    class Program
    {
        private static readonly char[] separator = new[] { ' ', '!', '?', ',', '.', '-' };

        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(separator, StringSplitOptions.RemoveEmptyEntries);

            long result = GetSumOfCharProduct(input[0], input[1]);

            Console.WriteLine(result);
        }
        private static long GetSumOfCharProduct(string textA, string textB)
        {
            int result = 0;
            int maxLength = Math.Max(textA.Length, textB.Length);

            for (int i = 0; i < maxLength; i++)
            {
                int codeA = GetCharCode(textA, i);
                int codeB = GetCharCode(textB, i);
                result += codeA * codeB;
            }

            return result;
        }

        private static int GetCharCode(string text, int index)
        {
            if (index >= text.Length)
            {
                return 1;
            }

            return text[index];
        }
    }
}

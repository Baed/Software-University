using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._01_CharMultiplier
{
    class CharMultiplier
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            string first = input[0];
            string second = input[1];

            int minLength = Math.Min(input[0].Length, input[1].Length);
            long sum = 0;

            for (int i = 0; i < minLength; i++)
            {
                sum += first[i] * second[i];
            }

            if (first.Length < second.Length)
            {
                for (int i = first.Length; i < second.Length; i++)
                {
                    sum += second[i];
                }
            }
            else
            {
                for (int i = second.Length; i < first.Length; i++)
                {
                    sum += first[i];
                }
            }

            Console.WriteLine(sum);
        }
    }
}

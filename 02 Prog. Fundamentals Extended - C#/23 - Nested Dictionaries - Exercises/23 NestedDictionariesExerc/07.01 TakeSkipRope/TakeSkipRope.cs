using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._01_TakeSkipRope
{
    class TakeSkipRope
    {
        static void Main(string[] args)
        {


            var input = Console.ReadLine().ToCharArray().ToList();

            List<int> numbers = input.Where(x => IsDigit(x)).Select(x => int.Parse(x.ToString())).ToList();
            List<char> letters = input.Where(x => !IsDigit(x)).ToList();

            List<int> takeList = numbers.Where((x, i) => i % 2 == 0).ToList();
            List<int> skipList = numbers.Where((x, i) => i % 2 != 0).ToList();

            int skipCount = 0;

            for (int i = 0; i < takeList.Count; i++)
            {
                List<char> resultMessage = letters.Skip(skipCount).Take(takeList[i]).ToList();
                Console.Write(string.Join("", resultMessage));
                skipCount += takeList[i] + skipList[i];
            }

            Console.WriteLine();
        }

        static bool IsDigit(char symbol)
        {
           return '0' <= symbol && symbol <= '9';

        }
    }
}

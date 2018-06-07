using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._03_LongstIncreasingSubseq
{
    class LongstIncreasingSubseq
    {
        static void Main(string[] args)
        {
            List<int> numbersList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> longestSequens = ExecuteProgram(numbersList);

            Writer(longestSequens);
        }

        private static void Writer(List<int> longestSequens)
        {
            Console.WriteLine(string.Join(" ", longestSequens));
        }

        private static List<int> ExecuteProgram(List<int> numbersList)
        {
            int[] lengthArr = new int[numbersList.Count];
            int[] prevArr = new int[numbersList.Count];

            int maxLength = 0;
            int lastIndex = -1;

            for (int i = 0; i < numbersList.Count; i++)
            {
                lengthArr[i] = 1;
                prevArr[i] = -1;

                for (int j = 0; j < i; j++)
                {
                    if (numbersList[j] < numbersList[i] && lengthArr[j] >= lengthArr[i])
                    {
                        lengthArr[i] = 1 + lengthArr[j];
                        prevArr[i] = j;
                    }
                }

                if (lengthArr[i] > maxLength)
                {
                    maxLength = lengthArr[i];
                    lastIndex = i;
                }
            }

            var longestSeq = new List<int>();

            for (int i = 0; i < maxLength; i++)
            {
                longestSeq.Add(numbersList[lastIndex]);
                lastIndex = prevArr[lastIndex];
            }

            longestSeq.Reverse();

            return longestSeq.ToList();
        }
    }
}

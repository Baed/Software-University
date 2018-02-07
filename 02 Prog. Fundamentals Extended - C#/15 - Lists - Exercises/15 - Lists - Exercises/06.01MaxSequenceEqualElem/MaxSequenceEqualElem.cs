using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._01MaxSequenceEqualElem
{
    class MaxSeqEncreasingElem
    {
        static void Main(string[] args)
        {
            int[] arrNums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int startIndex = 0;
            int cnt = 0;
            int maxSeqIndex = 0;

            for (int i = 0; i < arrNums.Length - 1; i++)
            {
                if (arrNums[i] < arrNums[i + 1])
                {
                    cnt++;
                    if (cnt > maxSeqIndex)
                    {
                        startIndex = i - cnt;
                        maxSeqIndex = cnt;
                    }
                }
                else
                {
                    cnt = 0;
                }
            }
            for (int i = startIndex + 1; i <= startIndex + maxSeqIndex + 1; i++)
            {
                Console.Write(arrNums[i] + " ");
            }
            Console.WriteLine();
        }
    }
}

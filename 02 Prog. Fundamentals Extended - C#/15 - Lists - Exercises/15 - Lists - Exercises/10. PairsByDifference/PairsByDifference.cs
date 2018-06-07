using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.PairsByDifference
{
    class PairsByDifference
    {
        static void Main(string[] args)
        {
            int[] arrNums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int diffNum = int.Parse(Console.ReadLine());

            int cntDiffPair = 0;

            for (int i = 0; i < arrNums.Length; i++)
            {
                for (int j = i; j < arrNums.Length; j++)
                {
                    if (Math.Abs(arrNums[i] - arrNums[j]) == diffNum)
                    {
                        cntDiffPair++;
                    }
                }
            }

            Console.WriteLine(cntDiffPair);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._01_FoldAndSum
{
    class FoldAndSum
    {
        static void Main(string[] args)
        {
            int[] arrNums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int parameter = arrNums.Length / 4;

            int[] upperArr = new int[parameter * 2];

            int[] lowerArr = new int[parameter * 2];

            for (int i = 0; i < parameter; i++)
            {
                upperArr[i] = arrNums[parameter - 1 - i];
                upperArr[upperArr.Length - i - 1] = arrNums[arrNums.Length - parameter + i];
            }

            for (int i = 0; i < parameter * 2; i++)
            {
                lowerArr[i] = arrNums[i + parameter];
            }

            int[] sumOfArrs = new int[upperArr.Length];

            for (int i = 0; i < upperArr.Length; i++)
            {
                sumOfArrs[i] = upperArr[i] + lowerArr[i];
            }

            Console.WriteLine(string.Join(" ", sumOfArrs));
        }
    }
}

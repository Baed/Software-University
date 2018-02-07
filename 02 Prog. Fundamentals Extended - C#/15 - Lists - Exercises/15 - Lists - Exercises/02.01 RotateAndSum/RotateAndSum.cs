using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._01_RotateAndSum
{
    class RotateAndSum
    {
        static void Main(string[] args)
        {
            int[] arrNums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int cnt = int.Parse(Console.ReadLine());

            int[] sumArrs = new int[arrNums.Length];

            for (int i = 0; i < cnt; i++)
            {
                arrNums = GetRotatedArr(arrNums);

                for (int j = 0; j < arrNums.Length; j++)
                {
                    sumArrs[j] += arrNums[j];
                }
            }

            Console.WriteLine(string.Join(" ", sumArrs));
        }

        private static int[] GetRotatedArr(int[] arrNums)
        {
            int[] rotatedArr = new int[arrNums.Length];

            for (int i = 1; i < arrNums.Length; i++)
            {
                rotatedArr[i] = arrNums[i - 1];
            }

            rotatedArr[0] = arrNums[arrNums.Length - 1];

            return rotatedArr;
        }
    }
}

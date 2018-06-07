using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_EqualSums
{
    class EqualSums
    {
        static void Main(string[] args)
        {
            int[] arrNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            if (arrNumbers.Length == 1)
            {
                Console.WriteLine("0");
                return;
            }

            int leftSum = 0;
            int rightSum = 0;
            bool isSatisfiedRequirment = false;

            for (int i = 0; i < arrNumbers.Length; i++)
            {
                for (int leftCnt = 0; leftCnt < i; leftCnt++)
                {
                    leftSum += arrNumbers[leftCnt];
                }

                for (int rightCnt = i + 1; rightCnt < arrNumbers.Length; rightCnt++)
                {
                    rightSum += arrNumbers[rightCnt];
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    isSatisfiedRequirment = true;
                }
                else
                {
                    leftSum = rightSum = 0;
                }
            }

            if (!isSatisfiedRequirment)
            {
                Console.WriteLine("no");
            }
        }
    }
}

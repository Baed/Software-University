using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.IncreasSequenceElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrNum = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool isIncreasing = true;
            for (int i = 1; i < arrNum.Length; i++)
            {
                if (arrNum[i] < arrNum[i - 1])
                {
                    isIncreasing = false;
                    break;
                }
            }
            Console.WriteLine(isIncreasing == true ? "Yes" : "No");
        }
    }
}

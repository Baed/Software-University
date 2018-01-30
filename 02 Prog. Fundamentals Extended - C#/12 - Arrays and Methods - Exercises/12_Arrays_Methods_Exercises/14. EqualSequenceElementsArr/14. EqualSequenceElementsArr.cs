using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.EqualSequenceElementsArr
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int[] arrNum = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                arrNum[i] = int.Parse(input[i]);
            }
            bool isSame = true;
            for (int i = 1; i < arrNum.Length; i++)
            {
                if (arrNum[i] != arrNum[i - 1])
                {
                    isSame = false;
                    break;
                }
            }
            Console.WriteLine(isSame == true ? "Yes" : "No");
        }
    }
}

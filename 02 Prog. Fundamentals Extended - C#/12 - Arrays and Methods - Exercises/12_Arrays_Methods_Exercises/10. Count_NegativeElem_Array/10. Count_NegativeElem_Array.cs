using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Count_NegativeElem_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int[] arrNum = new int[input];
            int negativeValue = 0;
            for (int i = 0; i < arrNum.Length; i++)
            {
                arrNum[i] = int.Parse(Console.ReadLine());
                if (arrNum[i] < 0)
                {
                    negativeValue++;
                }
            }
            Console.WriteLine(negativeValue);
        }
    }
}

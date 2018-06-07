using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.CountOccurrencesNumArr
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            double[] arrNum = new double[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                arrNum[i] = double.Parse(input[i]);
            }
            double num = double.Parse(Console.ReadLine());
            int cnt = 0;
            for (int i = 0; i < arrNum.Length; i++)
            {
                if (arrNum[i] > num)
                {
                    cnt++;
                }
            }
            Console.WriteLine(cnt);
        }
    }
}

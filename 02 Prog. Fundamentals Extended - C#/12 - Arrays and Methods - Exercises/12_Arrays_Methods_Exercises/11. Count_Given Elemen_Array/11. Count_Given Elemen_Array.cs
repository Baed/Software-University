using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Count_Given_Elemen_Array
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

            int num = int.Parse(Console.ReadLine());
            int cnt = 0;
            for (int i = 0; i < arrNum.Length; i++)
            {
                if (arrNum[i] == num)
                {
                    cnt++;
                }
            }
            Console.WriteLine(cnt);
        }
    }
}

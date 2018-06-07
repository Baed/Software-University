using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Sum_Array_Elements
{
    class Program
    {
        static void Main(string[] args)
        {

            //int n = int.Parse(Console.ReadLine());
            int[] arrNum = new int[int.Parse(Console.ReadLine())];
            for (int i = 0; i < arrNum.Length; i++)
            {
                arrNum[i] = int.Parse(Console.ReadLine());
            }
            int sum = 0;
            for (int i = 0; i < arrNum.Length; i++)
            {
                sum += arrNum[i];
            }
            Console.WriteLine(sum);
        }
    }
}

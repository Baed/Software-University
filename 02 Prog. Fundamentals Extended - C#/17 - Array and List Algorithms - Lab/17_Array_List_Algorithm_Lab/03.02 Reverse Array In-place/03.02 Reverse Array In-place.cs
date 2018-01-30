using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._02_Reverse_Array_In_place
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] resultArr = new int[arr.Length];

            int counterIndex = 0;

            for (int index = arr.Length - 1; index >= 0; index--)
            {
                resultArr[counterIndex] = arr[index];
                counterIndex++;
            }

            Console.WriteLine(string.Join(" ", resultArr));
        }
    }
}

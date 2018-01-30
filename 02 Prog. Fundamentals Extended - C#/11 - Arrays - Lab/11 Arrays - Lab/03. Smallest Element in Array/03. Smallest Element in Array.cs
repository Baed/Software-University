using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Smallest_Element_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int[] arrNum = new int[input.Length];
            //int[] arrNum = new int[int.Parse(Console.ReadLine())];
            for (int i = 0; i < input.Length; i++)
            {
                arrNum[i] = int.Parse(input[i]);
            }

            int minValue = int.MaxValue; // sravnqva me po max golemina na int

            for (int i = 0; i < arrNum.Length; i++)
            {
                if (arrNum[i] < minValue)
                {
                    minValue = arrNum[i];
                }
            }
            Console.WriteLine(minValue);
        }
    }
}

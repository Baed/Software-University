using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._02_Odd_Numbers_at_Odd_Positions
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 1; i < arr.Length; i += 2)
            {
                if (arr[i] % 2 != 0)
                {
                    Console.WriteLine("Index {0} -> {1}", i, arr[i]);
                }
            }

        }
    }
}

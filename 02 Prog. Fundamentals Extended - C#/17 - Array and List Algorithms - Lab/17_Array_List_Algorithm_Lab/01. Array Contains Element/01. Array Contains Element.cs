using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Array_Contains_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int elementToFind = int.Parse(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == elementToFind)
                {
                    Console.WriteLine("yes");
                    return;
                }
            }
            Console.WriteLine("no");
        }
    }
}

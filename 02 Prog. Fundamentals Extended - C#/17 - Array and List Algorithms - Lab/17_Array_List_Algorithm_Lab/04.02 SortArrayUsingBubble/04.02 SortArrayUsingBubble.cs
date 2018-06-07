using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._02_SortArrayUsingBubble
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            bool swapped;
            do
            {
                swapped = false;
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        Swap(arr, i, i + 1); // todo: write swap method
                        swapped = true;
                    }
                }
            } while (swapped);

            Console.WriteLine(string.Join(" ", arr));

        }

        private static void Swap(int[] arr, int currentIndex, int nextIndex)
        {
            
        }
    }
}

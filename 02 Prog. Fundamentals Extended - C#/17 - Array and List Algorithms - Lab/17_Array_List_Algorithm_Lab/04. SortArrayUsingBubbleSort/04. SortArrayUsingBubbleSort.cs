using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SortArrayUsingBubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            BubbleSort(arr);

            Console.WriteLine(string.Join(" ", arr));
        }

        static void BubbleSort(int[] arr)
        {
            while (true)
            {
                bool IsSwapped = false;
                for (int index = 0; index < arr.Length - 1; index++)
                {
                    if (arr[index] > arr[index + 1])
                    {
                        Swap(ref arr[index], ref arr[index + 1]);
                        IsSwapped = true;
                    }
                }
                if (!IsSwapped)
                {
                    break;
                }
            }

        }

        static void Swap(ref int first, ref int second)
        {
            int temp = first;
            first = second;
            second = temp;
        }
    }
}

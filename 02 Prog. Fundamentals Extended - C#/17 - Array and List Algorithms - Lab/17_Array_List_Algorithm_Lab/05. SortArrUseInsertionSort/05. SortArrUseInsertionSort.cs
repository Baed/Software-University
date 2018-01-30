using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.SortArrUseInsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            InsertionSort(arr);

            Console.WriteLine(string.Join(" ", arr));
        }

        static void InsertionSort(int[] arr)
        {
            for (int firstIndex = 1; firstIndex < arr.Length; firstIndex++)
            {
                for (int secondIndex = firstIndex; secondIndex > 0; secondIndex--)
                {
                    if (arr[secondIndex] < arr[secondIndex - 1])
                    {
                        Swap(ref arr[secondIndex - 1], ref arr[secondIndex]);
                    }
                    else
                    {
                        break;
                    }
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

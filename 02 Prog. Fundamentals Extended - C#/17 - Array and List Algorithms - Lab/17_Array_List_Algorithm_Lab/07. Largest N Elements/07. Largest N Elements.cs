using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Largest_N_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();


            int n = int.Parse(Console.ReadLine());

            BubbleSort(arr);

            Console.WriteLine(string.Join(" ", arr));
        }

        static List<int> InsertionSort(List<int> list ,ref int n)
        {
            List<int> resultList = new List<int>();

            for (int firstIndex = 0; firstIndex < list.Count; firstIndex++)
            {
                int elementToInsert = list[firstIndex];
                bool HasInserted = false;

                for (int secondIndex = 0; secondIndex < resultList.Count; secondIndex++)
                {
                    int currentListElement = resultList[secondIndex];
                    if (elementToInsert < currentListElement)
                    {
                        resultList.Insert(secondIndex, elementToInsert);
                        HasInserted = true;
                        break;
                    }
                }
                if (!HasInserted)
                {
                    resultList.Add(elementToInsert);
                }
            }
            return resultList;
        }
        static void BubbleSort(int[] arr)
        {
            while (true)
            {
                bool IsSwapped = false;
                for (int index = 0; index < arr.Length - 1; index++)
                {
                    if (arr[index] < arr[index + 1]) // izmestvane na po-malkite na dqsno
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

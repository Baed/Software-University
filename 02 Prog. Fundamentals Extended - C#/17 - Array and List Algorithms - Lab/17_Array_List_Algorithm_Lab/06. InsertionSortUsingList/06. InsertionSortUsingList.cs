using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.InsertionSortUsingList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> resultList = InsertionSort(list);

            Console.WriteLine(string.Join(" ", resultList));
        }

        static List<int> InsertionSort(List<int> list)
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
    }
}

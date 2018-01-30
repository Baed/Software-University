using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Distinct_List
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputElements = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            List<int> distinctElements = new List<int>();

            for (int i = 0; i < inputElements.Length; i++)
            {
                int currentElement = inputElements[i];

                if (!distinctElements.Contains(currentElement))
                {
                    distinctElements.Add(currentElement);
                }
            }
            Console.WriteLine(string.Join(" ", distinctElements));
        }
    }
}

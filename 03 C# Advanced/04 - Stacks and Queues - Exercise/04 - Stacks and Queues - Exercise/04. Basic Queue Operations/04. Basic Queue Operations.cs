using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstLine = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] secondLine = Console.ReadLine()
                 .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();

            int elementsCount = firstLine[0];
            int elementsToRemove = firstLine[1];
            int element = firstLine[2];

            var queue = new Queue<int>(secondLine);

            for (int i = 0; i < elementsToRemove; i++)
            {
                queue.Dequeue();
            }

            Console.WriteLine(queue.Count == 0 ? "0" : queue.Contains(element) ? "true" : $"{queue.Min()}");
        }
    }
}

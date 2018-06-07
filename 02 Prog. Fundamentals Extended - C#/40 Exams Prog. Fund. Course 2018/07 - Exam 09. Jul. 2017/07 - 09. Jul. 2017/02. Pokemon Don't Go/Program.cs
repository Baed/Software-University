using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _02.Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> collection = Console.ReadLine()
                .Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToList();

            long sumOfRemovedElements = 0;

            while (collection.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());
                long removedElement = 0;

                if (index < 0)
                {
                    removedElement = collection[0];
                    sumOfRemovedElements += removedElement;
                    collection[0] = collection[collection.Count - 1];
                }
                else if (index > collection.Count - 1)
                {
                    removedElement = collection[collection.Count - 1];
                    sumOfRemovedElements += removedElement;
                    collection[collection.Count - 1] = collection[0];
                }
                else
                {
                    removedElement = collection[index];
                    sumOfRemovedElements += removedElement;
                    collection.RemoveAt(index);
                }

                for (int i = 0; i < collection.Count; i++)
                {
                    if (collection[i] <= removedElement)
                    {
                        collection[i] += removedElement;
                    }
                    else
                    {
                        collection[i] -= removedElement;
                    }
                }
            }
            Console.WriteLine(sumOfRemovedElements);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Ununion_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> primalList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int listsCnt = int.Parse(Console.ReadLine());

            for (int i = 0; i < listsCnt; i++)
            {
                List<int> currentList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

                for (int j = 0; j < currentList.Count; j++)
                {
                    int currentElement = currentList[j];

                    if (primalList.Contains(currentElement))
                    {
                        primalList.RemoveAll(a => a == currentElement); // remove --> mahame ednakviq element ot spisucite;
                    }
                    else
                    {
                        primalList.Add(currentElement);
                    }
                }
            }
            primalList.Sort();
            Console.WriteLine(string.Join(" ", primalList));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._02_Distinct_List
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputElements = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            HashSet<int> distinctElements = new HashSet<int>(inputElements);
            // svoistvo da pazi samo unikalni elementi (set - mnovejstvo)
            // Hash - funkciata

            Console.WriteLine(string.Join(" ", distinctElements));
        }
    }
}

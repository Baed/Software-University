using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CountSubstringOccurr
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            string term = Console.ReadLine().ToLower();

            int index = text.IndexOf(term);

            int occurences = 0;

            while (index != -1)
            {
                occurences++;
                index = text.IndexOf(term, index + 1); // tursim ot index
            }

            Console.WriteLine(occurences);
        }
    }
}

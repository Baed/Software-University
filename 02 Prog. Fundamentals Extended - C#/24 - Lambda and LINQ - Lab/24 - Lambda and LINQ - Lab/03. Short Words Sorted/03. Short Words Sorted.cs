using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Short_Words_Sorted
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] delimeters = ".,:;()[]\"'\\/!? ".ToCharArray();

            string[] word = Console.ReadLine()
                .ToLower()
                .Split(delimeters, StringSplitOptions.RemoveEmptyEntries)
                .Distinct()
                .Where(w => w.Length < 5)
                .OrderBy(w => w)
                .ToArray();

            Console.WriteLine(string.Join(", ", word));
        }
    }
}

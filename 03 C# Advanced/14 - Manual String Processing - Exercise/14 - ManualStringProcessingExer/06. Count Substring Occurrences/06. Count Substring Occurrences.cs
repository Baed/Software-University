using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Count_Substring_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToLower();
            string key = Console.ReadLine().ToLower();

            int indexOfKey = input.IndexOf(key);
            int occurrences = 0;

            while (indexOfKey >= 0)
            {
                occurrences++;
                indexOfKey = input.IndexOf(key, indexOfKey + 1);
            }

            Console.WriteLine(occurrences);
        }
    }
}

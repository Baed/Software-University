using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._01_SortTimes
{
    class SortTimes
    {
        static void Main(string[] args)
        {
            var timeList = Console.ReadLine()
                .Split(' ')
                .OrderBy(t => t)
                .ToList();
            Console.WriteLine(string.Join(", ", timeList));
        }
    }
}

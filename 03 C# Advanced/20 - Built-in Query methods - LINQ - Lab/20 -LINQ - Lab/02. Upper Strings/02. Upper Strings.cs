using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Upper_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(a => a.ToUpper())
                .ToList()
                .ForEach(t => Console.Write(t + " "));

            Console.WriteLine();
        }
    }
}

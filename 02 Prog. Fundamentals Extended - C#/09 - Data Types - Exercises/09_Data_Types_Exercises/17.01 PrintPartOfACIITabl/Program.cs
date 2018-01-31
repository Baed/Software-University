using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._01_PrintPartOfACIITabl
{
    class Program
    {
        static void Main(string[] args)
        {
            var startNum = int.Parse(Console.ReadLine());
            var finalNum = int.Parse(Console.ReadLine());

            for (int i = startNum; i <= finalNum; i++)
            {
                Console.Write($"{(char)i} ");
            }

            Console.WriteLine();
        }
    }
}

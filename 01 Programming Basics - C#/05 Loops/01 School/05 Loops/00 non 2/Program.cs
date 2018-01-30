using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_non_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 5;

            number--;

            Console.WriteLine(number--); // 4 predi
            Console.WriteLine(number); // 3 
            Console.WriteLine(--number);// 2 sled operaciqta 3 - 1 = 0
        }
    }
}

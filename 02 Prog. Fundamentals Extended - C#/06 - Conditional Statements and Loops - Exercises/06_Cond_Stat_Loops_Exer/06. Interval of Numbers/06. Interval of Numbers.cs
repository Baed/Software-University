using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Interval_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int stop = int.Parse(Console.ReadLine());
            if (n < stop)
            {
                while (n <= stop)
                {
                    Console.WriteLine(n);
                    n++;
                }
            }
            else
            {
                while (n >= stop)
                {
                    Console.WriteLine(stop);
                    stop++;
                }
            }

        }
    }
}

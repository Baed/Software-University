using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_test_4
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Beginning");
                if (i % 2 == 0)
                {
                    continue; // vliza v sledvashtata iteraciq, a pri break spira;
                }
                Console.WriteLine(i);
            }
        }
    }
}

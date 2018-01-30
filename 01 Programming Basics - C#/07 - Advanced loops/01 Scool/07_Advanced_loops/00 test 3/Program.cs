using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_test_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            while (true)
            {
                Console.WriteLine(num++);
                if (num>1000)
                {
                    break;
                }
            }
        }
    }
}

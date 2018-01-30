using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Задача_04___Деление_без_остатък
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double modul1 = 0.00;
            double modul2 = 0.00;
            double modul3 = 0.00;
            double count = 0.00;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                ++count;

                if ((number % 2 == 0))
                {
                    ++modul1;
                }
                if ((number % 3 == 0))
                {
                    ++modul2;
                }
                if ((number % 4 == 0))
                {
                    ++modul3;
                }

            }

            Console.WriteLine($"{100 * modul1 / count:f2}%");
            Console.WriteLine($"{100 * modul2 / count:f2}%");
            Console.WriteLine($"{100 * modul3 / count:f2}%");
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
           

            double count1 = 0;
            double count2 = 0;
            double count3 = 0;
            double count4 = 0;
            double count5 = 0;
            double count = 0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                ++count;

                if (number >= 800)
                {
                    ++count5;
                }
                   
                if (number >= 600)
                {
                    ++count4;
                }
                    
                if (number >= 400)
                {
                    ++count3;
                }
                    
                if (number >= 200)
                {
                    ++count2;
                }
                    
                if (number < 200)
                {
                    ++count1;
                }
                   
            }

            Console.WriteLine($"{100 * count1 / count:f2}%");
            Console.WriteLine($"{100 * count2 / count:f2}%");
            Console.WriteLine($"{100 * count3 / count:f2}%");
            Console.WriteLine($"{100 * count4 / count:f2}%");
            Console.WriteLine($"{100 * count5 / count:f2}%");
        }
    }
}

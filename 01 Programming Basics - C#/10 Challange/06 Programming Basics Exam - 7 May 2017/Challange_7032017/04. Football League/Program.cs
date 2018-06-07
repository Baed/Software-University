using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Football_League
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());
            int fans_num = int.Parse(Console.ReadLine());

            double A_sec = 0.0;
            double B_sec = 0.0;
            double V_sec = 0.0;
            double G_sec = 0.0;

            for (int i = 1; i <= fans_num; i++)
            {
                string sector = Console.ReadLine();

                if (sector == "A")
                {
                    A_sec ++;
                }
                else if (sector == "B")
                {
                    B_sec ++;
                }
                else if (sector == "V")
                {
                    V_sec ++;
                }
                else if (sector == "G")
                {
                    G_sec ++;
                }
            }

            Console.WriteLine($"{A_sec / fans_num * 100:f2}%");
            Console.WriteLine($"{B_sec / fans_num * 100:f2}%");
            Console.WriteLine($"{V_sec / fans_num * 100:f2}%");
            Console.WriteLine($"{G_sec / fans_num * 100:f2}%");
            Console.WriteLine($"{(100 * (double)fans_num /capacity):f2}%");
        }
    }
}

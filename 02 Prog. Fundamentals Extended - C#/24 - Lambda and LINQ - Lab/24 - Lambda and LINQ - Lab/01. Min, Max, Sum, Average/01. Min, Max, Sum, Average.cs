using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Min__Max__Sum__Average
{
    class Program
    {
        static void Main(string[] args)
        {
            int cnt = int.Parse(Console.ReadLine());

            List<int> numbers = new List<int>();

            for (int i = 0; i < cnt; i++)
            {
                //numbers.Add(int.Parse(Console.ReadLine()));
                int numToAd = int.Parse(Console.ReadLine());
                numbers.Add(numToAd);
            }

            Console.WriteLine($"Sum = {numbers.Sum()}");
            Console.WriteLine($"Min = {numbers.Min()}");
            Console.WriteLine($"Max = {numbers.Max()}");
            Console.WriteLine($"Average = {numbers.Average()}");
        }
    }
}

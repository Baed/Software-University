using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Count_the_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            var ctr = 0;
            while (true)
            {
                try
                {
                    int n = int.Parse(Console.ReadLine());
                    ctr++;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ctr}");
                    break;
                }
            }
        }
    }
}

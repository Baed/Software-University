using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_non_01
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            for (int V = 0; V < n; V++)
            {
                for (int H = 0; H <= V; H++)
                {
                    Console.Write("* ");  
                }
                Console.WriteLine();
            }
        }
    }
}

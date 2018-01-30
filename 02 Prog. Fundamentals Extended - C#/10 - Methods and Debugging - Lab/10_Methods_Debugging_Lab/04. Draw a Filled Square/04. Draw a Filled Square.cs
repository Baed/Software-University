using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Draw_a_Filled_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            FirstLastRow(n);
            MiddleRow(n);
            FirstLastRow(n);
        }
        static void FirstLastRow(int n)
        {
            Console.WriteLine("{0}", new string('-', n * 2));
        }
        static void MiddleRow(int n)
        {
            for (int i = 0; i < n - 2; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('-', 1), new string('s', n - 1).Replace("s","\\/"));
            }
        }
    }
}

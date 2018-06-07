using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Christmas_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string middle = " | ";
            
            for (int row = 0; row <= n; row++) // ????? row = 0; row <=n ili pri row = 1 ; row <= n + 1
            {
                string spaces = "";
                string stars = "";

                for (int sp = 0; sp < n - row; sp++)
                {
                    spaces += " ";
                }

                for (int st = 0; st < row; st++)
                {
                    stars += "*";
                }
                Console.WriteLine($"{spaces}{stars}{middle}{stars}");
            }
        }
    }
}

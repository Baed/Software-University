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

            var pipe = " | ";
            
            for (int row = 0; row < n + 1; row++)
            {
                var stars = "";
                var space = "";

                for (int space_cow = 0; space_cow < n - row; space_cow++)
                {
                    space += " ";
                }

                for (int stars_cow = 0; stars_cow < row; stars_cow++)
                {
                    stars += "*";
                }
                Console.WriteLine($"{space}{stars}{pipe}{stars}");
            }

            /*for (int i = 0; i <= n; i++)  !!! zaradi 1vi prazen red i <= n !!!
            {
                var space = new string(' ', n - i);
                var stars = new string('*', i);

                Console.WriteLine($"{space}{stars}{pipe}{stars}");
            }
            */
        }
    }
}

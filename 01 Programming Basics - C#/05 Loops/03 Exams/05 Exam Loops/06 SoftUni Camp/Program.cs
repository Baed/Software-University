using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_SoftUni_Camp
{
    class Program
    {
        static void Main(string[] args)
        {
            int group = int.Parse(Console.ReadLine());

            var group1 = 0.0;
            var group2 = 0.0;
            var group3 = 0.0;
            var group4 = 0.0;
            var group5 = 0.0;
            var groupAll = 0.0;

            for (int i = 1; i <= group; i++)
            {
                int students = int.Parse(Console.ReadLine());
                groupAll += students;

                if (students >= 41)
                {
                    group5 += students;
                }

                else if (students >= 26)
                {
                    group4 += students;
                }

                else if (students >= 13)
                {
                    group3 += students;
                }

                else if (students >= 6)
                {
                    group2 += students;
                }

                else if (students >= 1)
                {
                    group1 += students;
                }

               
            }

            Console.WriteLine($"{(100 * group1 / groupAll):f2}%");
            Console.WriteLine($"{(100 * group2 / groupAll):f2}%");
            Console.WriteLine($"{(100 * group3 / groupAll):f2}%");
            Console.WriteLine($"{(100 * group4 / groupAll):f2}%");
            Console.WriteLine($"{(100 * group5 / groupAll):f2}%");
            

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Grades
{
    class Program
    {
        static void Main(string[] args)
        {

            int students = int.Parse(Console.ReadLine());

            var top = 0.0;
            var bet4and5 = 0.0;
            var bet3and4 = 0.0;
            var fail = 0.0;
            var gratesAll = 0.0;
            var gratesValue = 0.0;

            for (int i = 1; i <= students; i++)
            {
                double grades = double.Parse(Console.ReadLine());
                gratesAll++;
                gratesValue += grades;

                if (grades >= 5.00)
                {
                    top++;
                    //top += grades;
                }
                else if (grades >= 4)
                {
                    bet4and5++;
                    //bet4and5 += grades;
                }
                else if (grades >= 3)
                {
                    bet3and4++;
                    //bet3and4 += grades;
                }
                else if (grades >= 2)
                {
                    fail++;
                    //fail += grades;
                }
            }

            double average = (gratesValue / students);
            Console.WriteLine($"Top students: {(100 * top / gratesAll):f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {(100 * bet4and5 / gratesAll):f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {(100 * bet3and4 / gratesAll):f2}%");
            Console.WriteLine($"Fail: {(100 * fail / gratesAll):f2}%");
            Console.WriteLine($"Average: {average:f2}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int student = int.Parse(Console.ReadLine());

            var top = 0.0;
            var five_to_for = 0.0;
            var for_to_tree = 0.0;
            var fail = 0.0;
            var grades_All = 0.0;
            var average_grades = 0.0;

            for (int i = 1; i <= student; i++)
            {
                double grades = double.Parse(Console.ReadLine());               
                grades_All++;
                average_grades += grades;

                if (grades >= 5)
                {
                    top++;                   
                }
                else if (grades >= 4)
                {
                    five_to_for++;                  
                }
                else if (grades >= 3)
                {
                    for_to_tree++;                   
                }
                else if (grades >= 2)
                {
                    fail++;
                }
            }

            var average = average_grades / student;

            Console.WriteLine($"Top students: {(100 * top/ grades_All):f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {(100 * five_to_for / grades_All):f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {100 * for_to_tree / grades_All:f2}%");
            Console.WriteLine($"Fail: {(100 * fail / grades_All):f2}%");
            Console.WriteLine($"Average: {average:f2}");
        }
    }
}

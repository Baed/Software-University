using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_03_09_17_task_2_scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double icome = double.Parse(Console.ReadLine());
            double grade = double.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());

            var social_scholarship = 0.0;
            var grade_scholarship = 0.0;

            if (icome < salary && grade > 4.50)
            {
                social_scholarship = salary * 0.35;
            }

            if (grade >= 5.50)
            {
            grade_scholarship = grade * 25;
            }

            if (grade_scholarship == 0 && social_scholarship == 0)
            {
                Console.WriteLine
                    ("You cannot get a scholarship!");
            }
            else if (social_scholarship > grade_scholarship)
            {
                Console.WriteLine
                    ($"You get a Social scholarship {Math.Floor(social_scholarship)} BGN");
            }
            else
            {
                Console.WriteLine
                    ($"You get a scholarship for excellent results {Math.Floor(grade_scholarship)} BGN");
                
            }

        }
    }
}

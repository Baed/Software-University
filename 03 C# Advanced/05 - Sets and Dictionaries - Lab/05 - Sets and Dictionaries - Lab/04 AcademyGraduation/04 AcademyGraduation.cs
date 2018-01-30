using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_AcademyGraduation
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var students = new SortedDictionary<string, Stack<double>>();

            for (int i = 0; i < n; i++)
            {
                var name = Console.ReadLine();
                var grades = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse);

                if (!students.ContainsKey(name))
                {
                    students[name] = new Stack<double>();
                }

                foreach (var grade in grades)
                {
                    students[name].Push(grade);
                }
            }
            foreach (var student in students)
            {
                Console.WriteLine(string.Join("\r\n", $"{student.Key} is graduated with {student.Value.Average()}"));

            }
            //Console.WriteLine
            //    (string.Join(Environment.NewLine, students
            //            .Select(s => $"{s.Key} is graduated with {s.Value.Average()}")));

        }
    }
}

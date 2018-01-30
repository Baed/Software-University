using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentsGradesBook = new Dictionary<string, List<double>>();

            int counter = int.Parse(Console.ReadLine());

            for (int i = 0; i < counter; i++)
            {
                string[] tokens = Console.ReadLine().Split(' ');
                string name = tokens[0];
                double grade = double.Parse(tokens[1]);

                if (!studentsGradesBook.ContainsKey(name))
                {
                    studentsGradesBook.Add(name, new List<double>());
                }

                studentsGradesBook[name].Add(grade);
            }

            foreach (var item in studentsGradesBook)
            {
                string name = item.Key;
                List<double> gradeItems = item.Value;
                double averageGrade = item.Value.Average();
                /*
                Console.WriteLine("{0} -> {1} (avg:{2})", 
                    name, 
                    
                    string.Join(" ", gradeItems.Select(g => string.Format("{0:f2}", g).ToArray()),
                    averageGrade)); // za formatiraneto do vtori znak sled zapetaqta
                    */
                Console.Write($"{name} -> ");

                foreach (var grades in gradeItems)
                {
                    Console.Write("{0:f2} ", grades);
                }

                Console.WriteLine($"(avg: {averageGrade:f2})");
            }
        }
    }
}

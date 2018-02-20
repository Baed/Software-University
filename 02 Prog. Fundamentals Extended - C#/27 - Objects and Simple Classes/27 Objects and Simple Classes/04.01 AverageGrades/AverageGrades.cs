using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._01_AverageGrades
{
    public class AverageGrades
    {
        static void Main(string[] args)
        {
            List<Student> students = CreateStudentsList();

            List<string> topstudents = students
                .Where(s => s.AverageGrade >= 5)
                .Select(n => n.Name)
                .Distinct()
                .OrderBy(st => st)
                .ToList();

            foreach (var student in topstudents)
            {
                List<double> avrgGradesStudent = students
                    .Where(s => s.Name == student && s.AverageGrade >= 5)
                    .Select(s => s.AverageGrade)
                    .OrderByDescending(st => st)
                    .ToList();

                foreach (var studentAvrgGrade in avrgGradesStudent)
                {
                    Console.WriteLine($"{student} -> {studentAvrgGrade:f2}");
                }
            }
        }

        private static List<Student> CreateStudentsList()
        {
            List<Student> studentList = new List<Student>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                List<double> grades = new List<double>();

                for (int j = 1; j < tokens.Length; j++)
                {
                    grades.Add(double.Parse(tokens[j]));
                }

                Student student = new Student(tokens[0], grades);

                studentList.Add(student);
            }

            return studentList;
        }
    }

    public class Student
    {
        private string name;
        private List<double> grades;

        public Student(string name, List<double> grades)
        {
            this.name = name;
            this.grades = new List<double>(grades);
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public List<double> Grades
        {
            get { return this.grades; }
            set { this.grades = value; }
        }

        public double AverageGrade
        {
            get { return this.grades.Average(); }
        }
    }
}

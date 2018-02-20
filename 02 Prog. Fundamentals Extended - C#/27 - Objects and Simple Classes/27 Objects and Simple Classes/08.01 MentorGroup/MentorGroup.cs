using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._01_MentorGroup
{
    class MentorGroup
    {
        static void Main(string[] args)
        {
            List<Student> students = Reader();

            ExecuteProgram(students);

            Writer(students);
        }

        private static void Writer(List<Student> students)
        {
            foreach (var student in students.OrderBy(s => s.Name))
            {
                Console.WriteLine($"{student.Name}");

                Console.WriteLine($"Comments:");

                foreach (var studentComment in student.Comments.Where(s => s != null))
                {
                    Console.WriteLine($"- {studentComment}");
                }

                Console.WriteLine($"Dates attended:");

                foreach (var studentDateTime in student.Dates.OrderBy(d => d).Where(s => s != null))
                {
                    Console.WriteLine($"-- {studentDateTime:dd/MM/yyyy}");
                }

            }
        }

        private static void ExecuteProgram(List<Student> students)
        {
            Student person = new Student("", new List<string>(), new List<DateTime>());

            string input;
            while ((input = Console.ReadLine()) != "end of comments")
            {
                var tokens = input.Split(new[] { '-' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                if (students.Any(s => s.Name.Equals(tokens[0])))
                {
                    person = students.FirstOrDefault(s => s.Name.Equals(tokens[0]));
                    person.Comments.Add(tokens[1]);
                }
            }
        }

        private static List<Student> Reader()
        {
            Student person = new Student("", new List<string>(), new List<DateTime>());
            List<Student> students = new List<Student>();

            string input;
            while ((input = Console.ReadLine()) != "end of dates")
            {
                List<DateTime> dateTimes = new List<DateTime>();

                var tokens = input.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 1; i < tokens.Length; i++)
                {
                    dateTimes.Add(DateTime.ParseExact(tokens[i], "dd/MM/yyyy", CultureInfo.InvariantCulture));
                }

                if (students.Any(s => s.Name.Equals(tokens[0])))
                {
                    person = students.FirstOrDefault(s => s.Name.Equals(tokens[0]));
                    person.Dates.AddRange(dateTimes);

                }
                else
                {
                    person = new Student(tokens[0], new List<string>(), dateTimes);
                    students.Add(person);
                }
            }

            return students;
        }
    }

    class Student
    {
        public Student(string name, List<string> comments, List<DateTime> dates)
        {
            this.Name = name;
            this.Comments = comments;
            this.Dates = dates;
        }

        public string Name { get; set; }

        public List<string> Comments { get; set; }

        public List<DateTime> Dates { get; set; }
    }
}

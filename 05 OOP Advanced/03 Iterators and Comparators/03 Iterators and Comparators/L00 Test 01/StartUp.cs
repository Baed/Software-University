using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L00_Test_01
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Student studentOne = new Student("Pesho", 19, "H0013FM");
            Student studentTwo = new Student("Goshko", 22, "H1113CY");
            Student studentThree = new Student("Stavri", 33, "H223DZ");

            University softUni = new University();
            softUni.AddStudent(studentOne);
            softUni.AddStudent(studentTwo);
            softUni.AddStudent(studentThree);

            foreach (var student in softUni)
            {
                Console.WriteLine(student.Name);
            }

            Console.WriteLine(new string('-', 20));

            PrintNames("Pesho", "Stamat", "Jivko", "Stavri"); // first element is prefix, the rest of element are params 

            Console.WriteLine(new string('-', 20));

            SortedSet<Student> sortedStudents = new SortedSet<Student>(new StudentComparator()); // 

            sortedStudents.Add(studentOne);
            sortedStudents.Add(studentTwo);
            sortedStudents.Add(studentThree);



            foreach (var student in sortedStudents)
            {
                Console.WriteLine(student.Name);
            }
        }

        public static void PrintNames(string prefix, params string[] names) // params are always last
        {
            foreach (var name in names)
            {
                Console.WriteLine($"{prefix} {name}");
            }
        }
    }
}

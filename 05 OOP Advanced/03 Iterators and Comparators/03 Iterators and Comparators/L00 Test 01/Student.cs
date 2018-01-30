using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L00_Test_01
{
    public class Student // : IComparable<Student>
    {
        public Student(string name, int age, string facultyNumber)
        {
            this.Name = name;
            this.Age = age;
            this.FacultyNumber = facultyNumber;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public string FacultyNumber { get; set; }

        // using IComparable<Student>

        //public int CompareTo(Student otherStudent) // return int : -1, 0, 1 
        //{
        //    // int result = this.Age.CompareTo(otherStudent.Age);
        //
        //    if (this.Age != otherStudent.Age)
        //    {
        //        return this.Age - otherStudent.Age;
        //    }
        //
        //    if (this.Name != otherStudent.Name)
        //    {
        //        return this.Name.CompareTo(otherStudent.Name);
        //    }
        //
        //    return 0; // if equals
        //}
    }

}

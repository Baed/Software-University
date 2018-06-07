using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class StartUp
{
    public static void Main(string[] args)
    {
        Student student = new Student(122);

        student.Name = "Pesho";
        student.Age = 22;

        student.School = "SoftUni";

        student.Print();
    }
}

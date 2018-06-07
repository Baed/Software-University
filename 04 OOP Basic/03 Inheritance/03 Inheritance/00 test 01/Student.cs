using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Student : Person
{
    private string school;
    private double height;

    public Student(double height)
        :base(height) // base constructor --> Person
    {
        // emty
    }

    public string School
    {
        get { return school; }
        set { school = value; }
    }

    public void Print()
    {
        double height = 177.7;
        Console.WriteLine(height);
        Console.WriteLine(this.height);
        Console.WriteLine(base.height);
    }
}


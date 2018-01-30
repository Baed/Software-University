using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_StudentByGroup
{
    using System.Runtime.InteropServices;

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string[]>students = new List<string[]>();
            while (input != "END")
            {
                string[] inputArgs = input.Split();
                
                students.Add(inputArgs);
                input = Console.ReadLine();
            }
            students
                .Where(x=>x[2].Equals("2"))
                .OrderBy(x=>x[0])
                .ToList()
                .ForEach(x=>Console.WriteLine(x[0] + " " + x[1]));
        }
    }
}

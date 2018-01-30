using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Transport
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            double courses = Math.Ceiling((double)n / 24);          
            Console.WriteLine(courses);
            double result = n % 24;
            Console.WriteLine
                ($"courses {result} * 24 persons + {courses - result} course * {result} person");
            
        }
    }
}

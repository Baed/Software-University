using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Action_Prints
{
    class Program
    {
        static void Main(string[] args)
        {
            var persons = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Action<string> printer = x => Console.WriteLine(x);

            foreach (var person in persons)
            {
                printer(person);
            }
        }
    }
}

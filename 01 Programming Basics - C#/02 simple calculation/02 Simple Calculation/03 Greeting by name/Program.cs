using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Greeting_by_name
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Enter Your name and see what happened");
            // Console.Write("Enter your name: "); s tova gurmi
            var name = Console.ReadLine();
            //Console.WriteLine("Hello, {0}!", name);
            Console.WriteLine($"Hello, {name}!");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_sublime_tex_and_num___second_exercise
{
    class Program
    {
        static void Main(string[] args)
        {

            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            var town = Console.ReadLine();

            // Console.WriteLine(firstName + " " + lastName);

            //Console.WriteLine("You are {0} {1}, a {2} - years old person from {3}", firstName, lastName, age, town);

            Console.WriteLine($"You are {firstName} {lastName}, a {age} - years old person from {town}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Gender
{
    class Program
    {
        static void Main(string[] args)
        {

            var age = double.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            
            if (gender == 'f')
            {
                if (age < 16)
                {
                    Console.WriteLine( "Miss");
                }
                else
                {
                    Console.WriteLine("Ms.");
                }
            }

            else  /* if(gender == 'm')*/
            {
                if (age < 16)
                {
                    Console.WriteLine("Master");
                }
                else if (age >=16)
                {
                    Console.WriteLine("Mr.");
                }
            }
        }
    }
}

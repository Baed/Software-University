using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_chetno_ili_ne4etno
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            
            if (number % 2 == 0)
            {
                Console.WriteLine("even"); // delenie s int 5:2=2 no s % - pokazva ostatuk 
            }

            else 
            {
                Console.WriteLine("odd");
            }


        }
    }
}

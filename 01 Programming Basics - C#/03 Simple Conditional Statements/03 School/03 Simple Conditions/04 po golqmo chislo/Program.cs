using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_po_golqmo_chislo
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());

            if (num1 >= num2)
            {
                //Console.WriteLine("num1" + num1);
                Console.WriteLine($"num1 is : {num1}");
                
            }

            else
            {
                Console.WriteLine($"num2 is : {num2}");
                //Console.WriteLine(num2);
            }



        }
    }
}

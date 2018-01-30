using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_non_training_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine ());
            int num3 = 0; // pri num1 <5 num3 e 0
            if (num1 > 5)
            {
                num3 = int.Parse(Console.ReadLine()); // aKO num1 > 5, togava su6testwuwa vuvejdane na num3  NO BEZ var              
                var num4 = int.Parse(Console.ReadLine());
            }
            
            Console.WriteLine(num4); // ERROR! НЕ Е М/У if {.....}
            

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Numbers_N_to_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
           
            // forr + tab + tab = obraten cikul

            for (int i = n; i >=1 ; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}

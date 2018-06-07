using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Enter_Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    int n = int.Parse(Console.ReadLine());
                    if (n % 2 == 0)
                    {
                        Console.WriteLine("Even number Entered: {0}", n);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("The Number is not Even.");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid number");                 
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Blank_Receipt
{
    class Program
    {
        static void Main(string[] args)
        {
            Recept();
        }
        static void Recept()
        {
            PrintHeader();
            PrintBody();
            PrintFooter();
        }
        static void PrintHeader()
        {
            Console.WriteLine($"CASH RECEIPT" +
                $"\n------------------------------");
        }
        static void PrintBody()
        {
            Console.WriteLine($"Charged to____________________" +
                $"\nReceived by___________________");
        }
        static void PrintFooter()
        {
            Console.WriteLine($"------------------------------" +
                $"\n\u00a9 SoftUni");
        }
    }
}

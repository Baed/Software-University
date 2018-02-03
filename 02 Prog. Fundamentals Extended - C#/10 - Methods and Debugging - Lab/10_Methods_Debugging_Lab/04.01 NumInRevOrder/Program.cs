using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._01_NumInRevOrder
{

    class Program
    {
        static void Main(string[] args)
        {
            string input = Reader();
            char[] result = ExecuteProgram(input);
            Printer(result);
        }

        private static void Printer(char[] result)
        {
            Console.WriteLine(string.Join("", result.Reverse()));
        }

        private static char[] ExecuteProgram(string input)
        {
            char[] arr = new char[input.Length];

            arr = input.ToCharArray();

            return arr;
        }

        private static string Reader()
        {
            return Console.ReadLine();
        }
    }
}

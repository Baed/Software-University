using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Debugging_Tricky_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string delimiter = Console.ReadLine();
            int numberOfStrings = int.Parse(Console.ReadLine());

            var result = string.Empty;

            for (int i = 0; i < numberOfStrings; i++)
            {
                string currentString = Console.ReadLine(); // + delimeter
                result += i < numberOfStrings - 1 ? currentString + delimiter : currentString; // bez tova
            }
            //string removeLastChar = result.Remove(result.Length - delimiter.Length);
            Console.WriteLine(result);
        }
    }
}

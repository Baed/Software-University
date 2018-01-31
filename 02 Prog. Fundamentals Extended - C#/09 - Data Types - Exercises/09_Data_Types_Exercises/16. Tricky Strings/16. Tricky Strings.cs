using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Tricky_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string delimiter = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            var word = "";
            for (int i = 0; i < n; i++)
            {
                string currentText = Console.ReadLine();
                word += i < n - 1 ? currentText + delimiter : currentText;
            }
            Console.Write("{0}", word);
            Console.WriteLine();
        }
    }
}

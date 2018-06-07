using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _01.Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = File.ReadAllLines("output.txt");

            foreach (var item in text)
            {
                Console.WriteLine(item);
            }

        }
    }
}

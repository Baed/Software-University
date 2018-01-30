using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.String_Repeater
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(RepeatString(inputText, n));
        }
        static string RepeatString(string str, int cnt)
        {
            string stringRepeated = "";
            for (int i = 0; i < cnt; i++)
            {
                stringRepeated += str;
            }
            return stringRepeated;
        }
    }
}

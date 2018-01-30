using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            if (type == "int")
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                int metod = GetMax(first, second);
                Console.WriteLine(metod);
            }
            else if (type == "char")
            {
                char first = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());
                char metod = GetMax(first, second);
                Console.WriteLine(metod);
            }
            else if (type == "string")
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();
                string metod = GetMax(first, second);
                Console.WriteLine(metod);
            }
        }
        static int GetMax(int first, int second)
        {
            return Math.Max(first, second);
        }
        static char GetMax(char first, char second)
        {
            return first.CompareTo(second) >= 0 ? first : second;
        }
        static string GetMax(string first, string second)
        {
            return first.CompareTo(second) >= 0 ? first : second;
        }
    }
}

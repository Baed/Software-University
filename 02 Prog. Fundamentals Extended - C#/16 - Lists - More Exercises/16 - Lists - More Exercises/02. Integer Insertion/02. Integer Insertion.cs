using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Integer_Insertion
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> elements = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string input = Console.ReadLine();

            while (input != "end")
            {
                int currentNumber = int.Parse(input);
                int firstDigit = input[0] - '0';
                // 256 --> [0] = 2 input = string ; 0 --> 48; 50 - 48 = 2;

                elements.Insert(firstDigit, currentNumber); // poziciq, element;

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", elements));
        }
    }
}

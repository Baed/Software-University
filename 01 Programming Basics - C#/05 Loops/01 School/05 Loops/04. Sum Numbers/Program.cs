using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 0; i < numbersCount; i++) // v javisimost ot broq numbersCount ---> vuvejdame number
            {
                int number = int.Parse(Console.ReadLine());
                sum += number; // sum = sum + number


            }
            Console.WriteLine(sum);
        }
    }
}

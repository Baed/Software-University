using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._01_ArrayStatistics
{
    class ArrayStatistics
    {
        static void Main(string[] args)
        {
            int[] arrNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine("Min = {0}", arrNumbers.Min());
            Console.WriteLine("Max = {0}", arrNumbers.Max());
            Console.WriteLine("Sum = {0}", arrNumbers.Sum());
            Console.WriteLine("Average = {0}", arrNumbers.Average());
        }
    }
}

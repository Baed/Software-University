using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Square_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<double> spis = Console.ReadLine().Split(' ').Select(double.Parse).OrderByDescending(a => a).ToList();
            // po nizhodqsht red
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> squares = new List<int>();
            foreach (var item in nums)
            {
                if (IsExactSquare(item))
                {
                    squares.Add(item);
                }
            }
            squares.Sort();
            squares.Reverse();
            Console.WriteLine(string.Join(" ", squares));
        }
        static bool IsExactSquare(int num)
        {
            var sqrt = (int)Math.Sqrt(num);
            return (sqrt * sqrt == num);
        }
    }
}

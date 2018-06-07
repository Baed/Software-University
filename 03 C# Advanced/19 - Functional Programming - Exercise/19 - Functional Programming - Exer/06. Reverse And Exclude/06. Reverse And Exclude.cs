using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Reverse_And_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            var numList = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Reverse()
                .ToList();

            int devisor = int.Parse(Console.ReadLine());

            Predicate<int> divisible = num => num % devisor != 0;

            Action<List<int>> printer = num => Console.WriteLine(string.Join(" ", num));

            var result = numList
                .Where(n => divisible(n))
                .ToList();

            printer(result);
        }
    }
}

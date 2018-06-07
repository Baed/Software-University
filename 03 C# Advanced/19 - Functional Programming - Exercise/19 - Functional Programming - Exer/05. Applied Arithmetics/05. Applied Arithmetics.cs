using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            var numList = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            Func<int, int> add = num => num += 1;
            Func<int, int> subtract = num => num -= 1;
            Func<int, int> multiply = num => num * 2;

            Action<List<int>> printer = nums => Console.WriteLine(string.Join(" ", nums));

            var command = Console.ReadLine().ToLower();

            while (command != "end")
            {
                switch (command)
                {
                    case "add": numList = numList.Select(add).ToList(); break;
                    case "subtract": numList = numList.Select(subtract).ToList(); break;
                    case "multiply": numList = numList.Select(multiply).ToList(); break;
                    case "print": printer(numList); break;
                }
                command = Console.ReadLine().ToLower();
            }
        }
    }
}

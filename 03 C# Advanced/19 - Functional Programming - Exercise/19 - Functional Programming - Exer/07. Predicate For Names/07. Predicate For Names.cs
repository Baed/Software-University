using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Predicate_For_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var namesList = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Predicate<string> isValidLenght = name => name.Length <= n;

            namesList = namesList
                .Where(x => isValidLenght(x))
                .ToList();

            Action<List<string>> printer = x => Console.WriteLine(string.Join("\r\n", x));

            printer(namesList); 
        }
    }
}

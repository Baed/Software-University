using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int controlNum = int.Parse(Console.ReadLine());

            var names = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Func<string, int> sumChars = str => str.ToCharArray().Sum(ch => ch);

            Func<string, int, bool> isEqualOrLargerSum = (name, num) => sumChars(name) >= num;

            var result = names.FirstOrDefault(name => isEqualOrLargerSum(name, controlNum));

            Console.WriteLine(result);
        }
    }
}

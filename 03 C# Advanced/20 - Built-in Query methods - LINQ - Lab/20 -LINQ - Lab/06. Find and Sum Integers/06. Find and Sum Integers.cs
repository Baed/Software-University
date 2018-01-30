using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Find_and_Sum_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                        .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(str =>
                        {
                            long number;
                            bool isSuccess = long.TryParse(str, out number);
                            return new { isSuccess, number };
                            // new { , } - new anonymouos object 
                        })
                        .Where(x => x.isSuccess)
                        .Select(x => x.number)
                        .ToList();

            if (numbers.Count != 0)
                Console.WriteLine(numbers.Sum());
            else
                Console.WriteLine("No match");
        }
    }
}

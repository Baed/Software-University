using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.First_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var letters = Console.ReadLine()
                .ToLower()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var searchedName = names
                .OrderBy(w => w)
                .FirstOrDefault(w => letters.Any(l => w.ToLower().StartsWith(l)));

            Console.WriteLine(searchedName != null ? searchedName : "No match");
        }
    }
}

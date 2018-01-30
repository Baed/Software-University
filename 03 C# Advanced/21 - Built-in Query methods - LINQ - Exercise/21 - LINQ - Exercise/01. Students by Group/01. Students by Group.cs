using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Students_by_Group
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var studentList = new List<string[]>();

            while (input != "END")
            {
                var tokens = input
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                studentList.Add(tokens);                    

                input = Console.ReadLine();
            }

            var result = studentList
                .Where(s => s[2] == "2")
                .OrderBy(s => s[0])
                .Select(s => s[0] + " " + s[1]);

            Console.WriteLine(string.Join("\r\n", result));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Append_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> itemsList = Console.ReadLine().Split('|').ToList();
            itemsList.Reverse();
            List<string> result = new List<string>();
            foreach (var item in itemsList)
            {
                List<string> numsList = item.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                result.AddRange(numsList);
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}

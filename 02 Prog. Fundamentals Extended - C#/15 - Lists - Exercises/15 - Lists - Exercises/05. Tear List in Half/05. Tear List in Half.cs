using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Tear_List_in_Half
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> top = new List<int>();
            List<int> botton = new List<int>();
            for (int i = 0; i < input.Count; i++)
            {
                if (i < input.Count/2 )
                {
                    botton.Add(input[i]);
                }
                else
                {
                    top.Add(input[i]);
                }
            }
            List<int> expanded = new List<int>();
            for (int i = 0; i < top.Count; i++)
            {
                expanded.Add(top[i] / 10);
                expanded.Add(botton[i]);
                expanded.Add(top[i] % 10);
            }
            Console.WriteLine(string.Join(" ", expanded));
        }
    }
}

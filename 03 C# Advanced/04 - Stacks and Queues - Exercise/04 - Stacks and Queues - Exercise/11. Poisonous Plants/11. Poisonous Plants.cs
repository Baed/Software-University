using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Poisonous_Plants
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] days = new int[int.Parse(Console.ReadLine())]; // day each plant dies (0 => plant never dies)

            int[] plants = Console.ReadLine()
            .Trim()
            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

            var stack = new Stack<int>(); // plants (indices) to the left of given plant
            stack.Push(0); // first plant pushed to the stack

            for (int i = 0; i < days.Length; i++)
            {
                int maxDay = 0;
                // pop plants bigger than current plant & to the left of it
                while (stack.Count != 0 && plants[stack.Peek()] >= plants[i])
                {
                    maxDay = Math.Max(maxDay, days[stack.Pop()]);
                }
                // empty plants stack => min plant [i] found (smaller than all plants to the left of it)
                // min plants never die => daysToDie = 0
                if (stack.Count != 0)
                {
                    days[i] = maxDay + 1;
                }
                stack.Push(i);
            }
            Console.WriteLine(days.Max());
        }
    }
}

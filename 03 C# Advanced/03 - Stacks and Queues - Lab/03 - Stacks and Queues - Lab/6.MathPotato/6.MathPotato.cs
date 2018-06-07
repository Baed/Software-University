using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.MathPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] children = Console.ReadLine().Split(' ');
            int num = int.Parse(Console.ReadLine());

            var queue = new Queue<string>(children);
            int cycle = 1;

            while (queue.Count > 1)
            {
                for (int i = 1; i < num; i++)
                {
                    string removeChild = queue.Dequeue();
                    queue.Enqueue(removeChild);
                }
                if (PrimeTool.IsPrime(cycle))
                {
                    Console.WriteLine($"Prime {queue.Peek()}");
                }
                else
                {
                    Console.WriteLine($"Removed {queue.Dequeue()}");
                }
                cycle++;
            }
            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
    public static class PrimeTool
    {
        public static bool IsPrime(int cycle)
        {
            if ((cycle & 1) == 0)
            {
                if (cycle == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            for (int i = 3; (i * i) <= cycle; i += 2)
            {
                if ((cycle % i) == 0)
                {
                    return false;
                }
            }
            return cycle != 1;
        }
    }
}

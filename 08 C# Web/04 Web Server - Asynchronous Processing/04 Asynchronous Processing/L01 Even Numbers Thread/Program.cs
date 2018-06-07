using System;
using System.Threading;

namespace L01_Even_Numbers_Thread
{
    class Program
    {
        static void Main(string[] args)
        {
            var start = int.Parse(Console.ReadLine());
            var end = int.Parse(Console.ReadLine());

            var thread = new Thread(() => PrintEvenNumber(start, end));
            thread.Start();
            thread.Join();

            Console.WriteLine("Thread finished work");
        }

        private static void PrintEvenNumber(int min, int max)
        {
            for (int i = min; i <= max; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

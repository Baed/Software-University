using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace L00_Demo4
{
    class Program
    {
        static void Main(string[] args)
        {
            DoWork();
        }

        public static async void DoWork()
        {
            var tasks = new List<Task>();

            var results = new List<bool>();

            for (int i = 0; i < 10; i++)
            {
                tasks.Add(Task.Run(async () =>
                {
                    var result = await SlowMethod();
                    results.Add(result);
                }));
            }

            await Task.WhenAll(tasks.ToArray());

            Console.WriteLine("Finished!");
        }

        private static async Task<bool> SlowMethod()
        {
            Thread.Sleep(1000);

            Console.WriteLine("Result!");

            return true;
        }
    }
}

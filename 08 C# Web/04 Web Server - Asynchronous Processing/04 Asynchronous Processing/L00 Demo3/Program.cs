using System;
using System.Threading;
using System.Threading.Tasks;

namespace L00_Demo3
{
    class Program
    {
        private static string Result;

        static void Main(string[] args)
        {
            Console.WriteLine("Calculating...");

            Task.Run(() => CalculateSlowly());

            Console.WriteLine("Ënter command: ");

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "slow")
                {
                    if (Result == null)
                    {
                        Console.WriteLine("Still calculating.. Please wait!");
                    }
                    else
                    {
                        Console.WriteLine($"Result is: {Result}");
                    }
                }

                if (input == "exit")
                {
                    break; 
                }
            }
        }

        public static void CalculateSlowly()
        {
            Thread.Sleep(10000);
            Result = "42";
        }
    }
}

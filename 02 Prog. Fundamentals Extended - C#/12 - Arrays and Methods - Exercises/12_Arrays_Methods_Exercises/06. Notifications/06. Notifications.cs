using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Notifications
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string positiveOrNegative = Console.ReadLine();
                if (positiveOrNegative == "success")
                {
                    string operation = Console.ReadLine();
                    string message = Console.ReadLine();
                    Console.WriteLine(ShowSuccess(operation, message));
                }
                else if (positiveOrNegative == "error")
                {
                    string operation = Console.ReadLine();
                    int code = int.Parse(Console.ReadLine());
                    Console.WriteLine(ShowError(operation, code));
                }
                else
                {
                    continue;
                }
            }
        }
        static string ShowSuccess(string operation, string message)
        {
            return $"Successfully executed {operation}." +
                $"\n==============================" +
                $"\nMessage: {message}.";
        }
        static string ShowError(string operation, int code)
        {
            if (code > 0)
            {
                return $"Error: Failed to execute {operation}." +
                    $"\n==============================\nError Code: {code}." +
                    $"\nReason: Invalid Client Data.";
            }
            else
            {
                return $"Error: Failed to execute {operation}." +
                    $"\n==============================" +
                    $"\nError Code: {code}." +
                    $"\nReason: Internal System Failure.";
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Theatre_Promotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine().ToLower();
            int age = int.Parse(Console.ReadLine());
            var value = 0;
            if (age > 122 || age < 0)
            {
                Console.WriteLine("Error!");
            }
            else if (age > 64)
            {
                switch (day)
                {
                    case "weekday": Console.WriteLine($"12$"); break; 
                 // case "weekday": value = 12; break;
                    case "weekend": Console.WriteLine($"15$"); break;
                    case "holiday": Console.WriteLine($"10$"); break;
                    default: Console.WriteLine($"Error!"); break;
                }
            }
            else if (age > 18)
            {
                switch (day)
                {
                    case "weekday": Console.WriteLine($"18$"); break;
                    case "weekend": Console.WriteLine($"20$"); break;
                    case "holiday": Console.WriteLine($"12$"); break;
                    default: Console.WriteLine($"Error!"); break;
                }
            }
            else if (age >= 0)
            {
                switch (day)
                {
                    case "weekday": Console.WriteLine($"12$"); break;
                    case "weekend": Console.WriteLine($"15$"); break;
                    case "holiday": Console.WriteLine($"5$"); break;
                    default: Console.WriteLine($"Error!"); break;
                }
            }
        }
    }
}

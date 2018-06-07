using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_SCHOOLJUDGE_Time___15
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            
            int hour = num1 + (num2 + 15) / 60;
            int minute = (num2 + 15) % 60;                   

            if (hour > 23)
            {
                hour = 0;
            }

            if (minute < 10)
            {
                Console.WriteLine("{0}:0{1}", hour, minute);
            }
          
            else
            {
                Console.WriteLine("{0}:{1}", hour, minute);
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Back_in_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            
            if (minutes >= 30)
            {
                hours++;
                //hours += (minutes / 60);
                minutes = (minutes + 30) % 60;
                if (hours >= 24) //hours = hours >= 24 ? 0 : hours;
                {
                    hours = 0;
                }
            }
            else
            {
                minutes = minutes + 30;
            }
            Console.WriteLine($"{hours}:{minutes:00}");
        }
    }
}

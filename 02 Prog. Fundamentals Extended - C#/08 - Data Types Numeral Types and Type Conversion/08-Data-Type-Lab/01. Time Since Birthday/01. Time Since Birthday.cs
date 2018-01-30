using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Time_Since_Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            byte years = byte.Parse(Console.ReadLine());
            int days = years * 365;
            int hours = days * 24;
            int minutes = hours * 60;
            Console.WriteLine("{0} years = {1} days = {2} hours = {3} minutes.", years, days, hours, minutes);

        }
    }
}

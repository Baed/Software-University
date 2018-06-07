using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._01_CenturiesToNonosec
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            int days = (int)(years * 365.2422);
            double hours = days * 24;
            double minutes = hours * 60;
            decimal seconds = (decimal)minutes * 60;
            decimal milisec = seconds * 1000;
            decimal microsec = milisec * 1000;
            decimal nanosec = microsec * 1000;

            Console.WriteLine($"{centuries} centuries = {years} years = {days:f0} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milisec} milliseconds = {microsec} microseconds = {nanosec} nanoseconds");
        }
    }
}

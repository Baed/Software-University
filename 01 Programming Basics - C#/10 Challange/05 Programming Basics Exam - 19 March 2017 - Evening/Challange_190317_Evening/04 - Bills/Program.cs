using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            double month = double.Parse(Console.ReadLine());

            var electricity = 0.0;
            var water = 0.0;
            var internet = 0.0;
            var others = 0.0;

            for (int i = 1; i <= month; i++)
            {
                double bill_el = double.Parse(Console.ReadLine());
                electricity += bill_el;
                water += 20;
                internet += 15;
                others += (bill_el + 35)*1.2;
            }

            Console.WriteLine($"Electricity: {electricity:f2} lv");
            Console.WriteLine($"Water: {water:f2} lv");
            Console.WriteLine($"Internet: {internet:f2} lv");
            Console.WriteLine($"Other: {others:f2} lv");
            Console.WriteLine($"Average: {((electricity + water + internet + others) / month):f2} lv");

        }
    }
}

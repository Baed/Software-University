using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Students_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var builder = new StringBuilder();
            builder.AppendLine($"{"Name",-10}|{"CAdv",7}|{"COOP",7}|{"AdvOOP",7}|{"Average",7}|");

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split(new[] { ' ', '-', ',' }, StringSplitOptions.RemoveEmptyEntries);

                string name = input[0];
                double cAdv = double.Parse(input[1]);
                double cOop = double.Parse(input[2]);
                double advOop = double.Parse(input[3]);

                builder.AppendLine(string.Format($"{name,-10}|{cAdv,7:f2}|{cOop,7:f2}|{advOop,7:f2}|{(cAdv + cOop + advOop) / 3,7:f4}|"));
            }
            Console.WriteLine(builder.ToString());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            

            var data = new Dictionary<string, string>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "stop")
                {
                    break;
                }

                string mail = Console.ReadLine();

                if (mail.EndsWith("us") || mail.EndsWith("uk"))
                {
                    continue;
                }

                if (!data.ContainsKey(input))
                {
                    data.Add(input, mail);
                }

                data[input] = mail;
            }

            Console.WriteLine(string.Join("\r\n", data.Select(kvp => $"{kvp.Key} -> {kvp.Value}")));
        }
    }
}

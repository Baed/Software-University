using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._01_FixEmails
{
    class FixEmails
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> data = new Dictionary<string, string>();

            string inputName;
            while ((inputName = Console.ReadLine()) != "stop")
            {
                string inputMail = Console.ReadLine();

                if (!(inputMail.EndsWith(".us") || inputMail.EndsWith(".uk")))
                {
                    if (!data.ContainsKey(inputName))
                    {
                        data.Add(inputName, "");
                    }

                    data[inputName] = inputMail;
                }
            }

            foreach (var mail in data)
            {
                Console.WriteLine($"{mail.Key} -> {mail.Value}");
            }
        }
    }
}

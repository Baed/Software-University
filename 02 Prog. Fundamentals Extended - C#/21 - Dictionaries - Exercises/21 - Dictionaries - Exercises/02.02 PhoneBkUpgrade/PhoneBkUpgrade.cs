using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._02_PhoneBkUpgrade
{
    class PhoneBkUpgrade
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();

            string[] commands = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            while (commands[0] != "END")
            {
                ExecuteCommand(phonebook, commands);

                commands = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }
        }

        private static void ExecuteCommand(Dictionary<string, string> phonebook, string[] commands)
        {
            switch (commands[0])
            {
                case "A":
                    phonebook[commands[1]] = commands[2];
                    break;
                case "S":
                    if (phonebook.ContainsKey(commands[1]))
                    {
                        Console.WriteLine($"{commands[1]} -> {phonebook[commands[1]]}");
                        break;
                    }
                    Console.WriteLine($"Contact {commands[1]} does not exist.");
                    break;
                case "ListAll":
                    foreach (var name in phonebook.OrderBy(kvp => kvp.Key))
                    {
                        Console.WriteLine($"{name.Key} -> {name.Value}");
                    }
                    break;
            }
        }
    }
}

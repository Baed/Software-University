using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05._01_ParkingValid
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> data = new Dictionary<string, string>();

            int n = int.Parse(Console.ReadLine());
            string pattern = @"([A-Z]{2}[0-9]{4}[A-Z]{2})";

            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];
                string user = tokens[1];
                string licenseNumber = string.Empty;

                switch (command)
                {
                    case "register":
                        licenseNumber = tokens[2];
                        Match match = Regex.Match(tokens[2], pattern);
                        if (match.Success)
                        {
                            licenseNumber = match.Groups[1].Value;

                            if (!data.ContainsKey(user))
                            {
                                Console.WriteLine($"{user} registered {licenseNumber} successfully");
                                data.Add(user, string.Empty);
                            }
                            else if (data.ContainsKey(user))
                            {
                                Console.WriteLine($"ERROR: already registered with plate number {licenseNumber}");
                            }
                            if (data.ContainsValue(licenseNumber))
                            {
                                Console.WriteLine($"ERROR: license plate {licenseNumber} is busy");

                            }    
                            
                            data[user] = licenseNumber;
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: invalid license plate {licenseNumber}");
                        }
                        break;
                    case "unregister":

                        if (data.ContainsKey(user))
                        {
                            Console.WriteLine($"user {user} unregistered successfully");
                            data.Remove(user);
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: user {user} not found");
                        }
                        break;
                }
            }

            foreach (var kvp in data)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._02_User_Logins
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> usersCredentials = new Dictionary<string, string>();

            string[] input = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            int failedloginAtempt = 0;

            while (input[0] != "login")
            {
                string username = input[0];
                string password = input[1];

                usersCredentials[username] = password; //input[1]; key[i] = value[i]; --> gosho = gosho123; pesho = pesho222

                input = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

                if (input[0] != "end")
                {
                    if (!usersCredentials.ContainsKey(username) || usersCredentials[username] != password)
                    {
                        Console.WriteLine($"{username}: login failed");
                        failedloginAtempt++;

                    }
                    else
                    {
                        Console.WriteLine($"{username}: logged in successfully");
                        continue;
                    }

                    input = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                }
            }

            Console.WriteLine($"unsuccessful login attempts: {failedloginAtempt}");
        }
    }
}

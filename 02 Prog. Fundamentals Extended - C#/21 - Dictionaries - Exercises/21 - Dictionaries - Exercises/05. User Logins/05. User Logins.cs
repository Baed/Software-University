using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.User_Logins
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> usersCredentials = new Dictionary<string, string>();

            string[] inputUserandPass = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

            while (inputUserandPass[0] != "login")
            {
                string username = inputUserandPass[0];
                string password = inputUserandPass[1];

                usersCredentials[username] = password; //input[1]; key[i] = value[i]; --> gosho = gosho123; pesho = pesho222
                inputUserandPass = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            }

            inputUserandPass = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            int failedloginAtempt = 0;

            while (inputUserandPass[0] != "end")
            {
                string username = inputUserandPass[0];
                string password = inputUserandPass[1];

                if (!usersCredentials.ContainsKey(username) || usersCredentials[username] != password)
                {
                    Console.WriteLine($"{username}: login failed");
                    failedloginAtempt++;
                }
                else
                {
                    Console.WriteLine($"{username}: logged in successfully");
                }

                inputUserandPass = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

            }

            Console.WriteLine($"unsuccessful login attempts: {failedloginAtempt}");
        }
    }
}

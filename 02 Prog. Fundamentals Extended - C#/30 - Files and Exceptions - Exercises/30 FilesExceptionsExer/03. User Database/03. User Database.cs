using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.User_Database
{
    class Program
    {
        static void Main(string[] args)
        {
            String db = "users.txt";

            Dictionary<string, User> users = new Dictionary<string, User>();

            string[] data = File.ReadAllLines(db);

            foreach (var userdata in data)
            {
                string[] tokens = userdata.Split(' ');

                User user = new User
                {
                    Username = tokens[0],
                    Password = tokens[1],
                    IsLogged = bool.Parse(tokens[2])
                };
                users.Add(user.Username, user);
            }
            while (true)
            {
                string[] tokens = Console.ReadLine().Split(' ');
                string username = String.Empty;
                string password = String.Empty;
                string repeatPass = String.Empty;
                if (tokens[0] == "exit")
                {
                    break;
                }
                switch (tokens[0])
                {
                    case "register":
                        username = tokens[1];
                        password = tokens[2];
                        repeatPass = tokens[3];
                        if (users.ContainsKey(username))
                        {
                            Console.WriteLine("The given username already exists.");
                        }
                        else if (password != repeatPass)
                        {
                            Console.WriteLine("The two passwords must match");
                        }
                        else
                        {
                            User UserToRegister = new User
                            {
                                Username = username,
                                Password = password,
                                IsLogged = false
                            };
                            users.Add(username, UserToRegister);
                        }
                        break;
                    case "login":
                        username = tokens[1];
                        password = tokens[2];
                        if (!users.ContainsKey(username))
                        {
                            Console.WriteLine("There is no user with the given username.");
                        }
                        else if (users[username].IsLogged)
                        {
                            Console.WriteLine("There is already alogged in user.");
                        }
                        else if (users[username].Password != password)
                        {
                            Console.WriteLine("The password you entered is incorrect.");
                        }
                        else
                        {
                            users[username].IsLogged = true;
                        }
                        break;
                    case "logout":
                        username = tokens[1];
                        if (!users.ContainsKey(username))
                        {
                            Console.WriteLine("There is no user with the given username.");
                        }
                        else if (!users[username].IsLogged)
                        {
                            Console.WriteLine($"User {username} is not logged in");
                        }
                        else
                        {
                            users[username].IsLogged = false;
                        }
                        break;
                }
            }
            foreach (KeyValuePair<string, User> item in users)
            {
                File
                    .WriteAllLines(db, users
                    .Values.Select(u => $"{u.Username} {u.Password} {u.IsLogged}")
                    .ToArray());
            }
        }
    }
    class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsLogged { get; set; }
    }
}

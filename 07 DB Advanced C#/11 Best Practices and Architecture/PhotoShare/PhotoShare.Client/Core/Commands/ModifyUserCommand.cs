using System.Linq;
using PhotoShare.Data;

namespace PhotoShare.Client.Core.Commands
{
    using System;

    public static class ModifyUserCommand
    {
        // ModifyUser <username> <property> <new value>
        // For example:
        // ModifyUser <username> Password <NewPassword>
        // ModifyUser <username> BornTown <newBornTownName>
        // ModifyUser <username> CurrentTown <newCurrentTownName>
        // !!! Cannot change username
        public static string Execute(string[] data)
        {
            string userName = data[0];
            string property = data[1].ToLower();
            string newValue = data[2];

            using (var db = new PhotoShareContext())
            {
                var user = db.Users
                    .Where((u => u.Username == userName))
                    .FirstOrDefault();

                if (user == null)
                {
                    throw new InvalidOperationException($"User {userName} not found!");
                }

                switch (property)
                {
                    case "password":
                        if (newValue.Any(c => Char.IsLower(c)) || !newValue.Any(c => Char.IsDigit(c)))
                        {
                            throw new ArgumentException($"Value {newValue} not valid" + Environment.NewLine + "Invalid password!");
                        }
                        user.Password = newValue;
                        break;
                    case "borntown":
                        var bornTown = db.Towns
                            .Where(t => t.Name == newValue)
                            .FirstOrDefault();

                        if (bornTown == null)
                        {
                            throw new ArgumentException($"Value {newValue} not valid" + Environment.NewLine + $"Town {newValue} not found!");
                        }

                        user.BornTown = bornTown;
                        break;

                    case "currenttown":
                        var currentTown = db.Towns
                            .Where(t => t.Name == newValue)
                            .FirstOrDefault();

                        if (currentTown == null)
                        {
                            throw new ArgumentException($"Value {newValue} not valid" + Environment.NewLine + $"Town {newValue} not found!");
                        }

                        user.CurrentTown = currentTown;
                        break;
                    default: throw new ArgumentException($"Property {property} not supported!");
                }

                db.SaveChanges();

                return $"User {user} {property} is {newValue}";
            }
        }
    }
}

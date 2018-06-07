using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Launcher.cs.GameStore.Data;
using Launcher.cs.GameStore.Data.Models;
using Launcher.cs.GameStore.Services.Contracts;

namespace Launcher.cs.GameStore.Services
{
    public class UserService : IUserService
    {
        public bool Create(string email, string name, string password)
        {
            using (var db = new GameStoreDbContext())
            {
                if (db.Users.Any(u => u.Email == email))
                {
                    return false;
                }

                var isAdmin = !db.Users.Any();

                var user = new User
                {
                    Email = email,
                    Name = name,
                    Password = password,
                    IsAdmin = isAdmin
                };

                db.Add(user);
                db.SaveChanges();
            }

            return true;
        }

        public bool Find(string email, string password)
        {
            using (var db = new GameStoreDbContext())
            {
                return db.Users.Any(u => u.Email == email && u.Password == password);
            }
        }

        public bool IsAdmin(string email)
        {
            using (var db = new GameStoreDbContext())
            {
                return db.Users.Any(u => u.Email == email && u.IsAdmin);
            }
        }
    }
}
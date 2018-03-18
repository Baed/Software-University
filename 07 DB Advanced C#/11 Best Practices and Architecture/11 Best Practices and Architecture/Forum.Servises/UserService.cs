using System;
using System.Linq;
using Forum.Data;
using Forum.Models;
using Forum.Servises.Contracts;

namespace Forum.Servises
{
    public class UserService : IUserService
    {
        private readonly ForumDbContex _context;

        public UserService(ForumDbContex context)
        {
            _context = context;
        }

        public User ById(int id)
        {
            var user = _context.Users.Find(id);

            return user;
        }

        public User ByUsername(string username)
        {
            var user = _context.Users
                .SingleOrDefault(u => u.Username == username);
            
            return user;
        }

        public User ByUsernameAndPassword(string username, string password)
        {
            var user = _context.Users
                .SingleOrDefault(u => u.Username == username && u.Password == password);

            return user;
        }

        public User Create(string username, string password)
        {
            var user = new User(username, password);

            _context.Users.Add(user);

            _context.SaveChanges();

            return user;
        }

        public void Delete(int id)
        {
            var user = _context.Users.Find(id);

            _context.Users.Remove(user);

            _context.SaveChanges();
        }
    }
}

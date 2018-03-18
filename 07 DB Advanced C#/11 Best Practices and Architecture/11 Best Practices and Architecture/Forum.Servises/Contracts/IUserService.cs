using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forum.Models;

namespace Forum.Servises.Contracts
{
    public interface IUserService
    {
        User ById(int id);

        User ByUsername(string username);

        User ByUsernameAndPassword(string username, string password);

        User Create(string username, string password);

        void Delete(int id);
    }
}

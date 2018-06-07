using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Launcher.cs.GameStore.Services.Contracts
{
    public interface IUserService
    {
        bool Create(string email, string name, string password);

        bool Find(string email, string password);

        bool IsAdmin(string email);
    }
}
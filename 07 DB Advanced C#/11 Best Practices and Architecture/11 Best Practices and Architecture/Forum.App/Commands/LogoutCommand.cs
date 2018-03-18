using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forum.App.Commands.Contracts;

namespace Forum.App.Commands
{
    public class LogoutCommand : ICommand
    {
        public string Execude(params string[] arguments)
        {
            if (Session.User == null)
            {
                return "You are not logged in";
            }

            Session.User = null;

            return $"Logged out successfully!";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forum.App.Commands.Contracts;
using Forum.Servises.Contracts;

namespace Forum.App.Commands
{
    public class LoginCommand : ICommand
    {
        private readonly IUserService _userService;

        public LoginCommand(IUserService userService)
        {
            this._userService = userService;
        }

        public string Execude(params string[] arguments)
        {
            var username = arguments[0];
            var password = arguments[1];

            var user = _userService.ByUsernameAndPassword(username, password);

            if (user == null)
            {
                return "Invalid username or password!";
            }

            Session.User = user;

            return $"Logged in successfully!";
        }
    }
}

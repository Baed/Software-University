using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forum.App.Commands.Contracts;
using Forum.Servises.Contracts;

namespace Forum.App.Commands
{
    public class RegisterCommand : ICommand
    {
        private readonly IUserService _userService;

        public RegisterCommand(IUserService userService)
        {
            this._userService = userService;
        }

        public string Execude(params string[] arguments)
        {
            var username = arguments[0];

            var password = arguments[1];

            var existingUser = _userService.ByUsername(username);

            if (existingUser != null)
            {
                return "There is already an existing user with that username!";
            }


            _userService.Create(username, password);

            return $"User created successfully!";
        }
    }
}

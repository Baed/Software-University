using System.Linq;
using PhotoShare.Client.Core.Commands;

namespace PhotoShare.Client.Core
{
    using System;

    public class CommandDispatcher
    {
        public string DispatchCommand(string[] commandParameters)
        {
            string result = null;

            string command = commandParameters[0].ToLower();
            switch (command)
            {
                case "registeruser":
                    result = RegisterUserCommand.Execute(commandParameters.Skip(1).ToArray());
                    break;
                case "addtown":
                    result = AddTownCommand.Execute(commandParameters.Skip(1).ToArray());
                    break;
                case "modifyuser":
                    result = ModifyUserCommand.Execute(commandParameters.Skip(1).ToArray());
                    break;
                case "deleteuser":
                    result = DeleteUser.Execute(commandParameters.Skip(1).ToArray());
                    break;
                case "addtag": result = AddTagCommand.Execute(commandParameters.Skip(1).ToArray());
                    break;
                case "addfriend":
                    result = AddFriendCommand.Execute(commandParameters.Skip(1).ToArray());
                    break;
                case "exit":
                    ExitCommand.Execute();
                    break;
                default: throw new InvalidOperationException($"Command {command} not valid!");
            }

            return result;
        }
    }
}

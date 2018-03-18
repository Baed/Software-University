using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forum.App.Commands.Contracts;
using Forum.Servises.Contracts;

namespace Forum.App.Commands
{
    public class ReplyCommand : ICommand
    {
        private readonly IReplyService _replyService;

        public ReplyCommand(IReplyService replyService)
        {
            _replyService = replyService;
        }

        public string Execude(params string[] arguments)
        {
            var postId = int.Parse(arguments[0]);

            var content = arguments[1];

            if (Session.User == null)
            {
                return "You are not logged in!";
            }

            var authorId = Session.User.Id;
            _replyService.Create(content, postId, authorId);

            return "Reply created seccessfully!";
        }
    }
}

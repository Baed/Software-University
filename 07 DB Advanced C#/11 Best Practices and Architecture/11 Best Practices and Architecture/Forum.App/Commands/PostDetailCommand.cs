using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forum.App.Commands.Contracts;
using Forum.Servises.Contracts;

namespace Forum.App.Commands
{
    public class PostDetailCommand : ICommand
    {
        private readonly IPostService _postService;

        public PostDetailCommand(IPostService postService)
        {
            _postService = postService;
        }

        public string Execude(params string[] arguments)
        {
            var postId = int.Parse(arguments[0]);

            var post = _postService.ById(postId);

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{post.Title} by {post.Author.Username}");

            foreach (var reply in post.Replies)
            {
                sb.AppendLine($"    -{reply.Content} by {reply.Author.Username}");

            }

            return sb.ToString().Trim();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forum.App.Commands.Contracts;
using Forum.Servises.Contracts;

namespace Forum.App.Commands
{
    public class ListPostCommand : ICommand
    {
        private readonly IPostService _postService;

        public ListPostCommand(IPostService postService)
        {
            _postService = postService;
        }

        public string Execude(params string[] arguments)
        {
            StringBuilder sb = new StringBuilder();

            var posts = _postService.All().GroupBy(p => p.Category);

            foreach (var group in posts)
            {
                var categoryName = group.Key.Name;

                sb.AppendLine(categoryName + ":");

                foreach (var post in group)
                {
                    sb.AppendLine($"## {post.Id}. <{post.Title}> - ({post.Content}), by {post.Author.Username} author");
                }
            }

            return sb.ToString().Trim();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forum.App.Commands.Contracts;
using Forum.Models;
using Forum.Servises.Contracts;

namespace Forum.App.Commands
{
    public class CreatePostCommand : ICommand
    {
        private readonly IPostService _postService;
        private readonly ICategoryService _categoryService;

        public CreatePostCommand(IPostService postService, ICategoryService categoryService)
        {
            _postService = postService;
            _categoryService = categoryService;

        }

        public string Execude(params string[] arguments)
        {
            var categoryName = arguments[0];
            var postTitle = arguments[1];
            var postContent = arguments[2];

            if (Session.User == null)
            {
                return "You are not logged in!";
            }

            var category = _categoryService.ByName(categoryName);

            if (category == null)
            {
                category = _categoryService.Create(categoryName);
            }

            var authorId = Session.User.Id;

            var categoryId = category.Id;

            var post = _postService.CreatePost(postTitle, postContent, categoryId, authorId);

            return $"Post with ID {post.Id} created successfully!";
        }
    }
}

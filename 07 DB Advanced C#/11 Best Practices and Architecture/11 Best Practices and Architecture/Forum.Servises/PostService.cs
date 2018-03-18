using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forum.Data;
using Forum.Models;
using Forum.Servises.Contracts;
using Microsoft.EntityFrameworkCore;

namespace Forum.Servises
{
    public class PostService : IPostService
    {
        private readonly ForumDbContex _context;

        public PostService(ForumDbContex context)
        {
            _context = context;
        }

        public Post ById(int postId)
        {
            var post = _context.Posts
                .Include(p => p.Replies)
                .ThenInclude(r => r.Author)
                .SingleOrDefault(p => p.Id == postId);

            return post;
        }

        public Post CreatePost(string title, string content, int categoryId, int authorId)
        {
            Post post = new Post
            {
                Title = title,
                Content = content,
                CategoryId = categoryId,
                AuthorID = authorId
            };

            _context.Posts.Add(post);

            _context.SaveChanges();

            return post;
        }

        public IEnumerable<Post> All()
        {
            var posts = _context.Posts
                .Include(p => p.Author)
                .Include(p => p.Category)
                .ToArray();

            return posts;
        }
    }
}

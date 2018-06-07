using AutoMapper.QueryableExtensions;
using LearningSystem.Data;
using LearningSystem.Data.Models;
using LearningSystem.Service.Blog.Contracts;
using LearningSystem.Service.Blog.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningSystem.Service.Blog.Implementation
{
    public class BlogArticleService : IBlogArticleService
    {
        private readonly LearningSystemDbContext db;

        public BlogArticleService(LearningSystemDbContext db)
        {
            this.db = db;
        }

        public async Task<IEnumerable<BlogArticleListingServiceModel>> AllAsync(int page = 1)
        {
            var articles = await this.db
                   .Articles
                   .OrderByDescending(a => a.PublishDate)
                   .Skip((page - 1) * 25)
                   .Take(25)
                   .ProjectTo<BlogArticleListingServiceModel>()
                   .ToListAsync();

            return articles;
        }

        public async Task ServiceCreateAsync(string title, string content, string authorId)
        {
            var article = new Article
            {
                Title = title,
                Content = content,
                PublishDate = DateTime.UtcNow,
                AuthorId = authorId
            };

            this.db.Articles.Add(article);

            await this.db.SaveChangesAsync();
        }

        public async Task<int> TotalAsync() => await this.db.Articles.CountAsync();

        public async Task<BlogArticleDetailsServiceModel> GetById(int id)
        {
            var articleDetails = await this.db
                .Articles
                .Where(a => a.Id == id)
                .ProjectTo<BlogArticleDetailsServiceModel>()
                .FirstOrDefaultAsync();

            return articleDetails;
        }
    }
}

using LearningSystem.Service.Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningSystem.Service.Blog.Contracts
{
    public interface IBlogArticleService
    {
        Task<IEnumerable<BlogArticleListingServiceModel>> AllAsync(int page = 1);

        Task<int> TotalAsync();

        Task ServiceCreateAsync(string title, string content, string authorId);

        Task<BlogArticleDetailsServiceModel> GetById(int id);
    }
}

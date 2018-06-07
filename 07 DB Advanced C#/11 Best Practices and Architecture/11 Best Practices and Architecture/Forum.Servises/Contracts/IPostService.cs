using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forum.Models;

namespace Forum.Servises.Contracts
{
    public interface IPostService
    {
        Post ById(int postId);

        Post CreatePost(string title, string content, int categoryId, int authorId);

        IEnumerable<Post> All();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Models
{
    public class Post
    {
        public Post()
        {
            
        }

        public Post(string title, string content, int categoryId, int authorId)
        {
            Title = title;
            Content = content;
            CategoryId = categoryId;
            AuthorID = authorId;
        }

        public Post(string title, string content, Category category, User author)
        {
            Title = title;
            Content = content;
            Category = category;
            Author = author;
        }

        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public int AuthorID { get; set; }

        public User Author { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public ICollection<Reply> Replies { get; set; }

        public ICollection<PostTag> PostTags { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Models
{
    public class Reply
    {
        public Reply()
        {
            
        }

        public Reply(string content, Post post, User author)
        {
            Content = content;
            Post = post;
            Author = author;
        }

        public int Id { get; set; }

        public string Content { get; set; }

        public int PostId { get; set; }

        public Post Post { get; set; }

        public int AuthorID { get; set; }

        public User Author { get; set; }
    }
}

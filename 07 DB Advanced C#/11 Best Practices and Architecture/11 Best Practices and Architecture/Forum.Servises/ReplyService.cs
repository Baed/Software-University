using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forum.Data;
using Forum.Models;
using Forum.Servises.Contracts;

namespace Forum.Servises
{
    public class ReplyService : IReplyService
    {
        private readonly ForumDbContex _context;

        public ReplyService(ForumDbContex context)
        {
            _context = context;
        }


        public Reply Create(string replyText, int postId, int authorId)
        {
            var reply = new Reply
            {
                Content = replyText,
                PostId = postId,
                AuthorID = authorId
            };

            _context.Replies.Add(reply);

            _context.SaveChanges();

            return reply;
        }

        public void Delete(int replyId)
        {
            throw new NotImplementedException();
        }
    }
}

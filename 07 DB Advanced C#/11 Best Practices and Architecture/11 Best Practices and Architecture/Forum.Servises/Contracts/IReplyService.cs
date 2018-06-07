using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forum.Models;

namespace Forum.Servises.Contracts
{
    public interface IReplyService
    {
        Reply Create(string replyText, int postId, int authorId);

        void Delete(int replyId);
    }
}

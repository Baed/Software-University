using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forum.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Forum.Data.Config
{
    public class PostConfig : IEntityTypeConfiguration<Post>    
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasMany(p => p.Replies) //Icollection<Reply> Post.Replies
                .WithOne(r => r.Post)
                .HasForeignKey(r => r.PostId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

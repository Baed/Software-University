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
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasMany(u => u.Posts) //Icollection<Post> User.Posts
                .WithOne(p => p.Author)
                .HasForeignKey(r => r.AuthorID);

            builder.HasMany(u => u.Replies) //Icollection<Reply> User.Replies
                .WithOne(p => p.Author)
                .HasForeignKey(r => r.AuthorID);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using IdentityDemo.Web.Models;

namespace IdentityDemo.Web.Data
{
    public class DemoIdentityDbContext : IdentityDbContext<User>
    {
        public DemoIdentityDbContext(DbContextOptions<DemoIdentityDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}

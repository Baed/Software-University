using AutoMapper.QueryableExtensions;
using LearningSystem.Data;
using LearningSystem.Service.Admin.Models;
using LearningSystem.Service.Contracts.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningSystem.Service.Admin.Implementation
{
    public class AdminUserService : IAdminUserService
    {
        private readonly LearningSystemDbContext db;

        public AdminUserService(LearningSystemDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<AdminUserListingServiceModel> All()
        {
            var adminUsers = this.db
                .Users
                .ProjectTo<AdminUserListingServiceModel>()
                .ToList();

            return adminUsers;
        }
    }
}

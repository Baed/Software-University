using LearningSystem.Service.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningSystem.Service.Contracts.Admin
{
    public interface IAdminUserService
    {
        IEnumerable<AdminUserListingServiceModel> All();
    }
}

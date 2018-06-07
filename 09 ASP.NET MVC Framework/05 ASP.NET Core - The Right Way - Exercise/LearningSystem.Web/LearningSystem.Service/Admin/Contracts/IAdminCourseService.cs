using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningSystem.Service.Admin.Contracts
{
    public interface IAdminCourseService
    {
        Task Create(string name, string description, DateTime startDate, DateTime endDate, string trainerId);
    }
}

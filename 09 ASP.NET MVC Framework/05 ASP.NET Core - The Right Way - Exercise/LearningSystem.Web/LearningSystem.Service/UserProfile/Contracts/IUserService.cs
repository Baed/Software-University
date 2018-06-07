using LearningSystem.Service.UserProfile.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningSystem.Service.UserProfile.Contracts
{
    public interface IUserService
    {
        Task<UserProfileServiceModel> GetProfileAsync(string id);

        Task<IEnumerable<UserListingServiceModel>> FindAsync(string searchText);

        Task<byte[]> GetPdfCertificateAsync(string studentId, int courseId);
    }
}

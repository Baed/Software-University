using LearningSystem.Service.Courses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningSystem.Service.Courses.Contracts
{
    public interface ICourseService
    {
        Task<IEnumerable<CourseListingServiceModel>> GetActiveAsync();

        Task<TModel> ByIdAsync<TModel>(int id) where TModel : class;

        Task<bool> StudentIsEnrolledCourseAsync(string studentId, int courseId);

        Task<bool> SignUpStudentAsync(string studentId, int courseId);

        Task<bool> SignOutStudentAsync(string studentId, int courseId);

        Task<IEnumerable<CourseListingServiceModel>> FindAsync(string searchText);

        Task<bool> SaveExamSubmission(int courseId, string studentId, byte[] examSubmission);
    }
}

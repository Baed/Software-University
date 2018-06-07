using LearningSystem.Data.Models;
using LearningSystem.Service.Courses.Models;
using LearningSystem.Service.Trainers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningSystem.Service.Trainers.Contracts
{
    public interface ITrainerService
    {
        Task<IEnumerable<CourseListingServiceModel>> GetCoursesAsync(string trainerId);

        Task<IEnumerable<StudentsInCourseServiceModel>> GetStudentsInCourseAsync(int courseId);

        Task<bool> IsTrainerAsync(int courseId, string trainerId);

        Task<bool> AddGradeAsync(string studentId, int courseId, Grade grade);

        Task<byte[]> GetExamSubmissionAsync(string studentId, int courseId);

        Task<StudentInCourseNamesServiceModel> StudentInCourseNamesAsync(int courseId, string studentId);
    }
}

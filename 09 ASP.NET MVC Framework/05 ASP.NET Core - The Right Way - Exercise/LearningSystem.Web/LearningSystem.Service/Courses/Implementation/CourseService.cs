using AutoMapper.QueryableExtensions;
using LearningSystem.Data;
using LearningSystem.Data.Models;
using LearningSystem.Service.Courses.Contracts;
using LearningSystem.Service.Courses.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningSystem.Service.Courses.Implementation
{
    public class CourseService : ICourseService
    {
        private readonly LearningSystemDbContext db;

        public CourseService(LearningSystemDbContext db)
        {
            this.db = db;
        }

        public async Task<TModel> ByIdAsync<TModel>(int id) where TModel : class
        {
            var courseById = await this.db
                .Courses
                .Where(c => c.Id == id)
                .ProjectTo<TModel>()
                .FirstOrDefaultAsync();

            return courseById;
        }

        // will inject into HomeController
        public async Task<IEnumerable<CourseListingServiceModel>> GetActiveAsync()
        {
            var activeCourses = await this.db
                .Courses
                .OrderByDescending(c => c.Id)
                .Where(c => c.StartDate >= DateTime.UtcNow)
                .ProjectTo<CourseListingServiceModel>()
                .ToListAsync();

            return activeCourses;
        }

        public async Task<bool> StudentIsEnrolledCourseAsync(string studentId, int courseId)
        {
            var signedUser = await this.db
                  .Courses
                  .AnyAsync(c => c.Students.Any(s => s.StudentId == studentId) && c.Id == courseId);

            return signedUser;
        }

        public async Task<bool> SignUpStudentAsync(string studentId, int courseId)
        {
            var courseInfo = await this.GetCourseInfoAsync(studentId, courseId);

            if (courseInfo == null
                || courseInfo.StartDate < DateTime.UtcNow
                || courseInfo.UserIsEnrolledInCourse)
            {
                return false;
            }

            var studentInCourse = new StudentCourse
            {
                StudentId = studentId,
                CourseId = courseId
            };

            this.db.Add(studentInCourse);

            await this.db.SaveChangesAsync();

            return true;
        }

        public async Task<bool> SignOutStudentAsync(string studentId, int courseId)
        {
            var courseInfo = await this.GetCourseInfoAsync(studentId, courseId);

            if (courseInfo == null
                || courseInfo.StartDate < DateTime.UtcNow
                || !courseInfo.UserIsEnrolledInCourse)
            {
                return false;
            }

            // var studentInCourse = await this.db
            //     .Courses
            //     .Where(c => c.Id == courseId)
            //     .SelectMany(c => c.Students)
            //     .FirstOrDefaultAsync(s => s.StudentId == studentId);    

            var studentInCourse = await this.db
                 .FindAsync<StudentCourse>(studentId, courseId);

            this.db.Remove(studentInCourse);

            await this.db.SaveChangesAsync();

            return true;
        }

        private async Task<CourseWithStudentInfo> GetCourseInfoAsync(string studentId, int courseId)
        {
            var courseInfo = await this.db
                  .Courses
                  .Where(c => c.Id == courseId)
                  .Select(c => new CourseWithStudentInfo
                  {
                      StartDate = c.StartDate,
                      UserIsEnrolledInCourse = c.Students.Any(s => s.StudentId == studentId)
                  })
                  .FirstOrDefaultAsync();

            return courseInfo;
        }

        public async Task<IEnumerable<CourseListingServiceModel>> FindAsync(string searchText)
        {
            searchText = searchText ?? string.Empty;

            var activeCourses = await this.db
                 .Courses
                 .OrderByDescending(c => c.Id)
                 .Where(c => c.Name.ToLower().Contains(searchText.ToLower()))
                 .ProjectTo<CourseListingServiceModel>()
                 .ToListAsync();

            return activeCourses;
        }

        public async Task<bool> SaveExamSubmission(int courseId, string studentId, byte[] examSubmission)
        {
            var studentInCourse = await this.db
                .FindAsync<StudentCourse>(studentId, courseId);

            if (studentInCourse == null)
            {
                return false;
            }

            studentInCourse.ExamSubmission = examSubmission;

            await this.db.SaveChangesAsync();

            return true;
        }
    }
}

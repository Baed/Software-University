using AutoMapper.QueryableExtensions;
using LearningSystem.Data;
using LearningSystem.Data.Models;
using LearningSystem.Service.Courses.Models;
using LearningSystem.Service.Trainers.Contracts;
using LearningSystem.Service.Trainers.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningSystem.Service.Trainers.Implementation
{
    public class TrainerService : ITrainerService
    {
        private readonly LearningSystemDbContext db;

        public TrainerService(LearningSystemDbContext db)
        {
            this.db = db;
        }


        public async Task<IEnumerable<CourseListingServiceModel>> GetCoursesAsync(string trainerId)
        {
            var courses = await this.db
                .Courses
                .Where(c => c.TrainerId == trainerId)
                .ProjectTo<CourseListingServiceModel>()
                .ToListAsync();

            return courses;
        }

        public async Task<IEnumerable<StudentsInCourseServiceModel>> GetStudentsInCourseAsync(int courseId)
        {
            var students = await this.db
                .Courses
                .Where(c => c.Id == courseId)
                .SelectMany(c => c.Students.Select(s => s.Student))
                .ProjectTo<StudentsInCourseServiceModel>(new { courseId })
                .ToListAsync();

            return students;
        }

        public async Task<bool> IsTrainerAsync(int courseId, string trainerId)
        {
            var isTrainer = await this.db
                .Courses
                .AnyAsync(c => c.Id == courseId && c.TrainerId == trainerId);

            return isTrainer;
        }

        public async Task<bool> AddGradeAsync(string studentId, int courseId, Grade grade)
        {
            var studentIncourse = await this.db
                .FindAsync<StudentCourse>(studentId, courseId);

            if (studentIncourse == null)
            {
                return false;
            }

            studentIncourse.Grade = grade;

            await this.db.SaveChangesAsync();

            return true;
        }

        public async Task<byte[]> GetExamSubmissionAsync(string studentId, int courseId)
        {
            var studentIncourse = await this.db
                     .FindAsync<StudentCourse>(studentId, courseId);

            return studentIncourse?.ExamSubmission;
        }

        public async Task<StudentInCourseNamesServiceModel> StudentInCourseNamesAsync(int courseId, string studentId)
        {
            var username = await this.db
                     .Users
                     .Where(u => u.Id == studentId)
                     .Select(sc => sc.UserName)
                     .FirstOrDefaultAsync();

            if (username == null)
            {
                return null;
            }

            var coursename = await this.db
                     .Courses
                     .Where(c => c.Id == courseId)
                     .Select(c => c.Name)
                     .FirstOrDefaultAsync();


            if (username == null)
            {
                return null;
            }

            var model = new StudentInCourseNamesServiceModel
            {
                UserName = username,
                CourseName = coursename
            };

            return model;
        }
    }
}

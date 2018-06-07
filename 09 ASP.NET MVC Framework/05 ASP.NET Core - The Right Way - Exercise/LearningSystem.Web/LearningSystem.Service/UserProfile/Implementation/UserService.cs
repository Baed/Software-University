using AutoMapper.QueryableExtensions;
using iTextSharp.text;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;
using LearningSystem.Constants;
using LearningSystem.Data;
using LearningSystem.Data.Models;
using LearningSystem.Service.PdfGenerator.Contracts;
using LearningSystem.Service.UserProfile.Contracts;
using LearningSystem.Service.UserProfile.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningSystem.Service.UserProfile.Implementation
{
    public class UserService : IUserService
    {
        private readonly LearningSystemDbContext db;
        private readonly IPdfGeneratorService pdfService;

        public UserService(LearningSystemDbContext db, IPdfGeneratorService pdfService)
        {
            this.db = db;
            this.pdfService = pdfService;
        }

        public async Task<UserProfileServiceModel> GetProfileAsync(string id)
        {
            var profile = await this.db
                .Users
                .Where(u => u.Id == id)
                .ProjectTo<UserProfileServiceModel>(new { studentId = id})
                .FirstOrDefaultAsync();

            return profile;
        }

        public async Task<IEnumerable<UserListingServiceModel>> FindAsync(string searchText)
        {
            searchText = searchText ?? string.Empty;

            var user = await this.db
                .Users
                .OrderBy(u => u.UserName)
                .Where(u => u.Name.ToLower().Contains(searchText.ToLower()))
                .ProjectTo<UserListingServiceModel>()
                .ToListAsync();

            return user;
        }

        public async Task<byte[]> GetPdfCertificateAsync(string studentId, int courseId)
        {
            var studentInCourse = await this.db
                .FindAsync<StudentCourse>(studentId, courseId);

            if (studentInCourse == null)
            {
                return null;
            }

            var certificateData = await this.db
                .Courses
                .Where(c => c.Id == courseId)
                .Select(c => new
                {
                    CourseName = c.Name,
                    CourseStartDate = c.StartDate,
                    CourseEndDate = c.EndDate,
                    StudentName = c.Students
                                   .Where(s => s.StudentId == studentId)
                                   .Select(s => s.Student.Name)
                                   .FirstOrDefault(),
                    StudentGrade = c.Students
                                   .Where(s => s.StudentId == studentId)
                                   .Select(s => s.Grade)
                                   .FirstOrDefault(),
                    Trainer = c.Trainer.Name

                })
                .FirstOrDefaultAsync();

            var generator = this.pdfService
                             .GeneratePdfFromHtml(string.Format(
                                       PdfFormatConstants.PDF_CERTIFICATE_FORMAT, 
                                       certificateData.CourseName,
                                       certificateData.CourseStartDate.ToShortDateString(),
                                       certificateData.CourseEndDate.ToShortDateString(),
                                       certificateData.StudentName,
                                       certificateData.StudentGrade,
                                       certificateData.Trainer,
                                       DateTime.UtcNow.ToShortDateString()));

            return generator;
        }
    }
}

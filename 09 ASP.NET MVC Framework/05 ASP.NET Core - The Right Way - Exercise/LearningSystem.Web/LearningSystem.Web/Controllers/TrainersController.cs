using LearningSystem.Constants;
using LearningSystem.Data.Models;
using LearningSystem.Service.Courses.Contracts;
using LearningSystem.Service.Courses.Models;
using LearningSystem.Service.Trainers.Contracts;
using LearningSystem.Web.Models.Trainers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningSystem.Web.Controllers
{
    [Authorize(Roles = IdentitiesConstants.TRAINER_ROLE)]
    public class TrainersController : Controller
    {
        readonly ITrainerService trainerService;
        readonly ICourseService coursesService;
        readonly UserManager<User> userManager;

        public TrainersController(ITrainerService trainerService, ICourseService coursesService, UserManager<User> userManager)
        {
            this.trainerService = trainerService;
            this.coursesService = coursesService;
            this.userManager = userManager;
        }

        public async Task<IActionResult> Courses()
        {
            var userId = this.userManager.GetUserId(User);

            var coursesModel = await this.trainerService.GetCoursesAsync(userId);

            return View(coursesModel);
        }

        public async Task<IActionResult> Students(int id)
        {
            var userId = this.userManager.GetUserId(User);

            if (!await this.trainerService.IsTrainerAsync(id, userId))
            {
                return BadRequest();
            }

            var students = await this.trainerService.GetStudentsInCourseAsync(id);

            var model = new StudentsInCourseViewModel
            {
                Students = students,
                Course = await this.coursesService.ByIdAsync<CourseListingServiceModel>(id)
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> GradeStudent(int id, string studentId, Grade grade)
        {
            if (String.IsNullOrEmpty(studentId))
            {
                return BadRequest();
            }
            var userId = this.userManager.GetUserId(User);

            if (!await this.trainerService.IsTrainerAsync(id, userId))
            {
                return BadRequest();
            }

            var success = await this.trainerService.AddGradeAsync(studentId, id, grade);

            if (!success)
            {
                return BadRequest();
            }

            return RedirectToAction(nameof(Students), new { id });
        }

        public async Task<IActionResult> DownLoadExam(int courseId, string studentId)
        {
            if (String.IsNullOrEmpty(studentId))
            {
                return BadRequest();
            }

            var userId = this.userManager.GetUserId(User);

            if (!await this.trainerService.IsTrainerAsync(courseId, userId))
            {
                return BadRequest();
            }

            var examContent = await this.trainerService.GetExamSubmissionAsync(studentId, courseId);

            if (examContent == null)
            {
                return BadRequest();
            }

            var studentInCourseNames = await this.trainerService
                .StudentInCourseNamesAsync(courseId, studentId);

            if (studentInCourseNames == null)
            {
                return BadRequest();
            }

            return File(examContent, "application/zip", $"{studentInCourseNames.CourseName}-{studentInCourseNames.UserName}-{DateTime.UtcNow.ToString("MM-DD-yyyy")}.zip");
        }
    }
}

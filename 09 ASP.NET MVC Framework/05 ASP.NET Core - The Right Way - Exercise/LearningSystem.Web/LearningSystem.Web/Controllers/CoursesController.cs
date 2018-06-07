using LearningSystem.Constants;
using LearningSystem.Data.Models;
using LearningSystem.Service.Courses.Contracts;
using LearningSystem.Service.Courses.Models;
using LearningSystem.Web.Infrastructure.Extensions;
using LearningSystem.Web.Infrastructure.FileForm;
using LearningSystem.Web.Models.Courses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningSystem.Web.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ICourseService courseService;
        private readonly UserManager<User> userManager;


        public CoursesController(ICourseService courseService, UserManager<User> userManager)
        {
            this.courseService = courseService;
            this.userManager = userManager;
        }

        public async Task<IActionResult> Details(int id)
        {
            var model = new CourseDetailViewModel
            {
                Course = await this.courseService.ByIdAsync<CourseDetailsServiceModel>(id)
            };

            if (model.Course == null)
            {
                return NotFound();
            }

            if (User.Identity.IsAuthenticated)
            {
                var userId = this.userManager.GetUserId(User);

                model.UserIsEnrolledCourse = await this.courseService
                    .StudentIsEnrolledCourseAsync(userId, id);
            }

            return View(model);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> SignUp(int id)
        {
            var userId = this.userManager.GetUserId(User);

            var success = await this.courseService
                .SignUpStudentAsync(userId, id);

            if (!success)
            {
                return BadRequest();
            }

            TempData.AddSuccessMessage("Thank you for your registration!");

            return RedirectToAction(nameof(Details), new { id });
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> SignOut(int id)
        {
            var userId = this.userManager.GetUserId(User);

            var success = await this.courseService.SignOutStudentAsync(userId, id);

            if (!success)
            {
                return BadRequest();
            }

            TempData.AddSuccessMessage("Sorry to see you live!");


            return RedirectToAction(nameof(Details), new { id });
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> SubmitExam(int id, IFormFile exam)
        {
            if (!exam.FileName.EndsWith("zip")
                || exam.Length > DataConstants.COURSE_EXAM_SUBMISSION_FILE_LENGTH)
            {
                TempData.AddErrorMessage("Your file should be a '.zip' file with no more 2 MB size!");

                return RedirectToAction(nameof(Details), new { id });
            }

            var fileContents = await exam.ToByteArrayAsync();

            var userId = this.userManager.GetUserId(User);

            var success = await this.courseService.SaveExamSubmission(id, userId, fileContents);

            if (!success)
            {
                return BadRequest();
            }

            TempData.AddSuccessMessage("Exam saved successfully!");

            return RedirectToAction(nameof(Details), new { id });
        }
    }
}

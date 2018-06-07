using LearningSystem.Constants;
using LearningSystem.Data.Models;
using LearningSystem.Service.Admin.Contracts;
using LearningSystem.Web.Areas.Admin.Models.Courses;
using LearningSystem.Web.Controllers;
using LearningSystem.Web.Infrastructure.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningSystem.Web.Areas.Admin.Controllers
{
    public class CoursesController : BasicAdminController
    {
        private readonly UserManager<User> userManager;
        private readonly IAdminCourseService courseService;

        public CoursesController(UserManager<User> userManager, IAdminCourseService courseService)
        {
            this.userManager = userManager;
            this.courseService = courseService;
        }

        public async Task<IActionResult> Create()
        {
            var model = new AddCoursesFormViewModel
            {
                StartDate = DateTime.UtcNow,
                EndDate = DateTime.UtcNow.AddDays(30),
                Trainers = await this.GetTrainers()
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(AddCoursesFormViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Trainers = await this.GetTrainers();
                return View(model);
            }

            await this.courseService
                .Create(
                model.Name,
                model.Description,
                model.StartDate,
                model.EndDate.AddDays(1),
                model.TrainerId);

            TempData.AddSuccessMessage($"Course {model.Name} was created successfully!");

            return RedirectToAction(
                nameof(HomeController.Index),
                "Home",
                new { area = string.Empty });
        }

        // because is async and we will using the Trainers in view nad post Create methods
        private async Task<IEnumerable<SelectListItem>> GetTrainers()
        {
            var trainers = await this.userManager
                .GetUsersInRoleAsync(IdentitiesConstants.TRAINER_ROLE);

            var trainerListItems = trainers
                .Select(t => new SelectListItem
                {
                    Text = t.UserName,
                    Value = t.Id
                })
                .ToList();

            return trainerListItems;
        }
    }
}

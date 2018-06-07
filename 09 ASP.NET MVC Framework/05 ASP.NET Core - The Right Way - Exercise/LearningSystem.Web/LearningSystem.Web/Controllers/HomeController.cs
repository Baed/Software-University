using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LearningSystem.Web.Models;
using LearningSystem.Service.Courses.Contracts;
using LearningSystem.Web.Models.Home;
using LearningSystem.Service.UserProfile.Contracts;

namespace LearningSystem.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICourseService courseServices;
        private readonly IUserService userServices;


        public HomeController(ICourseService courseServices, IUserService userServices)
        {
            this.courseServices = courseServices;
            this.userServices = userServices;
        }

        public async Task<IActionResult> Index()
        => View(new HomeIndexViewModel
        {
            Courses = await this.courseServices.GetActiveAsync()
        });       

        public async Task<IActionResult> Search(SearchFormViewModel model)
        {
            var viewModel = new SearchViewModel
            {
                SearchText = model.SearchText
            };

            if (model.SearchInCourses)
            {
                viewModel.Courses = await this.courseServices
                    .FindAsync(model.SearchText);
            }

            if (model.SearchInCourses)
            {
                viewModel.Users = await this.userServices.FindAsync(model.SearchText);
            }

            return View(viewModel);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel
            {
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            });
        }
    }
}

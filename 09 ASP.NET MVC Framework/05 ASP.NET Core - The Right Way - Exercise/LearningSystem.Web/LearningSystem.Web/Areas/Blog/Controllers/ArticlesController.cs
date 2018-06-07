using Ganss.XSS;
using LearningSystem.Constants;
using LearningSystem.Data.Models;
using LearningSystem.Service.Blog.Contracts;
using LearningSystem.Service.Sanitizer.Contracts;
using LearningSystem.Web.Areas.Blog.Models;
using LearningSystem.Web.Areas.Blog.Models.Articles;
using LearningSystem.Web.Controllers;
using LearningSystem.Web.Infrastructure.Extensions;
using LearningSystem.Web.Infrastructure.Filters;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningSystem.Web.Areas.Blog.Controllers
{
    [Area(AdminConstants.BLOG_AREA)]
    [Authorize(Roles = IdentitiesConstants.AUTHOR_ROLE)]
    public class ArticlesController : Controller
    {
        private readonly IHtmlService htmlService;
        private readonly IBlogArticleService articleService;
        private readonly UserManager<User> userManager;


        public ArticlesController(IHtmlService htmlService, IBlogArticleService articleService, UserManager<User> userManager)
        {
            this.htmlService = htmlService;
            this.articleService = articleService;
            this.userManager = userManager;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index(int page = 1)
        {
            var model = new ArticleListingViewModel
            {
                Articles = await this.articleService.AllAsync(page),
                TotalArticles = await this.articleService.TotalAsync(),
                CurrentPage = page
            };

            return View(model);
        }


        public IActionResult Create() => View();

        [HttpPost]
        [ValidateModelState] //using custom filter
        public async Task<IActionResult> Create(PublishArticleFormViewModel model)
        {
            model.Content = this.htmlService.DoSanitize(model.Content);

            var userId = this.userManager.GetUserId(User);

            await this.articleService.ServiceCreateAsync(
                 model.Title,
                 model.Content,
                 userId);

            return RedirectToAction(nameof(Index));
        }

        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var model =await this.articleService
                                    .GetById(id);

            return this.ViewOrNotFound(model); // custom extensions
        }
    }
}

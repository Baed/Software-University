using LearningSystem.Constants;
using LearningSystem.Data.Models;
using LearningSystem.Service.Contracts.Admin;
using LearningSystem.Web.Areas.Admin.Models.Users;
using LearningSystem.Web.Infrastructure.Extensions;
using Microsoft.AspNetCore.Authorization;
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
    public class UsersController : BasicAdminController
    {
        private readonly IAdminUserService userServise;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<User> userManager;

        public UsersController(IAdminUserService users, RoleManager<IdentityRole> roleMananger, UserManager<User> userManager)
        {
            this.userServise = users;
            this.roleManager = roleMananger;
            this.userManager = userManager;
        }

        public IActionResult Index()
        {
            var users = this.userServise.All();

            var roles = this.roleManager
                .Roles
                .Select(r => new SelectListItem
                {
                    Text = r.Name,
                    Value = r.Name
                })
                .ToList();

            var model = new UserListingsViewModel
            {
                Users = users,
                Roles = roles
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddToRole(AddUserToRoleFormViewModel model)
        {
            var user = await this.userManager.FindByIdAsync(model.UserId);

            bool userExists = user != null;
            bool roleExists = await this.roleManager.RoleExistsAsync(model.Role);

            if (!roleExists || !userExists)
            {
                ModelState.AddModelError(string.Empty, "Invalid identity details.");
            }

            if (!ModelState.IsValid)
            {
                return RedirectToAction(nameof(Index));
            }

            await this.userManager.AddToRoleAsync(user, model.Role);

            TempData.AddSuccessMessage($"User {user.UserName} was added to {model.Role} role successfully!");

            return RedirectToAction(nameof(Index));
        }
    }
}

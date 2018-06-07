using IdentityDemo.Web.Data;
using IdentityDemo.Web.Infrastructures;
using IdentityDemo.Web.Models;
using IdentityDemo.Web.Models.IdentityViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityDemo.Web.Controllers.Identities
{
    [Authorize(Roles = GlobalConstants.AdministatorRole)]
    public class IdentityController : Controller
    {
        private readonly DemoIdentityDbContext db;
        private readonly UserManager<User> userManager;
        private readonly RoleManager<IdentityRole> roleManager;


        public IdentityController(DemoIdentityDbContext db, UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            this.db = db;
            this.userManager = userManager;
            this.roleManager = roleManager;

        }

        public IActionResult All()
        {
            var users = this.db
                .Users
                .Select(u => new ListUserViewModel
                {
                    Id = u.Id,
                    Username = u.UserName,
                    Email = u.Email,
                })
                .ToList();

            return View(users);
        }

        public async Task<IActionResult> Roles(string id)
        {
            var user = await this.userManager.FindByIdAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            var roles = await this.userManager.GetRolesAsync(user);

            var model = new UserWithRolesViewModel
            {
                Id = user.Id,
                Email = user.Email,
                Roles = roles
            };

            return View(model);
        }

        public IActionResult Create() => View();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateUserViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var result = await this.userManager.CreateAsync(new User
            {
                Email = model.Email,
                UserName = model.Email,
            }
            , model.Password);

            if (result.Succeeded)
            {
                TempData["SuccessMessage"] = $"User with e-mail {model.Email} created successfully!";

                return RedirectToAction(nameof(All));
            }
            else
            {
                this.AddModelErrors(result);

                return View(model);
            }
        }

        public async Task<IActionResult> ChangePassword(string id)
        {
            var user = await this.userManager.FindByIdAsync(id);

            if (user == null)
            {
                NotFound();
            }

            var model = new IdentityChangePasswordViewModel
            {
                Email = user.Email
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangePassword(string id, IdentityChangePasswordViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = await this.userManager.FindByIdAsync(id);

            if (user == null)
            {
                NotFound();
            }

            var token = await this.userManager.GeneratePasswordResetTokenAsync(user);

            var result = await this.userManager.ResetPasswordAsync(user, token, model.Password);

            if (result.Succeeded)
            {
                TempData["SuccessMessage"] = $"Password changed for user {user.Email} successfully!";

                return RedirectToAction(nameof(All));
            }
            else
            {
                this.AddModelErrors(result);

                return View(model);
            }
        }

        public async Task<IActionResult> Delete(string id)
        {
            var user = await this.userManager.FindByIdAsync(id);

            if (user == null)
            {
                NotFound();
            }

            var model = new DeleteUserViewModel
            {
                Id = user.Id,
                Email = user.Email
            };

            return View(model);
        }

        public async Task<IActionResult> Destroy(string id, DeleteUserViewModel model)
        {
            var user = await this.userManager.FindByIdAsync(id);

            if (user == null)
            {
                NotFound();
            }

            var result = await this.userManager.DeleteAsync(user);

            if (result.Succeeded)
            {
                TempData["SuccessMessage"] = $"User {user.Email} is successfully deleted!";

                return RedirectToAction(nameof(All));
            }
            else
            {
                return View(model);
            }
        }

        public IActionResult AddToRole(string id)
        {
            var rolesSelect = this.roleManager
                .Roles
                .Select(r => new SelectListItem
                {
                    Text = r.Name,
                    Value = r.Name
                })
                .ToList();

            return View(rolesSelect);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddToRole(string id, string role)
        {
            var user = await this.userManager.FindByIdAsync(id);

            var roleExist = await this.roleManager.RoleExistsAsync(role);

            if (user == null || !roleExist)
            {
                NotFound();
            }

            var result = await this.userManager.AddToRoleAsync(user, role);

            TempData["SuccessMessage"] = $"Role {role} for user {user.Email} is successfully added!";

            return RedirectToAction(nameof(All));
        }

        private void AddModelErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
        }
    }
}

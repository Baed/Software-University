using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Launcher.cs.GameStore.Common;
using Launcher.cs.GameStore.Services;
using Launcher.cs.GameStore.Services.Contracts;
using Launcher.cs.Infrastructure;
using Launcher.cs.Server.Http;
using Launcher.cs.Server.Http.Contracts;

namespace Launcher.cs.GameStore.Controllers
{
    public class BaseController : Controller
    {
        protected const string HomePath = @"/";

        private readonly IUserService users;

        protected BaseController(IHttpRequest request)
        {
            this.Request = request;
            this.Authentication = new Authentication(false, false);

            this.users = new UserService();

            this.ApplyAuthentication();
        }

        protected IHttpRequest Request { get; private set; }

        protected Authentication Authentication { get; private set; }

        protected override string ApplicationDirectory => "GameStoreApplication";

        private void ApplyAuthentication()
        {
            var anonymousDisplay = "flex";
            var authDisplay = "none";
            var adminDisplay = "none";

            var authenticatedUserEmail = this.Request
                .Session
                .Get<string>(SessionStore.CurrentUserKey);

            if (authenticatedUserEmail != null)
            {
                anonymousDisplay = "none";
                authDisplay = "flex";

                var isAdmin = this.users.IsAdmin(authenticatedUserEmail);

                if (isAdmin)
                {
                    adminDisplay = "flex";
                }

                this.Authentication = new Authentication(true, isAdmin);
            }

            this.ViewData["anonymousDisplay"] = anonymousDisplay;
            this.ViewData["authDisplay"] = authDisplay;
            this.ViewData["adminDisplay"] = adminDisplay;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Launcher.cs.Application.Controllers;
using Launcher.cs.Server.Contracts;
using Launcher.cs.Server.Routing.Contracts;

namespace Launcher.cs.Application
{
    public class MainApplication : IApplication
    {
        public void Configure(IAppRouteConfig appRouteConfig)
        {
            appRouteConfig.Get(
                "/",
                req => new HomeController().Index());

            appRouteConfig.Get(
                "/testsession",
                req => new HomeController().SessionTest(req));

            appRouteConfig.Get(
                "/users/{(?<name>[a-z]+)}",
                req => new HomeController().Index());
        }
    }
}
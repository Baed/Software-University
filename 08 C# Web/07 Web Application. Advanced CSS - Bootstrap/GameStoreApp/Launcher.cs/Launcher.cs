using System;
using Launcher.cs.GameStore;
using Launcher.cs.Server;
using Launcher.cs.Server.Contracts;
using Launcher.cs.Server.Routing;

namespace Launcher.cs
{
    class Launcher : IRunnable
    {
        public static void Main()
        {
            new Launcher().Run();
        }

        public void Run()
        {
            var mainApplication = new GameStoreApp();
            mainApplication.InitializeDatabase();
           
            var appRouteConfig = new AppRouteConfig();
            mainApplication.Configure(appRouteConfig);
           
            var webServer = new WebServer(1337, appRouteConfig);
           
            webServer.Run();
        }
    }
}
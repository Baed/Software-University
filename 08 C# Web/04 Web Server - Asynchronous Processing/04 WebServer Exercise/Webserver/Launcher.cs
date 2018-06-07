using Webserver.Application;
using Webserver.Server;
using Webserver.Server.Contracts;
using Webserver.Server.Routing;
using Webserver.Server.Routing.Contracts;

namespace Webserver
{
    internal class Launcher : IRunnable
    {
        private WebServer webServer;

        private static void Main()
        {
            new Launcher().Run();
        }

        public void Run()
        {
            IApplication app = new MainApplication();
            IAppRouteConfig routeConfig = new AppRouteConfig();
            app.Start(routeConfig);

            this.webServer = new WebServer(8080, routeConfig);
            this.webServer.Run();
        }
    }
}
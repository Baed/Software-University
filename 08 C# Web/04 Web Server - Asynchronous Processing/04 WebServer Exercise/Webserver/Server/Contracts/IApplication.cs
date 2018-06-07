using Webserver.Server.Routing.Contracts;

namespace Webserver.Server.Contracts
{
    public interface IApplication
    {
        void Start(IAppRouteConfig appRouteConfig);
    }
}
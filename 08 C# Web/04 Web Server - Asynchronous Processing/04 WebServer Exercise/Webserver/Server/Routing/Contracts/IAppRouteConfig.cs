using System.Collections.Generic;
using Webserver.Server.Enums;
using Webserver.Server.Handlers;

namespace Webserver.Server.Routing.Contracts
{
    public interface IAppRouteConfig
    {
        IReadOnlyDictionary<HttpRequestMethod, Dictionary<string, RequestHandler>> Routes { get; }

        void AddRoute(string route, RequestHandler httpHandler);
    }
}
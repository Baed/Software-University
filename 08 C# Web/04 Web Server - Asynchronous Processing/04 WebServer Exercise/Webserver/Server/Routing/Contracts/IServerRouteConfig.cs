using System.Collections.Generic;
using Webserver.Server.Enums;

namespace Webserver.Server.Routing.Contracts
{
    public interface IServerRouteConfig
    {
        Dictionary<HttpRequestMethod, Dictionary<string, IRoutingContext>> Routes { get; }
    }
}
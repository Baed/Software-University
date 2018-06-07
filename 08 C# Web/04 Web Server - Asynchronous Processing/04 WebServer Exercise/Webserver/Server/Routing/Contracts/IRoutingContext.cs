using System.Collections.Generic;
using Webserver.Server.Handlers;

namespace Webserver.Server.Routing.Contracts
{
    public interface IRoutingContext
    {
        IEnumerable<string> Parameters { get; }

        RequestHandler RequestHandler { get; }
    }
}
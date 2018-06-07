using System.Collections.Generic;
using Webserver.Server.Handlers;
using Webserver.Server.Routing.Contracts;

namespace Webserver.Server.Routing
{
    public class RoutingContext : IRoutingContext
    {
        public RoutingContext(RequestHandler requestHandler, IEnumerable<string> args)
        {
            this.Parameters = args;
            this.RequestHandler = requestHandler;
        }

        public IEnumerable<string> Parameters { get; private set; }

        public RequestHandler RequestHandler { get; set; }
    }
}
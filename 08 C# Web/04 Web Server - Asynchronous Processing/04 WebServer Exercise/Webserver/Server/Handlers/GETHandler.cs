using System;
using Webserver.Server.HTTP.Contracts;

namespace Webserver.Server.Handlers
{
    public class GETHandler : RequestHandler
    {
        public GETHandler(Func<IHttpContext, IHttpResponse> func) : base(func)
        {
        }
    }
}
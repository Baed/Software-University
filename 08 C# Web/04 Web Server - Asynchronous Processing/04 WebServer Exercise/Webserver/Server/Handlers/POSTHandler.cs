using System;
using Webserver.Server.HTTP.Contracts;

namespace Webserver.Server.Handlers
{
    public class POSTHandler : RequestHandler
    {
        public POSTHandler(Func<IHttpContext, IHttpResponse> func) : base(func)
        {
        }
    }
}
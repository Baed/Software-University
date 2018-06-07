using Webserver.Server.HTTP.Contracts;

namespace Webserver.Server.Handlers.Contracts
{
    public interface IRequestHandler
    {
        IHttpResponse Handle(IHttpContext httpContext);
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Launcher.cs.Server.Enums;
using Launcher.cs.Server.Handlers;
using Launcher.cs.Server.Http.Contracts;

namespace Launcher.cs.Server.Routing.Contracts
{
    public interface IAppRouteConfig
    {
        IReadOnlyDictionary<HttpRequestMethod, IDictionary<string, RequestHandler>> Routes { get; }

        ICollection<string> AnonymousPaths { get; }

        void Get(string route, Func<IHttpRequest, IHttpResponse> handler);

        void Post(string route, Func<IHttpRequest, IHttpResponse> handler);

        void AddRoute(string route, HttpRequestMethod method, RequestHandler handler);
    }
}
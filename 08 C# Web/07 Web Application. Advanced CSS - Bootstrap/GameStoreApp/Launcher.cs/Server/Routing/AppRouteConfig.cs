using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Launcher.cs.Server.Enums;
using Launcher.cs.Server.Handlers;
using Launcher.cs.Server.Http.Contracts;
using Launcher.cs.Server.Routing.Contracts;

namespace Launcher.cs.Server.Routing
{
    public class AppRouteConfig : IAppRouteConfig
    {
        private readonly Dictionary<HttpRequestMethod, IDictionary<string, RequestHandler>> routes;

        public AppRouteConfig()
        {
            this.AnonymousPaths = new List<string>();

            this.routes = new Dictionary<HttpRequestMethod, IDictionary<string, RequestHandler>>();

            var availableMethods = Enum
                .GetValues(typeof(HttpRequestMethod))
                .Cast<HttpRequestMethod>();

            foreach (var method in availableMethods)
            {
                this.routes[method] = new Dictionary<string, RequestHandler>();
            }
        }

        public IReadOnlyDictionary<HttpRequestMethod, IDictionary<string, RequestHandler>> Routes => this.routes;

        public ICollection<string> AnonymousPaths { get; private set; }

        public void Get(string route, Func<IHttpRequest, IHttpResponse> handler)
        {
            this.AddRoute(route, HttpRequestMethod.Get, new RequestHandler(handler));
        }

        public void Post(string route, Func<IHttpRequest, IHttpResponse> handler)
        {
            this.AddRoute(route, HttpRequestMethod.Post, new RequestHandler(handler));
        }

        public void AddRoute(string route, HttpRequestMethod method, RequestHandler handler)
        {
            this.routes[method].Add(route, handler);
        }
    }
}
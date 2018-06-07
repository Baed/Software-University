using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Launcher.cs.Server.Common;
using Launcher.cs.Server.Handlers.Contracts;
using Launcher.cs.Server.Http;
using Launcher.cs.Server.Http.Contracts;
using Launcher.cs.Server.Http.Responses;
using Launcher.cs.Server.Routing.Contracts;

namespace Launcher.cs.Server.Handlers
{
    public class HttpHandler : IRequestHandler
    {
        private readonly IServerRouteConfig serverRouteConfig;

        public HttpHandler(IServerRouteConfig routeConfig)
        {
            CoreValidator.ThrowIfNull(routeConfig, nameof(routeConfig));

            this.serverRouteConfig = routeConfig;
        }

        public IHttpResponse Handle(IHttpContext context)
        {
            try
            {
                // Check if user is authenticated
                var anonymousPaths = this.serverRouteConfig.AnonymousPaths;

                if (!anonymousPaths.Contains(context.Request.Path) &&
                    (context.Request.Session == null || !context.Request.Session.Contains(SessionStore.CurrentUserKey)))
                {
                    return new RedirectResponse(anonymousPaths.First());
                }

                var requestMethod = context.Request.Method;
                var requestPath = context.Request.Path;
                var registeredRoutes = this.serverRouteConfig.Routes[requestMethod];

                foreach (var registeredRoute in registeredRoutes)
                {
                    var routePattern = registeredRoute.Key;
                    var routingContext = registeredRoute.Value;

                    var routeRegex = new Regex(routePattern);
                    var match = routeRegex.Match(requestPath);

                    if (!match.Success)
                    {
                        continue;
                    }

                    var parameters = routingContext.Parameters;

                    foreach (var parameter in parameters)
                    {
                        var parameterValue = match.Groups[parameter].Value;
                        context.Request.AddUrlParameter(parameter, parameterValue);
                    }

                    return routingContext.Handler.Handle(context);
                }
            }
            catch (Exception ex)
            {
                return new InternalServerErrorResponse(ex);
            }

            return new NotFoundResponse();
        }
    }
}
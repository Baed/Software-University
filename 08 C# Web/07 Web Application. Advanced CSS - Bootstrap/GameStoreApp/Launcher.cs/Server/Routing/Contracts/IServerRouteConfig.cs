using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Launcher.cs.Server.Enums;

namespace Launcher.cs.Server.Routing.Contracts
{
    public interface IServerRouteConfig
    {
        IDictionary<HttpRequestMethod, IDictionary<string, IRoutingContext>> Routes { get; }

        ICollection<string> AnonymousPaths { get; }
    }
}
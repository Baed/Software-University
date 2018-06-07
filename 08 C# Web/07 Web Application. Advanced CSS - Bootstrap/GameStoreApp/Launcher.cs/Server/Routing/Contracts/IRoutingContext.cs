using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Launcher.cs.Server.Handlers;

namespace Launcher.cs.Server.Routing.Contracts
{
    public interface IRoutingContext
    {
        IEnumerable<string> Parameters { get; }

        RequestHandler Handler { get; }
    }
}
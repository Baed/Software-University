using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Launcher.cs.Server.Routing.Contracts;

namespace Launcher.cs.Server.Contracts
{
    public interface IApplication
    {
        void Configure(IAppRouteConfig appRouteConfig);
    }
}

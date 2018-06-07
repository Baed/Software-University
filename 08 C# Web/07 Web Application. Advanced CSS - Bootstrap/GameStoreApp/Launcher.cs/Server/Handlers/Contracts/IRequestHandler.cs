using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Launcher.cs.Server.Http.Contracts;

namespace Launcher.cs.Server.Handlers.Contracts
{
    public interface IRequestHandler
    {
        IHttpResponse Handle(IHttpContext context);
    }
}

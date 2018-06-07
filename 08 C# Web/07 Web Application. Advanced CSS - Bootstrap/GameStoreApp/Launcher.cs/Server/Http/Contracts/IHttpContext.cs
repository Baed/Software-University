using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Launcher.cs.Server.Http.Contracts
{
    public interface IHttpContext
    {
        IHttpRequest Request { get; }
    }
}

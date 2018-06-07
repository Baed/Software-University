using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Launcher.cs.Server.Common;
using Launcher.cs.Server.Http.Contracts;

namespace Launcher.cs.Server.Http
{
    public class HttpContext : IHttpContext
    {
        private readonly IHttpRequest request;

        public HttpContext(IHttpRequest request)
        {
            CoreValidator.ThrowIfNull(request, nameof(request));

            this.request = request;
        }

        public IHttpRequest Request => this.request;
    }
}
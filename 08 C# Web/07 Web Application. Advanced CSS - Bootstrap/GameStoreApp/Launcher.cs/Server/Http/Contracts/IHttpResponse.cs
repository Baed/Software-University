using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Launcher.cs.Server.Enums;

namespace Launcher.cs.Server.Http.Contracts
{
    public interface IHttpResponse
    {
        HttpStatusCode StatusCode { get; }

        IHttpHeaderCollection Headers { get; }

        IHttpCookieCollection Cookies { get; }
    }
}
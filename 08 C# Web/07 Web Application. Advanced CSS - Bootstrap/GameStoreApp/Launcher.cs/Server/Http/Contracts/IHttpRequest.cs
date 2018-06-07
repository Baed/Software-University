using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Launcher.cs.Server.Enums;

namespace Launcher.cs.Server.Http.Contracts
{
    public interface IHttpRequest
    {
        IDictionary<string, string> FormData { get; }

        IHttpHeaderCollection Headers { get; }

        IHttpCookieCollection Cookies { get; }

        string Path { get; }

        HttpRequestMethod Method { get; }

        string Url { get; }

        IDictionary<string, string> UrlParameters { get; }

        IHttpSession Session { get; set; }

        void AddUrlParameter(string key, string value);
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Launcher.cs.Server.Http.Contracts
{
    public interface IHttpCookieCollection : IEnumerable<HttpCookie>
    {
        void Add(HttpCookie cookie);

        void Add(string key, string value);

        bool ContainsKey(string key);

        HttpCookie Get(string key);
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Launcher.cs.Server.Http.Contracts
{
    public interface IHttpHeaderCollection : IEnumerable<ICollection<HttpHeader>>
    {
        void Add(HttpHeader header);

        void Add(string key, string value);

        bool ContainsKey(string key);

        ICollection<HttpHeader> Get(string key);
    }
}
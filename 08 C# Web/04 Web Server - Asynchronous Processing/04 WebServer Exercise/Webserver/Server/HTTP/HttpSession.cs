using System.Collections.Generic;
using Webserver.Server.HTTP.Contracts;

namespace Webserver.Server.HTTP
{
    public class HttpSession : IHttpSession
    {
        private string id;
        private Dictionary<string, object> parameters;

        public HttpSession(string id)
        {
            this.parameters = new Dictionary<string, object>();
            this.id = id;
        }

        public string Id => this.id;

        public void Add(string key, object value)
        {
            this.parameters[key] = value;
        }

        public void Clear()
        {
            this.parameters.Clear();
        }

        public object Get(string key)
        {
            if (!this.parameters.ContainsKey(key))
            {
                return null;
            }

            return this.parameters[key];
        }

        public T Get<T>(string key)
            => (T)this.Get(key);

        public bool IsAuthenticated()
        {
            return true;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Launcher.cs.Server.Enums;
using Launcher.cs.Server.Http.Contracts;

namespace Launcher.cs.Server.Http.Responses
{
    public class HttpResponse : IHttpResponse
    {
        private string statusCodeMessage => this.StatusCode.ToString();

        protected HttpResponse()
        {
            this.Headers = new HttpHeaderCollection();
            this.Cookies = new HttpCookieCollection();
        }

        public IHttpHeaderCollection Headers { get; }

        public IHttpCookieCollection Cookies { get; }

        public HttpStatusCode StatusCode { get; protected set; }

        public override string ToString()
        {
            var response = new StringBuilder();

            var statusCodeNumber = (int)this.StatusCode;
            response.AppendLine($"HTTP/1.1 {statusCodeNumber} {this.statusCodeMessage}");

            response.AppendLine(this.Headers.ToString());

            return response.ToString();
        }
    }
}
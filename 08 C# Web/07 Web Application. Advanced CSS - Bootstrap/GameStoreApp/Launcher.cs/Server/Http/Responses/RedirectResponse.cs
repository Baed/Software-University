using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Launcher.cs.Server.Common;
using Launcher.cs.Server.Enums;

namespace Launcher.cs.Server.Http.Responses
{
    public class RedirectResponse : HttpResponse
    {
        public RedirectResponse(string redirectUrl)
        {
            CoreValidator.ThrowIfNullOrEmpty(redirectUrl, nameof(redirectUrl));

            this.StatusCode = HttpStatusCode.Found;

            this.Headers.Add(HttpHeader.Location, redirectUrl);
        }
    }
}
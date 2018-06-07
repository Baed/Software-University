using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Launcher.cs.Server.Enums;

namespace Launcher.cs.Server.Http.Responses
{
    public class BadRequestResponse : HttpResponse
    {
        public BadRequestResponse()
        {
            this.StatusCode = HttpStatusCode.BadRequest;
        }
    }
}
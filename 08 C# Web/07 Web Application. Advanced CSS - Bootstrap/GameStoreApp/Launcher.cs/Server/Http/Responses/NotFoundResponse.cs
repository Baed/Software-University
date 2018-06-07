using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Launcher.cs.Server.Common;
using Launcher.cs.Server.Enums;

namespace Launcher.cs.Server.Http.Responses
{
    public class NotFoundResponse : ViewResponse
    {
        public NotFoundResponse()
            : base(HttpStatusCode.NotFound, new NotFoundView())
        {
        }
    }
}
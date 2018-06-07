using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Launcher.cs.Server.Enums
{
    public enum HttpStatusCode
    {
        Ok = 200,
        MovedPermanently = 301,
        Found = 302,
        MovedTemporary = 303,
        BadRequest = 400,
        NotAuthorized = 401,
        NotFound = 404,
        InternalServerError = 500
    }
}

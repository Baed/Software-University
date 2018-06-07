using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Launcher.cs.Application.Home.View;
using Launcher.cs.Server.Enums;
using Launcher.cs.Server.Http;
using Launcher.cs.Server.Http.Contracts;
using Launcher.cs.Server.Http.Responses;

namespace Launcher.cs.Application.Controllers
{
    public class HomeController
    {
        public IHttpResponse Index()
        {
            var response = new ViewResponse(HttpStatusCode.Ok, new IndexView());

            response.Cookies.Add(new HttpCookie("lang", "en"));

            return response;
        }

        public IHttpResponse SessionTest(IHttpRequest req)
        {
            var session = req.Session;

            const string sessionDateKey = "saved_date";

            if (session.Get(sessionDateKey) == null)
            {
                session.Add(sessionDateKey, DateTime.UtcNow);
            }

            return new ViewResponse(
                HttpStatusCode.Ok,
                new SessionTestView(session.Get<DateTime>(sessionDateKey)));
        }
    }
}
using Webserver.Application.Views;
using Webserver.Server;
using Webserver.Server.Enums;
using Webserver.Server.HTTP.Contracts;
using Webserver.Server.HTTP.Response;

namespace Webserver.Application.Controllers
{
    public class UserController
    {
        public IHttpResponse RegisterGet()
        {
            return new ViewResponse(HttpStatusCode.OK, new RegisterView());
        }

        public IHttpResponse RegisterPost(string name)
        {
            return new RedirectResponse($"/user/{name}");
        }

        public IHttpResponse Details(string name)
        {
            Model model = new Model { ["name"] = name };
            return new ViewResponse(HttpStatusCode.OK, new UserDetailsView(model));
        }
    }
}
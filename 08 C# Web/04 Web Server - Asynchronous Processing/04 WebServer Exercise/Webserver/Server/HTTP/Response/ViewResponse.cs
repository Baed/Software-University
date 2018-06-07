using Webserver.Server.Contracts;
using Webserver.Server.Enums;

namespace Webserver.Server.HTTP.Response
{
    public class ViewResponse : HttpResponse
    {
        public ViewResponse(HttpStatusCode responseCode, IView view) : base(responseCode, view)
        {
        }
    }
}
using Webserver.Server;
using Webserver.Server.Contracts;

namespace Webserver.Application.Views
{
    public class UserDetailsView : IView
    {
        private readonly Model model;

        public UserDetailsView(Model model)
        {
            this.model = model;
        }

        public string View()
        {
            return $"<body><h3>Hello, {model["name"]}!</h3> </br><a href=\"/\">Home</a></body>";
        }
    }
}
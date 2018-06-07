using Webserver.Server.Contracts;

namespace Webserver.Application.Views
{
    public class RegisterView : IView
    {
        public string View()
        {
            return
                "<body>" +
                "   <form method=\"POST\">" +
                "       Name</br>" +
                "       <input type=\"text\" name=\"name\" /><br/>" +
                "       <input type=\"submit\" />" +
                "   </form>" +
                "</br><a href=\"/\">Home</a>" +
                "</body>";
        }
    }
}
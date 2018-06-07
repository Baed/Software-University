using System.IO;
using Webserver.Server.Contracts;

namespace Webserver.Application.Views
{
    public class AboutUsView : IView
    {
        public string View()
        {
            string html = File.ReadAllText(@"..\..\..\Application\Resources\about.html");

            return html;
        }
    }
}
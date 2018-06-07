using System.IO;
using Webserver.Server.Contracts;

namespace Webserver.Application.Views
{
    public class HomeIndexView : IView
    {
        public string View()
        {
            string html = File.ReadAllText(@"..\..\..\Application\Resources\index.html");

            return html;
        }
    }
}
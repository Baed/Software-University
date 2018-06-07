using System.IO;
using Webserver.Application.Models;
using Webserver.Server.Contracts;

namespace Webserver.Application.Views
{
    public class AddView : IView
    {
        private const string ReplacementSnip = "<!--replace-->";

        public string View()
        {
            string html = File.ReadAllText(@"..\..\..\Application\Resources\add.html");

            string cakesHtml = CakeList.GetCakesAsHtmlString();

            html = html.Replace(ReplacementSnip, cakesHtml);

            return html;
        }
    }
}
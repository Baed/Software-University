using System.IO;
using Webserver.Server.Contracts;

namespace Webserver.Application.Views
{
    public class CalculatorView : IView
    {
        public static string lastResult;
        private const string ReplacementSnip = "<!--replace-->";

        public string View()
        {
            string html = File.ReadAllText(@"..\..\..\Application\Resources\calculator.html");

            if (!string.IsNullOrEmpty(lastResult))
            {
                string resultHtml = $"<p>Result: {lastResult}</p>";

                html = html.Replace(ReplacementSnip, resultHtml);

                lastResult = string.Empty;
            }

            return html;
        }
    }
}
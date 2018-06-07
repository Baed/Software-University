using System.IO;
using Webserver.Server.Contracts;

namespace Webserver.Application.Views
{
    public class LoginView : IView
    {
        private const string ReplacementSnip = "<!--replace-->";
        public static bool isAdmin;
        public static bool hasPost;
        public static bool emailSent;
        public static bool emailIsValid;

        public string View()
        {
            string html = File.ReadAllText(@"..\..\..\Application\Resources\login.html");

            if (isAdmin)
            {
                html = File.ReadAllText(@"..\..\..\Application\Resources\email.html");

                if (emailSent)
                {
                    string resultHtml = $"<p style=\"color: Red\">Email data is not valid!</p>";

                    if (emailIsValid)
                    {
                        resultHtml = $"<p style=\"color: Green\">Email sent!</p>";

                        emailIsValid = false;
                    }

                    html = html.Replace(ReplacementSnip, resultHtml);

                    emailSent = false;
                }
            }
            else if (hasPost)
            {
                string resultHtml = $"<p style=\"color: red\">Invalid username or password!</p>";

                html = html.Replace(ReplacementSnip, resultHtml);

                hasPost = false;
            }

            return html;
        }
    }
}
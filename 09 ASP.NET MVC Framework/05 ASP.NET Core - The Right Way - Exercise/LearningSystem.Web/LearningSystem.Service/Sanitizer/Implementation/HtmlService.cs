using Ganss.XSS;
using LearningSystem.Service.Sanitizer.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningSystem.Service.Sanitizer.Implementation
{
    public class HtmlService : IHtmlService
    {
        private readonly HtmlSanitizer sanitizer;

        public HtmlService()
        {
            this.sanitizer = new HtmlSanitizer();
            this.sanitizer.AllowedAttributes.Add("class");
        }

        public string DoSanitize(string htmlContent)
        {
            return this.sanitizer.Sanitize(htmlContent);
        }
    }
}

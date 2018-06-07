using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningSystem.Service.Sanitizer.Contracts
{
    public interface IHtmlService
    {
        string DoSanitize(string htmlContent);
    }
}

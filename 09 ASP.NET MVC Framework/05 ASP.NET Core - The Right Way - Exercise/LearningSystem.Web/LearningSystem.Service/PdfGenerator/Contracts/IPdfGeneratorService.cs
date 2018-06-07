using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningSystem.Service.PdfGenerator.Contracts
{
    public interface IPdfGeneratorService
    {
        byte[] GeneratePdfFromHtml(string html);
    }
}

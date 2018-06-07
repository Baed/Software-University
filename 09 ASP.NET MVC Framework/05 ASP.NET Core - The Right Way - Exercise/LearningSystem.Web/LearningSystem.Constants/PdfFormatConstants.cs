using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningSystem.Constants
{
    public class PdfFormatConstants
    {
        public const string PDF_CERTIFICATE_FORMAT = @"
<h1>Certificate</h1>
<h2>{3} - Grade {4}</h2>
<br />
<h2>{0} Course</h2>
<h3>{1} - {2}</h3>
<h4>Signed By {5}</h4>
<h5>{6}</h5>
";
    }
}

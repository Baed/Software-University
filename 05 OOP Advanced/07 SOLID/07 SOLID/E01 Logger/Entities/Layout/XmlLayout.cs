namespace E01_Logger
{
    using System.Text;

    public class XmlLayout : ILayout
    {
        public XmlLayout()
        {
        }

        public string FormatMessage(string timeStamp, string reportLevel, string message)
        {
            StringBuilder msg = new StringBuilder();

            return msg.AppendLine($"<log>")
                .AppendLine($"  <date>{timeStamp}</date>")
                .AppendLine($"  <level>{reportLevel}</level>")
                .AppendLine($"  <message>{message}</message>")
                .AppendLine($"</log>")
                .ToString();
        }
    }
}
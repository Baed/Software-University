namespace E01_Logger.Entities
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class LogFile
    {
        private const string DefaultFileName = "log.txt";
        private StringBuilder stringBuilder;

        public LogFile()
        {
            this.stringBuilder = new StringBuilder();
        }

        public int Size { get; private set; }

        private int GetLettersOnlySum(string message)
        {
            return message
                .Where(c => char.IsLetter(c))
                .Sum(c => c);
        }

        public void Write(string formattedMessage)
        {
            this.stringBuilder.AppendLine(formattedMessage);

            File.AppendAllText(DefaultFileName, formattedMessage + Environment.NewLine);

            this.Size = this.GetLettersOnlySum(formattedMessage);
        }
    }
}

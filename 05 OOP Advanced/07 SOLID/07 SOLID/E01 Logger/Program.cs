namespace E01_Logger
{
    using Appenders;
    using Enums;
    using Entities;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using E01_Logger.Factories;
    using System.Globalization;
    using System.Reflection;

    class Program
    {
        static void Main(string[] args)
        {
            int appenderCount = int.Parse(Console.ReadLine());

            IAppender[] appenders = new IAppender[appenderCount];

            for (int i = 0; i < appenderCount; i++)
            {
                string[] appenderInfo = Console.ReadLine().Split();

                ILayout currentLayout = LayoutFactory.GetInstance(appenderInfo[1]);

                IAppender currentAppender = AppenderFactory.GetAppender(appenderInfo[0], currentLayout);

                if (appenderInfo.Length > 2)
                {
                    string enumName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(appenderInfo[2].ToLower());

                    currentAppender.ReportLevel = (ReportLevel)Enum.Parse(typeof(ReportLevel), enumName);
                }

                appenders[i] = currentAppender;
            }

            Logger myLogger = new Logger(appenders);

            string inputMSg;

            while ((inputMSg = Console.ReadLine()) != "END")
            {
                var tokens = inputMSg.Split('|');

                string methodName = CultureInfo
                    .CurrentCulture
                    .TextInfo
                    .ToTitleCase(tokens[0].ToLower());

                MethodInfo currentMethod = typeof(Logger).GetMethod(methodName);

                currentMethod.Invoke(myLogger, new object[] { tokens[1], tokens[2] });
            }

            Console.WriteLine(myLogger);

            // the decision at the end of the fifth part of the task can be seen in the course github 
        }
    }
}

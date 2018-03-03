using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Raincast
{
    class Program
    {
        static void Main(string[] args)
        {
            string typePattern = "^Type: (Normal|Warning|Danger)$";
            string sourcePattern = "^Source: ([a-zA-Z0-9]+)$";
            string forecastPattern = "^Forecast: ([^!.,?]+)$";

            List<string> raincasts = new List<string>();

            string currentLine = "type";

            string currentRainCast = string.Empty;

            string inputLine = string.Empty;
            while ((inputLine = Console.ReadLine()) != "Davai Emo")
            {
                switch (currentLine)
                {
                    case "type":
                        if (Regex.IsMatch(inputLine, typePattern))
                        {
                            currentRainCast = $"({Regex.Match(inputLine, typePattern).Groups[1]})";
                            currentLine = "source";
                        }
                        break;

                    case "source":
                        if (Regex.IsMatch(inputLine, sourcePattern))
                        {
                            currentRainCast += " " + "***" + " ~ " + $"{Regex.Match(inputLine, sourcePattern).Groups[1]}";
                            currentLine = "forecast";
                        }
                        break;

                    case "forecast":
                        if (Regex.IsMatch(inputLine, forecastPattern))
                        {
                            currentRainCast = currentRainCast.Replace("***",Regex.Match(inputLine, forecastPattern).Groups[1].Value);
                            raincasts.Add(currentRainCast);
                            currentLine = "type";
                        }
                        break;
                }
            }

            foreach (var raincast in raincasts)
            {
                Console.WriteLine(raincast);
            }

        }
    }
}

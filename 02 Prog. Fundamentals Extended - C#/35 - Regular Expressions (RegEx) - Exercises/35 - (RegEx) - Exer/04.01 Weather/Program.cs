using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04._01_Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string ,Forecast> weathers = new Dictionary<string, Forecast>();

            string pattern = @"([A-Z]{2})([0-9]+\.[0-9]+)([A-Za-z]+)\|";

            Regex regex = new Regex(pattern);

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                var matches = regex.Matches(command);

                foreach (Match match in matches)
                {
                    if (match.Success)
                    {
                        string city = match.Groups[1].Value;
                        double temperature = double.Parse(match.Groups[2].Value);
                        string forecastInfo = match.Groups[3].Value;

                        Forecast forecast = new Forecast(city, temperature, forecastInfo);

                        if (!weathers.ContainsKey(city))
                        {
                            weathers.Add(city, new Forecast(city, temperature, forecastInfo));
                        }

                        weathers[city] = forecast;
                    }
                }
            }

            foreach (var weather in weathers.Values.OrderBy(f => f.Temperature))
            {
                Console.WriteLine(weather);
            }
        }
    }

    class Forecast
    {
        public Forecast(string city, double temperature, string forecast)
        {
            this.City = city;
            this.Temperature = temperature;
            this.WeatherInfo = forecast;
        }

        public string City { get; set; }

        public double Temperature { get; set; }

        public string WeatherInfo { get; set; }

        public override string ToString()
        {
            return $"{City} => {Temperature:f2} => {WeatherInfo}";
        }
    }
}

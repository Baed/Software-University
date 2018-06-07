using System;
using System.Net;

namespace L02_Validate_URL
{
    class Program
    {
        static void Main(string[] args)
        {
            string ulr = Console.ReadLine();

            var decodedUrl = WebUtility.UrlDecode(ulr);

            var parsedUrl = new Uri(decodedUrl);

            Console.WriteLine($"Protocol: " + parsedUrl.Host);
            Console.WriteLine($"Host: " + parsedUrl.Host);
            Console.WriteLine($"Port: " + parsedUrl.Port);
            Console.WriteLine($"Path: " + parsedUrl.AbsolutePath);
            Console.WriteLine($"Query: " + parsedUrl.Query);
            Console.WriteLine($"Fragment: " + parsedUrl.Fragment);
        }
    }
}

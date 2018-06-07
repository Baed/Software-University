using System;
using System.Collections.Generic;
using System.Net;

namespace L03_Request_Parser
{
    class Program
    {
        static void Main(string[] args)
        {
            var validUrls = new Dictionary<string, HashSet<string>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                var urlToken = input.Split(new[] { '/' }, StringSplitOptions.RemoveEmptyEntries);

                string path = $"/{urlToken[0]}";
                string method = urlToken[1];

                if (!validUrls.ContainsKey(path))
                {
                    validUrls[path] = new HashSet<string>();
                }

                validUrls[path].Add(method);
            }

            var request = Console.ReadLine();
            var requestTokens = request.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var requestMethod = requestTokens[0];
            var requestUrl = requestTokens[1];
            var requestProtocol = requestTokens[2];

            var responseStatusIndex = 404;
            var responseStatusMsg = "NotFound";

            if (validUrls.ContainsKey(requestUrl) 
                && validUrls[requestUrl].Contains(requestMethod.ToLower()))
            {
                responseStatusIndex = 200;
                responseStatusMsg = "OK";
            }

            Console.WriteLine($"{requestProtocol} {responseStatusIndex} {responseStatusMsg}");
            Console.WriteLine($"Content-Length: {responseStatusMsg.Length}");
            Console.WriteLine("Content-Type: text/plain");
            Console.WriteLine();
            Console.WriteLine($"{responseStatusMsg}");
        }
    }
}

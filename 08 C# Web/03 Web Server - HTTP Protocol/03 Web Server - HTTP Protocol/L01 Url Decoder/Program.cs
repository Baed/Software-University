using System;
using System.Net;

namespace L01_Url_Decoder
{
    class Program
    {
        static void Main(string[] args)
        {
            string ulr = Console.ReadLine();

            var decodedUrl = WebUtility.UrlDecode(ulr);

            var parsedUrl = new Uri(decodedUrl);

            Console.WriteLine(parsedUrl);
        }
    }
}

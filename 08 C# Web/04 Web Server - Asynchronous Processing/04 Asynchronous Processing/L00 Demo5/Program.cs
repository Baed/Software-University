using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace L00_Demo5
{
    class Program
    {
        static void Main(string[] args)
        {
            Task.Run(async () =>
           {
               await DownloadFileAsync();
           })
               .GetAwaiter()
               .GetResult();

        }

        static async Task DownloadFileAsync()
        {
            var webClient = new WebClient();

            Console.WriteLine("Downloading...");

            await webClient.DownloadFileTaskAsync("urladress", "book.pdf");

            Console.WriteLine("Download successful.");
        }

    }
}

using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace L03_Simple_Web_Server
{
    class Program
    {
        static void Main(string[] args)
        {
            var port = 1337;

            var ipAdress = IPAddress.Parse("127.0.0.1");

            var tcpListener = new TcpListener(ipAdress, port);

            tcpListener.Start();

            Task
                .Run(async () =>
                {
                    await Connect(tcpListener);
                })
                .GetAwaiter()
                .GetResult();
        }

        public static async Task Connect(TcpListener listener)
        {
            while (true)
            {
                var client = await listener.AcceptTcpClientAsync();

                Console.WriteLine("Client connected." + Environment.NewLine);

                var buffer = new byte[1024];

                await client.GetStream().ReadAsync(buffer, 0, buffer.Length);

                var clientMsg = Encoding.UTF8.GetString(buffer);

                Console.WriteLine(clientMsg.Trim('\0'));

                var responseMsg = "Hello from server!";

                var data = Encoding.UTF8.GetBytes(responseMsg);

                await client.GetStream().WriteAsync(data, 0, data.Length);

                client.Dispose();
            }
        }
    }
}

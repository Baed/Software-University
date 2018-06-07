namespace SignalRDemo.Hub
{
    using Microsoft.AspNetCore.SignalR;
    using System.Threading.Tasks;

    public class ChatHub : Hub
    {
        public async Task Send(string message)
        {
            await this.Clients.All.InvokeAsync("Send", message);
        }
    }
}

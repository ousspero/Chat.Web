using Microsoft.AspNetCore.SignalR;

namespace Chat.Web.Hubs
{
    public class ChatHub : Hub
    {
        public async void Send(string user, string message)
        {
          await  Clients.All.SendAsync("Receive", user, message);
        }
    }
}

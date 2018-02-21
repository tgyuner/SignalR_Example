using Microsoft.AspNet.SignalR;

namespace SignalR_Example.Hubs
{
    public class ChatHub : Hub
    {
        public void SendMessage(string name, string message)
        {
            Clients.Others.GetMessageOther(name, message);

            Clients.Caller.GetMessageCaller(message);

        }
    }
}
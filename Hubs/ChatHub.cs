// A hub is a class that serves as a high-level pipeline that handles client-server communication.

using Microsoft.AspNetCore.SignalR;

namespace SignalRChat.Hubs
{
	public class ChatHub : Hub
	{
		public async Task SendMessage(string user, string message)
		{
			await Clients.All.SendAsync("ReceiveMessage", user, message);
		}
	}
}
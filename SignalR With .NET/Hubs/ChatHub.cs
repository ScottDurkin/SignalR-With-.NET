using Microsoft.AspNetCore.SignalR;


//A hub is a class that serves as a high-level pipeline that handles client-server communication.
//The ChatHub class inherits from the SignalR Hub class. The Hub class manages connections, groups, and messaging.


namespace SignalR_With_.NET.Hubs
{
    public class ChatHub : Hub
    {
        /// <summary>
        /// The SendMessage method can be called by a connected client to send a message to all clients. JavaScript client code that calls the method is shown later in the tutorial. 
        /// SignalR code is asynchronous to provide maximum scalability.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="Message"></param>
        /// <returns></returns>
        public async Task SendMessage(String user, String Message)
        {
            await Clients.All.SendAsync("RecieveMessage", user, Message);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using GamediateWebsocket.Interfaces;

namespace GamediateWebsocket.Hubs
{
    //a hub gets used to communicatie between client and server (similar to a controller)
    //signalR allows two way communication
    //inherits from the interface
    public class SignalrDemoClass : Hub<ISignalrDemoHub>
    {
        public void Hello()
        {
            Clients.Caller.DisplayMessage("Hello there!");
        }
    }
}

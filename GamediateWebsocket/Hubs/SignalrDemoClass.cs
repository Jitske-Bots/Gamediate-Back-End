using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using GamediateWebsocket.Interfaces;

namespace GamediateWebsocket.Hubs
{
    public class SignalrDemoClass : Hub<ISignalrDemoHub>
    {
        public void Hello()
        {
            Clients.Caller.DisplayMessage("Hello there!");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamediateWebsocket.Interfaces
{
    public interface ISignalrDemoHub
    {
        Task DisplayMessage(string message);
    }
}

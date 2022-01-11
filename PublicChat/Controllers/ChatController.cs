using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PublicChat.Hubs;
using PublicChat.ReqDTO;
using Microsoft.AspNetCore.SignalR;


namespace PublicChat.Controllers
{
    [Route("chat")]
    [ApiController]
    public class ChatController : Controller
    {
        private readonly IHubContext<ChatHub> _hubContext;
        public ChatController(IHubContext<ChatHub> hubContext)
        {
            _hubContext = hubContext;
        }

        [Route("send")]   //path looks like this: https://localhost:44379/chat/send
        [HttpPost]
        public IActionResult SendRequest([FromBody] MessageDTO msg)
        {
            _hubContext.Clients.All.SendAsync("ReceiveOne", msg.user, msg.msgText);
            return Ok();
        }
    }
}

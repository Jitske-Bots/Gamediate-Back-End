using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gamediate_back_end.BLL;
using Gamediate_back_end.Models;

namespace Gamediate_back_end.Controllers
{
    [Route("order")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly OrderBLL orderBLL;
        
        public OrderController(OrderBLL orderBLL)
        {
            this.orderBLL = orderBLL;
        }

        /// <summary>
        /// this method will get the list of orderitems
        /// add an order
        /// and add orderitems
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> AddOrder([FromBody]Order order)
        {
            order.OrderDate = DateTime.Now;
            orderBLL.Add(order);
            return Ok();
        }
    }
}

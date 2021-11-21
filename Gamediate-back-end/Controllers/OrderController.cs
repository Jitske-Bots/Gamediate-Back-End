using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gamediate_back_end.BLL;
using Gamediate_back_end.Models;
using System.Text.Json;
using Microsoft.AspNetCore.Http;
using System.Text.Json.Serialization;
using Gamediate_back_end.ViewModels;
using Microsoft.AspNetCore.Cors;

namespace Gamediate_back_end.Controllers
{
    [Route("cart")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly OrderBLL orderBLL;
        private readonly OrderItemBLL orderItemBLL;
        public OrderController(OrderBLL orderBLL, OrderItemBLL orderItemBLL)
        {
            this.orderBLL = orderBLL;
            this.orderItemBLL = orderItemBLL;
        }

        //adding the order
        //then adding OrderItems, with the orderID
        //needs to get params: Order and OrderItem
        [Route("order")]
        [HttpPost]
        public async Task<IActionResult> AddOrder([FromBody] Order order)
        {
            int orderID = 0;
            order.OrderDate = DateTime.Now;
            orderID = orderBLL.Add(order);
            foreach(var item in order.orderItems)
            {
                item.OrderID = orderID;
                orderItemBLL.Add(item);

            }
            return Ok(order);

        }
    }
}

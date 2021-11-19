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
        private int orderID;
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
            //Order order = new Order(accountID, orderDate, totalAmount);
            //Order _order = new Order(order.AccountID, DateTime.Now, order.TotalAmount);
            order.OrderDate = DateTime.Now;
            this.orderID = orderBLL.Add(order);
            return Ok(order);

        }
        [Route("orderItems")]
        [HttpPost]
        public async Task<IActionResult> AddOrderItems([FromBody] OrderItem[] orderItems)
        {
            foreach(var item in orderItems)
            {
                item.OrderID = this.orderID;
                orderItemBLL.Add(item); 
            }
            return Ok(orderItems);
        }
    }
}

using Gamediate_back_end.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gamediate_back_end.Models;

namespace Gamediate_back_end.DAL
{
    public class OrderItemDAL : IOrderItemDAL
    {
        private readonly GameContext orderItemContext;
        public OrderItemDAL(GameContext orderItemContext)
        {
            this.orderItemContext = orderItemContext;
        }

        public void Add(OrderItem orderItemDTO)
        {
            orderItemContext.Add(orderItemDTO);
            orderItemContext.SaveChanges();
        }

        public IEnumerable<OrderItem> GetAll(int orderID)
        {
            return orderItemContext.OrderItems.Where(orderItem => orderItem.OrderID == orderID);
        }
    }
}

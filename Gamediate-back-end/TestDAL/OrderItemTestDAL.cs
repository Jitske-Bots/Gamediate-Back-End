using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gamediate_back_end.DAL;
using Gamediate_back_end.Models;

namespace Gamediate_back_end.TestDAL
{
    public class OrderItemTestDAL : IOrderItemDAL
    {
        private List<OrderItem> OrderItems;

        public OrderItemTestDAL()
        {
            this.OrderItems = new List<OrderItem>();
        }
        public void Add(OrderItem orderItem)
        {
            OrderItems.Add(orderItem);
        }

        public IEnumerable<OrderItem> GetAll(int orderID)
        {
            return OrderItems;
        }
    }
}

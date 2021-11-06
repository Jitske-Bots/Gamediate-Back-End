using Gamediate_back_end.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gamediate_back_end.DAL
{
    public class OrderItemDAL : IOrderItemDAL
    {
        private readonly OrderItemContext orderItemContext;
        public OrderItemDAL(OrderItemContext orderItemContext)
        {
            this.orderItemContext = orderItemContext;
        }

        public void Add(OrderItemDTO orderItemDTO)
        {
            orderItemContext.Add(orderItemDTO);
        }

        public IEnumerable<OrderItemDTO> GetAll()
        {
            return orderItemContext.OrderItems;
        }
    }
}

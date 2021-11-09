using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gamediate_back_end.DTOS;

namespace Gamediate_back_end.DAL
{
    public class OrderDAL : IOrderDAL
    {
        private readonly GameContext orderContext;

        public OrderDAL(GameContext orderContext)
        {
            this.orderContext = orderContext;
        }
        public void Add(OrderDTO orderDTO)
        {
            orderContext.Orders.Add(orderDTO);
        }
        public IEnumerable<OrderDTO> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}

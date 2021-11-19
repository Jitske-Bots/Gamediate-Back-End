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
        public int Add(OrderDTO orderDTO)
        {
            orderContext.Orders.Add(orderDTO);
            orderContext.SaveChanges();
            int orderID = orderDTO.ID;
            return orderID;
        }
        public IEnumerable<OrderDTO> GetAll(int accountID)
        {
            return orderContext.Orders.Where(order => order.AccountID == accountID);
        }
    }
}

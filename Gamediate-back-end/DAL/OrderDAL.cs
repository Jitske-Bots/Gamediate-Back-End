using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Gamediate_back_end.Models;

namespace Gamediate_back_end.DAL
{
    public class OrderDAL : IOrderDAL
    {
        private readonly GameContext orderContext;

        public OrderDAL(GameContext orderContext)
        {
            this.orderContext = orderContext;
        }
        public int Add(Order order)
        {
            orderContext.Orders.Add(order);
            orderContext.SaveChanges();
            int orderID = order.ID;
            return orderID;
        }
        public IEnumerable<Order> GetAll(int accountID)
        {
            return orderContext.Orders.Where(order => order.AccountID == accountID)
                .Include(o => o.orderItems).ToList();
        }
    }
}

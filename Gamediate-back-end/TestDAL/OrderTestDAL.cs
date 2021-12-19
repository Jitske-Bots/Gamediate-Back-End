using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gamediate_back_end.DAL;
using Gamediate_back_end.Models;

namespace Gamediate_back_end.TestDAL
{
    public class OrderTestDAL : IOrderDAL
    {
        public List<Order> Orders { get; private set; }
        private int id;
        public OrderTestDAL()
        {
            this.Orders = new List<Order>();
            this.id = 1;
        }
        public int Add(Order order)
        {
            order.ID = this.id;
            this.id++;
            this.Orders.Add(order);
            return order.ID;
        }

        public IEnumerable<Order> GetAll(int accountID)
        {
            return this.Orders.Where(order => order.AccountID == accountID);
        }
    }
}

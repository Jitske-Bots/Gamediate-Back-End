using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gamediate_back_end.Models;
using Gamediate_back_end.DAL;
using Gamediate_back_end.DTOS;

namespace Gamediate_back_end.BLL
{
    public class OrderBLL
    {
        private readonly IOrderDAL iOrderRepo;

        public OrderBLL(IOrderDAL iOrderRepo)
        {
            this.iOrderRepo = iOrderRepo;
        }
        public IEnumerable<Order> GetAll()
        {
            List<Order> orders = new List<Order>();
            foreach(var dtoOrder in iOrderRepo.GetAll())
            {
                orders.Add(new Order(dtoOrder));
            }
            return orders;
        }
        public void Add(Order order)
        {
            iOrderRepo.Add(new OrderDTO
            {
                ID = order.ID,
                AccountID = order.AccountID,
                OrderDate = order.OrderDate,
                TotalAmount = order.TotalAmount
            });

        }
    }
}

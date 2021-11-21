using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gamediate_back_end.DAL;
using Gamediate_back_end.DTOS;
using Gamediate_back_end.Models;

namespace Gamediate_back_end.BLL
{
    public class OrderItemBLL
    {
        private readonly IOrderItemDAL iOrderItemRepo;
        public OrderItemBLL(IOrderItemDAL iOrderItemRepo)
        {
            this.iOrderItemRepo = iOrderItemRepo;
        }
        public IEnumerable<OrderItem> GetAll(int orderID)
        {
            List<OrderItem> orders = new List<OrderItem>();
            foreach(OrderItem orderItem in iOrderItemRepo.GetAll(orderID))
            {
                orders.Add(new OrderItem
                {
                    ID = orderItem.ID,
                    OrderID = orderItem.OrderID,
                    GameID = orderItem.GameID,
                    Price = orderItem.Price
                });
            }
            return orders;
        }
        public void Add(OrderItem orderItem)
        {
            iOrderItemRepo.Add(orderItem);
        }
    }
}

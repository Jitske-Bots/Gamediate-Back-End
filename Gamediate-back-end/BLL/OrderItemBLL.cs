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
        public IEnumerable<OrderItem> GetAll()
        {
            List<OrderItem> orders = new List<OrderItem>();
            foreach(OrderItemDTO orderItemDTO in iOrderItemRepo.GetAll())
            {
                orders.Add(new OrderItem
                {
                    ID = orderItemDTO.ID,
                    OrderID = orderItemDTO.OrderID,
                    GameID = orderItemDTO.GameID,
                    Price = orderItemDTO.Price
                });
            }
            return orders;
        }
        public void Add(OrderItem orderItem)
        {
            iOrderItemRepo.Add(new OrderItemDTO
            {
                ID = orderItem.ID,
                OrderID = orderItem.ID,
                GameID = orderItem.GameID,
                Price = orderItem.Price
            });
        }
    }
}

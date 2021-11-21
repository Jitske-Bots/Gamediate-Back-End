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
        public IEnumerable<Order> GetAll(int accountID)
        {
            return iOrderRepo.GetAll(accountID);
        }
        public int Add(Order order)
        {
            Order _order = new Order();
            _order.AccountID = order.AccountID;
            _order.OrderDate = order.OrderDate;
            _order.TotalAmount = order.TotalAmount;
            int orderID = iOrderRepo.Add(_order);
            return orderID;


        }
    }
}

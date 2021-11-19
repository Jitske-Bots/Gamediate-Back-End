using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gamediate_back_end.Models;

namespace Gamediate_back_end.ViewModels
{
    public class OrderViewModel
    {
        public int AccountID { get; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }

        public OrderViewModel(Order order)
        {
            this.AccountID = order.AccountID;
            this.OrderDate = order.OrderDate;
            this.TotalAmount = order.TotalAmount;
        }
        public OrderViewModel()
        {

        }
    }
}

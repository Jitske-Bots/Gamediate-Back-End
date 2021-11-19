using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gamediate_back_end.Models
{
    public class OrderItems
    {
        public List<OrderItem> orderItems { get; set; }
        public OrderItems()
        {
            this.orderItems = new List<OrderItem>();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gamediate_back_end.ViewModels
{
    public class OrderItemsViewModel
    {
        public List<OrderItemViewModel> orderItems { get; set; }

        public OrderItemsViewModel()
        {
            this.orderItems = new List<OrderItemViewModel>();
        }
    }
}

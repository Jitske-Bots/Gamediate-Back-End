using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gamediate_back_end.Models;

namespace Gamediate_back_end.ViewModels
{
    public class OrderItemViewModel
    {
        public int ID { get; set; }
        public int OrderID { get; set; }
        public int GameID { get; set; }
        public decimal Price { get; set; }

    }
}

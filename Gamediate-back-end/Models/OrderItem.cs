using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Gamediate_back_end.Models
{
    public class OrderItem
    {
        [Key]
        [Required]
        public int ID { get; set; }
        public int OrderID { get; set; }
        public int GameID { get; set; }
        public decimal Price { get; set; }
        public OrderItem()
        {

        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gamediate_back_end.DTOS
{
    public class OrderItemDTO
    {
        [Key]
        [Required]
        public int ID { get; set; }
        public int OrderID { get; set; }
        public int GameID { get; set; }
        public Decimal Price { get; set; }
    }
}

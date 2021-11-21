using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Gamediate_back_end.DTOS
{
    public class OrderDTO
    {
        [Key]
        [Required]
        public int ID { get; set; }
        public int AccountID { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public virtual ICollection<OrderItemDTO> orderItems { get; set; }

    }
}

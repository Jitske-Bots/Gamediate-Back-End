using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Gamediate_back_end.Models
{
    public class Order
    {
        [Key]
        [Required]
        public int ID { get; set; }
        public int AccountID { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }

        /// <summary>
        /// one to many relationship. 
        /// </summary>
        public virtual ICollection<OrderItem> orderItems { get; set; }

        public Order()
        {

        }
        public Order(int accoountID, DateTime orderDate, decimal totalAmount)
        {
            this.AccountID = accoountID;
            this.OrderDate = orderDate;
            this.TotalAmount = totalAmount;
        }
    }
}

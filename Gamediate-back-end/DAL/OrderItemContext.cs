using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gamediate_back_end.DTOS;

namespace Gamediate_back_end.DAL
{
    public class OrderItemContext : DbContext
    {
        public OrderItemContext(DbContextOptions options) : base(options) { }

        //virtual method is a method that can be redefined in derived classes.
        public virtual DbSet<OrderItemDTO> OrderItems { get; set; }
        public virtual DbSet<OrderItemDTO> CustomerOrderItems { get; set; }

    }
}

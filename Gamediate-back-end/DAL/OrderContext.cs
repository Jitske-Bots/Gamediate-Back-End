using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Gamediate_back_end.DTOS;

namespace Gamediate_back_end.DAL
{
    public class OrderContext : DbContext
    {
        public OrderContext(DbContextOptions options) : base(options) { }
        public virtual DbSet<OrderDTO> Orders { get; set; }

    }
}

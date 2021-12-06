using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Gamediate_back_end.DTOS;
using Gamediate_back_end.Models;

namespace Gamediate_back_end.DAL
{
    public class GameContext : DbContext
    {
        public GameContext(DbContextOptions options) : base(options) { }
        public virtual DbSet<GameDTO> Games { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderItem> OrderItems { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<WishlistItem> WishlistItems { get; set; }

    }
}

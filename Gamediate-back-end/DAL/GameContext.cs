using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Gamediate_back_end.DTOS;

namespace Gamediate_back_end.DAL
{
    public class GameContext : DbContext
    {
        public GameContext(DbContextOptions options) : base(options) { }
        public virtual DbSet<GameDTO> Games { get; set; }

    }
}

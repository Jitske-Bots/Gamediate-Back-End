using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gamediate_back_end.Models
{
    public class Game
    {
        [Key]
        [Required]
        public int ID { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Description { get; set;  }
        public DateTime ReleaseDate { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        public string Developer { get; set; }
        public string Publisher { get; set; }
    }
}

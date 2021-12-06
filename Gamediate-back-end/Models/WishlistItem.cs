using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Gamediate_back_end.Models
{
    public class WishlistItem
    {
        [Key]
        [Required]
        public int ID { get; set; }
        public int AccountID { get; set; }
        public int GameID { get; set; }

    }
}

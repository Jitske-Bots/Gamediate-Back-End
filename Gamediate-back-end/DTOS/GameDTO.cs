﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gamediate_back_end.Models;


namespace Gamediate_back_end.DTOS
{
    public class GameDTO
    {
        [Key]
        [Required]
        public int ID { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        public string Developer { get; set; }
        public string Publisher { get; set; }

        public GameDTO(Game game)
        {
            this.ID = game.ID;
            this.Title = game.Title;
            this.Genre = game.Genre;
            this.Description = game.Description;
            this.ReleaseDate = game.ReleaseDate;
            this.Price = game.Price;
            this.Image = game.Image;
            this.Description = game.Developer;
            this.Publisher = game.Publisher;
        }
    }
}

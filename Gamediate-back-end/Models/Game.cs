using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gamediate_back_end.DTOS;

namespace Gamediate_back_end.Models
{
    public class Game
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Description { get; set;  }
        public DateTime ReleaseDate { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        public string Developer { get; set; }
        public string Publisher { get; set; }
        public Game(int id, string title, string genre, string description, DateTime releaseDate, decimal price, string image, string developer, string publisher)
        {
            this.ID = id;
            this.Title = title;
            this.Genre = genre;
            this.Description = description;
            this.ReleaseDate = releaseDate;
            this.Price = price;
            this.Image = image;
            this.Developer = developer;
            this.Publisher = publisher;
        }
        public Game()
        {

        }
        public Game(GameDTO gameDTO)
        {
            this.ID = gameDTO.ID;
            this.Title = gameDTO.Title;
            this.Genre = gameDTO.Genre;
            this.Description = gameDTO.Description;
            this.ReleaseDate = gameDTO.ReleaseDate;
            this.Price = gameDTO.Price;
            this.Image = gameDTO.Image;
            this.Developer = gameDTO.Developer;
            this.Publisher = gameDTO.Publisher;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gamediate_back_end.DAL;
using Gamediate_back_end.Models;

namespace Gamediate_back_end.TestDAL
{
    public class GameTestDAL : IGameDAL
    {
        private readonly List<Game> Games;

        public GameTestDAL()
        {
            this.Games = new List<Game>();
            this.AddMockData();
        }
        public IEnumerable<Game> GetAll()
        {
             return this.Games;
        }
        private void AddMockData()
        {
            Game game1 = new()
            {
                ID = 1,
                Title = "game1",
                Genre = "action",
                Description = "some action game",
                ReleaseDate = DateTime.Now,
                Price = 59,
                Image = "someimage",
                Developer = "dev",
                Publisher = "pub"
            };
            Game game2 = new()
            {
                ID = 2,
                Title = "game2",
                Genre = "RPG",
                Description = "some RPG game",
                ReleaseDate = DateTime.Now,
                Price = 39,
                Image = "someimage",
                Developer = "dev",
                Publisher = "pub"
            };
            Game game3 = new()
            {
                ID = 3,
                Title = "game3",
                Genre = "platformer",
                Description = "some platformer game",
                ReleaseDate = DateTime.Now,
                Price = 10,
                Image = "someimage",
                Developer = "dev",
                Publisher = "pub"
            };
            this.Games.Add(game1);
            this.Games.Add(game2);
            this.Games.Add(game3);
        }
    }
}

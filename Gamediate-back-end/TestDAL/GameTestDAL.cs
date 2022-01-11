using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gamediate_back_end.DAL;
using Gamediate_back_end.DTOS;
using Gamediate_back_end.Models;

namespace Gamediate_back_end.TestDAL
{
    public class GameTestDAL : IGameDAL
    {
        private List<GameDTO> Games;

        public GameTestDAL()
        {
            this.Games = new List<GameDTO>();
            this.AddMockData();
        }
        public IEnumerable<GameDTO> GetAll()
        {
             return this.Games;
        }
        private void AddMockData()
        {
            GameDTO game1 = new GameDTO
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
            GameDTO game2 = new GameDTO
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
            GameDTO game3 = new GameDTO
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

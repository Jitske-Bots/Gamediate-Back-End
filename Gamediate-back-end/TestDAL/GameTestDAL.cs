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
            Games.Add(new GameDTO(new Game(1, "game1", "action", "some action game", 
                DateTime.Now, 59, "someimage", "dev", "pub")));
            Games.Add(new GameDTO(new Game(2, "game2", "RPG", "some RPG game",
                DateTime.Now, 30, "someimage", "dev", "pub")));
            Games.Add(new GameDTO(new Game(3, "game3", "Platformer", "some platform game",
                DateTime.Now, 10, "someimage", "dev", "pub")));
        }
    }
}

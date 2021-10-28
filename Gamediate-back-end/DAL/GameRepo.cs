using Gamediate_back_end.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Gamediate_back_end.DAL
{
    public class GameRepo : IGameBLL
    {
        private readonly GameContext gameContext;
        public GameRepo(GameContext gameContext)
        {
            this.gameContext = gameContext;
        }
        public IEnumerable<GameDTO> GetAll()
        {
            IEnumerable<GameDTO> gameList = new List<GameDTO>();
            gameList = gameContext.Games;

            return gameList;

        }
    }
}

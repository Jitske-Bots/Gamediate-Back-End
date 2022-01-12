using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Gamediate_back_end.Models;

namespace Gamediate_back_end.DAL
{
    public class GameDAL : IGameDAL
    {
        private readonly GameContext gameContext;
        public GameDAL(GameContext gameContext)
        {
            this.gameContext = gameContext;
        }
        public IEnumerable<Game> GetAll()
        {
            IEnumerable<Game> gameList = new List<Game>();
            gameList = gameContext.Games;

            return gameList;

        }
    }
}

using Gamediate_back_end.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gamediate_back_end.DAL
{
    public class GameRepo : IGameBLL
    {
        private readonly GameContext gameContext;
        public GameRepo(GameContext gameContext)
        {
            this.gameContext = gameContext;
        }
        public List<GameDTO> GetAll()
        {
            List<GameDTO> gameList = gameContext.Games.ToList();
            return gameList;


        }
    }
}

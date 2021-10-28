using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gamediate_back_end.DTOS;
using Gamediate_back_end.DAL;
using Gamediate_back_end.Models;

namespace Gamediate_back_end.BLL
{
    public class GameBLL
    {
        IGameBLL iGameBLL;

        public GameBLL(IGameBLL igameBLL)
        {
            this.iGameBLL = igameBLL;

        }
        public IEnumerable<Game> GetAll()
        {
            List<Game> allGames = new List<Game>();
            foreach(GameDTO gameDTO in iGameBLL.GetAll())
            {
                allGames.Add(new Game(gameDTO));
            }
            return allGames;
        }
    }
}

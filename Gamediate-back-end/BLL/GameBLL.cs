using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gamediate_back_end.DAL;
using Gamediate_back_end.Models;
using AutoMapper;

namespace Gamediate_back_end.BLL
{
    public class GameBLL
    {
        private readonly IGameDAL iGameDAL;
        public GameBLL(IGameDAL igameBLL)
        {
            this.iGameDAL = igameBLL;
        }
        public IEnumerable<Game> GetAll()
        {
            return iGameDAL.GetAll();
        }
        public List<Game> GetFavorite(List<int> gameIDS)
        {
            List<Game> favoriteGames = new List<Game>();
            foreach(int id in gameIDS)
            {
                foreach (Game game in iGameDAL.GetAll())
                {
                    if(id == game.ID)
                    {
                        favoriteGames.Add(game);
                        break;
                    }
                }
            }
            return favoriteGames;

        }
    }
}

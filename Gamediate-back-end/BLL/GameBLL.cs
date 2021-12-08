using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gamediate_back_end.DTOS;
using Gamediate_back_end.DAL;
using Gamediate_back_end.Models;
using AutoMapper;

namespace Gamediate_back_end.BLL
{
    public class GameBLL
    {
        private readonly IGameDAL iGameBLL;
        public GameBLL(IGameDAL igameBLL)
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
        public List<Game> GetFavorite(List<int> gameIDS)
        {
            List<Game> favoriteGames = new List<Game>();
            foreach(int id in gameIDS)
            {
                foreach (GameDTO gameDTO in iGameBLL.GetAll())
                {
                    if(id == gameDTO.ID)
                    {
                        favoriteGames.Add(new Game(gameDTO));
                        break;
                    }
                }
            }
            return favoriteGames;

        }
    }
}

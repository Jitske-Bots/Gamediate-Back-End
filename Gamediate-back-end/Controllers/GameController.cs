using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gamediate_back_end.DAL;
using Gamediate_back_end.BLL;
using AutoMapper;
using Gamediate_back_end.Models;
using Microsoft.AspNetCore.Cors;

namespace Gamediate_back_end.Controllers
{
    [EnableCors("CorsDevelopment")]
    [Route("games")]
    [ApiController]
    public class GameController : ControllerBase
    {
        private readonly GameBLL gameBLL;
        public GameController(GameBLL gameBLL)
        {
            this.gameBLL = gameBLL;
        }

        [HttpGet]
        [ActionName("gameOverview")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult GetAll()
        {
            var games = gameBLL.GetAll();
            return Ok(games);

        }
        [HttpPost]
        [Route("getFavorite")]
        public IActionResult GetFavoriteGames([FromBody] List<int> gameIDS)
        {
            var favGames = gameBLL.GetFavorite(gameIDS);
            return Ok(favGames);
        }
    }
}

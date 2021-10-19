using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gamediate_back_end.DAL;
using Gamediate_back_end.BLL;

namespace Gamediate_back_end.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        private GameBLL gameBLL;
        private GameRepo gameRepo;
        public GameController(GameRepo gameRepo)
        {
            this.gameRepo = gameRepo;
            this.gameBLL = new GameBLL(gameRepo);


        }
        [HttpGet]
        [ActionName("gameOverview")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult GetAll()
        {
            return Ok(gameBLL.GetAll());
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gamediate_back_end.DAL;
using Gamediate_back_end.BLL;
using AutoMapper;
using Gamediate_back_end.DTOS;
using Gamediate_back_end.Models;

namespace Gamediate_back_end.Controllers
{
    [Route("games")]
    [ApiController]
    public class GameController : ControllerBase
    {
        private readonly IMapper imapper;
        private readonly GameBLL gameBLL;
        public GameController(IMapper imapper, GameBLL gameBLL)
        {
            this.gameBLL = gameBLL;
            this.imapper = imapper;
        }

        [HttpGet]
        [ActionName("gameOverview")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult GetAll()
        {
            var games = gameBLL.GetAll();
            return Ok(imapper.Map<ICollection<GameDTO>>(games));
        }
    }
}

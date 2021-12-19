using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gamediate_back_end.Models;
using Gamediate_back_end.BLL;
using Gamediate_back_end.DAL;

namespace Gamediate_back_end.Controllers
{
    [Route("wishlist")]
    [ApiController]
    public class WishlistController : ControllerBase
    {
        private readonly WishlistBLL wishlistBLL;
        public WishlistController(WishlistBLL wishlistBLL)
        {
            this.wishlistBLL = wishlistBLL;
        }
        [HttpPost]
        [Route("add")]
        public async Task<ActionResult<Account>> Add([FromBody] WishlistItem item)
        {
            return Ok(wishlistBLL.Add(item));
        }
        [HttpPost]
        [Route("items")]
        public IActionResult GetAll([FromBody] int accountID)
        {
            List<WishlistItem> items = wishlistBLL.GetAll(accountID);
            return Ok(wishlistBLL.GetAll(accountID));
        }
        [HttpPost]
        [Route("remove")]
        public IActionResult Remove([FromBody] int id)
        {
            return Ok(wishlistBLL.Remove(id));
        }


    }
}

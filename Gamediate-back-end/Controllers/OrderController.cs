using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gamediate_back_end.BLL;
using Gamediate_back_end.Models;
using System.Text.Json;
using Microsoft.AspNetCore.Http;

namespace Gamediate_back_end.Controllers
{
    [Route("order")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly OrderBLL orderBLL;
        
        public OrderController(OrderBLL orderBLL)
        {
            this.orderBLL = orderBLL;
        }

        /// <summary>
        /// this method will get the gameID and the price from the added game
        /// get the list
        /// and add a dictionary to the list
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> AddOrderItem([FromBody]int gameID, int price)
        {
            List<Dictionary<string, int>> shoppingCart = this.GetShoppingCart();
            shoppingCart.Add(
            new Dictionary<string, int>() {
                    { "gameID", gameID },
                    { "price", price },
            });

            //create new cookie
            //cookies are saved for 1 hour
            //append the shoppingcart to the cookie
            CookieOptions option = new CookieOptions();
            option.Expires = DateTime.Now.AddHours(1);
            Response.Cookies.Append("shoppingCart", JsonSerializer.Serialize(shoppingCart), option);

            return Ok();
        }

        private List<Dictionary<string, int>> GetShoppingCart()
        {
            //Dictionary is a generic collection which is generally used to store key/value pairs.
            string value = Request.Cookies["shoppingCart"];
            if (value != null)
            {
                return JsonSerializer.Deserialize<List<Dictionary<string, int>>>(value);
            }
            else
            {
                return new List<Dictionary<string, int>>();
            }
        }
    }
}

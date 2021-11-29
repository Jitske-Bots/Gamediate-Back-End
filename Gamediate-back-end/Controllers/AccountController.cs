using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gamediate_back_end.Models;
using Gamediate_back_end.BLL;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;


namespace Gamediate_back_end.Controllers
{
    [Route("account")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly AccountBLL accountBLL;

        public AccountController(AccountBLL accountBLL)
        {
            this.accountBLL = accountBLL;
        }
        [HttpPost]
        [Route("login")]
        public async Task<ActionResult<Account>> Login([FromBody] Account account)
        {
            Account _account = accountBLL.GetAccount(account);
            if (_account != null)
            {
                if (account.Password == _account.Password)
                {
                    return Ok(_account);

                }
                else
                {
                    return StatusCode(404, "Wrong password");
                }
            }
            return StatusCode(404, "User doesn't exist");

        }
        [HttpPost]
        [Route("signup")]
        public async Task<ActionResult<Account>> Signup([FromBody] Account account)
        {
            if (account.GetType().GetProperties().Select(x => x.GetValue(account)).Any(value => value != null))
            {
                accountBLL.AddAccount(account);
                return CreatedAtAction("Signup", account);
            }
            return StatusCode(404, "Not all fields are filled in");
        }
        [HttpGet]
        [Route("get")]
        public IActionResult GetAccount([FromBody] Account account)
        {
            Account _account = accountBLL.GetAccount(account);
            return Ok(_account);
        }


    }

}

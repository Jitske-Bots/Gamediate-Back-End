using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gamediate_back_end.Models;
using Gamediate_back_end.DAL;

namespace Gamediate_back_end.BLL
{
    public class AccountBLL
    {
        private readonly IAccountDAL iAccountDAL;

        public AccountBLL(IAccountDAL iAccountDAL)
        {
            this.iAccountDAL = iAccountDAL;
        }
        public Account AddAccount(Account account)
        {
            return iAccountDAL.AddAccount(account);
        }
        public Account GetAccount(Account account)
        {
            return iAccountDAL.GetAccount(account);
        }
        public Account GetAccountByEmail(string email)
        {
            return iAccountDAL.GetAccountByEmail(email);
        }
    }
}

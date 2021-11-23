using Gamediate_back_end.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gamediate_back_end.DAL
{
    public class AccountDAL : IAccountDAL
    {
        private readonly GameContext accountContext;
        public AccountDAL(GameContext accountContext)
        {
            this.accountContext = accountContext;
        }

        public Account AddAccount(Account account)
        {
            accountContext.Accounts.Add(account);
            accountContext.SaveChanges();
            return account;
        }

        public Account GetAccount(Account account)
        {
            return accountContext.Accounts.SingleOrDefault(q => q.ID == account.ID);
        }
    }
}

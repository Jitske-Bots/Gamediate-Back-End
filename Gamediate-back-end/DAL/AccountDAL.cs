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

        public Account EditAccount(Account account)
        {
            Account result = accountContext.Accounts.SingleOrDefault(a => a.ID == account.ID);
            if (result != null)
            {
                result.FirstName = account.FirstName;
                result.LastName = account.LastName;
                result.Address = account.Address;
                result.HouseNumber = account.HouseNumber;
                result.PostalCode = account.PostalCode;
                result.City = account.City;
                result.PhoneNumber = account.PhoneNumber;
                accountContext.SaveChanges();
            }
            return result;
        }

        public Account GetAccount(Account account)
        {
            List<Account> accounts = accountContext.Accounts.ToList();
            Account _account = new Account();
            foreach (Account acc in accounts)
            {
                if (acc.Email == account.Email)
                {
                    _account = acc;
                }
            }
            return _account;
        }

        public Account GetAccountByEmail(string email)
        {
            return accountContext.Accounts.SingleOrDefault(acc => acc.Email == email);
        }

        public bool RemoveAccount(Account account)
        {
            foreach(Account acc in accountContext.Accounts)
            {
                if (account.ID == acc.ID)
                {
                    accountContext.Remove(acc);
                }
            }
            return true;
        }
    }
}

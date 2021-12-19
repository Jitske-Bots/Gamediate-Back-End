using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gamediate_back_end.DAL;
using Gamediate_back_end.Models;

namespace Gamediate_back_end.TestDAL
{
    public class AccountTestDAL : IAccountDAL
    {
        private List<Account> Accounts;
        private int ID;
        public AccountTestDAL()
        {
            this.Accounts = new List<Account>();
            this.ID = 1;
        }
        public Account AddAccount(Account account)
        {
            account.ID = this.ID;
            this.ID++;
            Accounts.Add(account);
            return account;
        }

        public Account EditAccount(Account account)
        {
            Account editedAccount = new Account();
            foreach(Account acc in this.Accounts)
            {
                if (acc.ID == account.ID)
                {
                    acc.FirstName = account.FirstName;
                    acc.LastName = account.LastName;
                    acc.Address = account.Address;
                    acc.HouseNumber = account.HouseNumber;
                    acc.PostalCode = account.PostalCode;
                    acc.City = account.City;
                    acc.PhoneNumber = account.PhoneNumber;

                    editedAccount = acc;
                    break;
                }
            }
            return editedAccount;
            
        }

        public Account GetAccount(Account account)
        {
            Account searchedAccount = new Account();
            foreach(Account acc in this.Accounts)
            {
                if(acc.Email == account.Email)
                {
                    searchedAccount = acc;
                    break;
                }
            }
            return searchedAccount;
        }

        public Account GetAccountByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public bool RemoveAccount(Account account)
        {
            throw new NotImplementedException();
        }
    }
}

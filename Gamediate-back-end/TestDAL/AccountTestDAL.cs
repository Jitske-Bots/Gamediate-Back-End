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
            this.AddMockData();
        }
        private  void AddMockData()
        {
            Account account = new Account();
            account.FirstName = "Bob";
            account.LastName = "lastname";
            account.Address = "somestreet";
            account.HouseNumber = "24";
            account.PostalCode = "9876WE";
            account.City = "Rotterdam";
            account.PhoneNumber = "0634297541";
            account.Email = "blastname@gmail.com";
            account.Password = "strongpassword";

            Account account2 = new Account();
            account.FirstName = "Sarah";
            account.LastName = "Janssen";
            account.Address = "somewhere";
            account.HouseNumber = "56";
            account.PostalCode = "3457SI";
            account.City = "Amsterdam";
            account.PhoneNumber = "0623418643";
            account.Email = "sjanssen@gmail.com";
            account.Password = "verystrongpassword";

            this.Accounts.Add(account);
            this.Accounts.Add(account2);
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
            foreach(Account account in this.Accounts)
            {
                if(account.Email == email)
                {
                    return account;
                }
            }
            return null;
        }

        public bool RemoveAccount(Account account)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Gamediate_back_end.DAL;
using Gamediate_back_end.Models;
using Gamediate_back_end.TestDAL;
using Gamediate_back_end.BLL;

namespace gamediate_back_end_tests
{
    [TestClass]
    public class AccountTests
    {
        [TestMethod]
        public void Register()
        {
            AccountTestDAL accountDAL = new AccountTestDAL();
            AccountBLL accountBLL = new AccountBLL(accountDAL);

            Account account = new Account();
            account.FirstName = "John";
            account.LastName = "Doe";
            account.Address = "street";
            account.HouseNumber = "10A";
            account.PostalCode = "1234AB";
            account.City = "Amsterdam";
            account.PhoneNumber = "0623435623";
            account.Email = "jdoe@gmail.com";
            account.Password = "password";

            accountBLL.AddAccount(account);
            Account adddedAccount = accountBLL.GetAccount(account);

            Assert.AreEqual(account.Email, adddedAccount.Email);
        }
        [TestMethod]
        public void Edit()
        {
            AccountTestDAL accountDAL = new AccountTestDAL();
            AccountBLL accountBLL = new AccountBLL(accountDAL);

            Account account = new Account();
            account.FirstName = "John";
            account.LastName = "Doe";
            account.Address = "street";
            account.HouseNumber = "10A";
            account.PostalCode = "1234AB";
            account.City = "Amsterdam";
            account.PhoneNumber = "0623435623";
            account.Email = "jdoe@gmail.com";
            account.Password = "password";

            accountBLL.AddAccount(account);
            string houseNumberBeforeEdit = account.HouseNumber;

            Account editedAccount = account;
            editedAccount.HouseNumber = "12B";

            accountBLL.EditAccount(editedAccount);

            Assert.AreNotEqual(houseNumberBeforeEdit, accountBLL.GetAccount(editedAccount).HouseNumber);

        }
        [TestMethod]
        public void GetAccountByEmail()
        {
            AccountTestDAL accountDAL = new AccountTestDAL();
            AccountBLL accountBLL = new AccountBLL(accountDAL);

            Account searchedAccount = accountBLL.GetAccountByEmail("sjanssen@gmail.com");
            Assert.IsNotNull(searchedAccount);
        }
    }
}

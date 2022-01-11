using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Gamediate_back_end.DAL;
using Gamediate_back_end.Models;
using Gamediate_back_end.BLL;
using Gamediate_back_end.TestDAL;

namespace gamediate_back_end_tests
{
    [TestClass]
    public class WishlistTests
    {
        [TestMethod]
        public void Add()
        {
            WishlistTestDAL wishlistDAL = new WishlistTestDAL();
            WishlistBLL wishlistBLL = new WishlistBLL(wishlistDAL);

            WishlistItem newItem = new WishlistItem
            {
                ID = 4,
                AccountID = 2,
                GameID = 2
            };
            wishlistBLL.Add(newItem);
            Assert.AreEqual(4, wishlistDAL.Wishlist.Count);
        }

        [TestMethod]
        public void Get()
        {
            WishlistTestDAL wishlistDAL = new WishlistTestDAL();
            WishlistBLL wishlistBLL = new WishlistBLL(wishlistDAL);

            Assert.AreEqual(1, wishlistBLL.GetAll(2).Count);
        }

        [TestMethod]
        public void Remove()
        {
            WishlistTestDAL wishlistDAL = new WishlistTestDAL();
            WishlistBLL wishlistBLL = new WishlistBLL(wishlistDAL);

            wishlistBLL.Remove(1);

            Assert.AreEqual(2, wishlistDAL.Wishlist.Count);
        }
    }
}

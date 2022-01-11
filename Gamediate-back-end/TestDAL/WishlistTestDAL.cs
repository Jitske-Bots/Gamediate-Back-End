using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gamediate_back_end.DAL;
using Gamediate_back_end.Models;


namespace Gamediate_back_end.TestDAL
{
    public class WishlistTestDAL : IWishlist
    {
        public List<WishlistItem> Wishlist { get; private set; }

        public WishlistTestDAL()
        {
            this.Wishlist = new List<WishlistItem>();
            this.AddMockData();
        }

        public WishlistItem Add(WishlistItem wishlistItem)
        {
            this.Wishlist.Add(wishlistItem);
            return wishlistItem;
        }

        public List<WishlistItem> GetAll(int accountID)
        {
            List<WishlistItem> accountItems = new List<WishlistItem>();
            foreach(WishlistItem item in this.Wishlist)
            {
                if(item.AccountID == accountID)
                {
                    accountItems.Add(item);
                }
            }
            return accountItems;
        }

        public bool Remove(int id)
        {
            foreach(WishlistItem item in this.Wishlist)
            {
                if(item.ID == id)
                {
                    this.Wishlist.Remove(item);
                    return true;
                }
            }
            return false;
        }

        private void AddMockData()
        {
            WishlistItem item1 = new WishlistItem
            {
                ID = 1,
                AccountID = 1,
                GameID = 1,
            };
            WishlistItem item2 = new WishlistItem
            {
                ID = 2,
                AccountID = 1,
                GameID = 2,
            };
            WishlistItem item3 = new WishlistItem
            {
                ID = 3,
                AccountID = 2,
                GameID = 1,
            };
            this.Wishlist.Add(item1);
            this.Wishlist.Add(item2);
            this.Wishlist.Add(item3);
        }
    }
}

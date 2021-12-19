using Gamediate_back_end.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gamediate_back_end.DAL
{
    public class WishlistDAL : IWishlist
    {
        private readonly GameContext wishlistContext;
        public WishlistDAL(GameContext wishlistContext)
        {
            this.wishlistContext = wishlistContext;
        }
        public WishlistItem Add(WishlistItem wishlistItem)
        {
            this.wishlistContext.WishlistItems.Add(wishlistItem);
            wishlistContext.SaveChanges();
            return wishlistItem;
        }

        public List<WishlistItem> GetAll(int accountID)
        {
            List<WishlistItem> wishlistItems = new List<WishlistItem>();
            foreach(WishlistItem item in wishlistContext.WishlistItems)
            {
                if(item.AccountID == accountID)
                {
                    wishlistItems.Add(item);
                }
            }
            return wishlistItems;
        }

        public bool Remove(int id)
        {
            bool removed = false;
            foreach(WishlistItem item in wishlistContext.WishlistItems)
            {
                if(item.ID == id)
                {
                    wishlistContext.WishlistItems.Remove(item);
                    removed = true;
                    break;
                }
            }
            wishlistContext.SaveChanges();
            return removed;
        }
    }
}

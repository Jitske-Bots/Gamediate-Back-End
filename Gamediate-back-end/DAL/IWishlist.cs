using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gamediate_back_end.Models;

namespace Gamediate_back_end.DAL
{
    public interface IWishlist
    {
        public WishlistItem Add(WishlistItem wishlistItem);
        public List<WishlistItem> GetAll(int accountID);
        public bool Remove(int id);

    }
}

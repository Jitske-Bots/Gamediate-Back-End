﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gamediate_back_end.Models;
using Gamediate_back_end.DAL;

namespace Gamediate_back_end.BLL
{
    public class WishlistBLL
    {
        private readonly IWishlist iWishlist;
        public WishlistBLL(IWishlist iWishlist)
        {
            this.iWishlist = iWishlist;
        }
    }
}

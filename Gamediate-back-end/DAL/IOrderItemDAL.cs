using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gamediate_back_end.DTOS;
using Gamediate_back_end.Models;

namespace Gamediate_back_end.DAL
{
    public interface IOrderItemDAL
    {
        IEnumerable<OrderItem> GetAll(int orderID);
        void Add(OrderItem orderItemDTO);
    }
}

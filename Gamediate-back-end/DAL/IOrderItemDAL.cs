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
        public IEnumerable<OrderItem> GetAll(int orderID);
        public void Add(OrderItem orderItemDTO);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gamediate_back_end.DTOS;

namespace Gamediate_back_end.DAL
{
    public interface IOrderItemDAL
    {
        IEnumerable<OrderItemDTO> GetAll();
        void Add(OrderItemDTO orderItemDTO);
    }
}

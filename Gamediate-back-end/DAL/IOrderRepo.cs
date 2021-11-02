using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gamediate_back_end.DTOS;

namespace Gamediate_back_end.DAL
{
    public interface IOrderRepo
    {
        IEnumerable<OrderDTO> GetAll();
        void Add(OrderDTO orderDTO);
        
    }
}

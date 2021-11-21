using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gamediate_back_end.DTOS;
using Gamediate_back_end.Models;
namespace Gamediate_back_end.DAL
{
    public interface IOrderDAL
    {
        IEnumerable<Order> GetAll(int accountID);
        int Add(Order order);
        
    }
}

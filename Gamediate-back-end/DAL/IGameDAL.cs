using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gamediate_back_end.Models;

namespace Gamediate_back_end.DAL
{
    public interface IGameDAL
    {
        public IEnumerable<Game> GetAll();
    }
}

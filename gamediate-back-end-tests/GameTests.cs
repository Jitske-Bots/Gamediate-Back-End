using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Gamediate_back_end.DAL;
using Gamediate_back_end.Models;
using Gamediate_back_end.BLL;
using Gamediate_back_end.TestDAL;

namespace gamediate_back_end_tests
{
    [TestClass]
    public class GameTests
    {
        [TestMethod]
        public void GetGames()
        {
            GameTestDAL gameDAL = new GameTestDAL();
            GameBLL gameBLL = new GameBLL(gameDAL);

            Assert.AreEqual(3, gameBLL.GetAll().Count());

        }
    }
}

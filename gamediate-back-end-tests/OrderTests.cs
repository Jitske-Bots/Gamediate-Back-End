using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Gamediate_back_end.DAL;
using Gamediate_back_end.Models;
using Gamediate_back_end.BLL;
using Gamediate_back_end.TestDAL;
using System.Linq;

namespace gamediate_back_end_tests
{
    [TestClass]
    public class OrderTests
    {
        [TestMethod]
        public void AddOrder()
        {
            OrderTestDAL orderDAL = new OrderTestDAL();
            OrderBLL orderBLL = new OrderBLL(orderDAL);

            Order order1 = new Order(1, DateTime.Now, 100);
            Order order2 = new Order(1, DateTime.Now, 200);

            orderBLL.Add(order1);
            orderBLL.Add(order2);

            Assert.AreEqual(2, orderDAL.Orders.Count);

        }
        [TestMethod]
        public void GetOrders()
        {
            OrderTestDAL orderDAL = new OrderTestDAL();
            OrderBLL orderBLL = new OrderBLL(orderDAL);

            Order order1 = new Order(1, DateTime.Now, 100);
            Order order2 = new Order(1, DateTime.Now, 200);
            Order order3 = new Order(2, DateTime.Now, 200);
            Order order4 = new Order(1, DateTime.Now, 200);

            orderBLL.Add(order1);
            orderBLL.Add(order2);
            orderBLL.Add(order3);
            orderBLL.Add(order4);

            int count = orderBLL.GetAll(1).ToList().Count;
            Assert.AreEqual(3, count);
        }

        [TestMethod]
        public void AddOrderItems()
        {
            OrderTestDAL orderDAL = new OrderTestDAL();
            OrderBLL orderBLL = new OrderBLL(orderDAL);

            OrderItemTestDAL orderItemDAL = new OrderItemTestDAL();
            OrderItemBLL orderItemBLL = new OrderItemBLL(orderItemDAL);

            Order order1 = new Order(1, DateTime.Now, 100);

            OrderItem orderItem1 = new OrderItem();
            int id = orderBLL.Add(order1);
            orderItem1.OrderID = id;
            orderItem1.GameID = 1;
            orderItem1.Price = 20;

            int orderitemOrderID = orderItem1.OrderID;

            orderItemBLL.Add(orderItem1);

            Assert.AreEqual(orderitemOrderID, id);

        }
    }
}

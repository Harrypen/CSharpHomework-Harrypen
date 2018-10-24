using Microsoft.VisualStudio.TestTools.UnitTesting;
using program1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        OrderService os = new OrderService();
        
        [TestMethod()]
        public void AddOrderTest()
        {
            Order order = new Order();
            order.Client = "潘浩宇";
            os.AddOrder(order);
        }

        [TestMethod()]
        public void DeleteByIdTest()
        {
            os.DeleteById(1);
        }

        [TestMethod()]
        public void DeleteByCliendTest()
        {
            os.DeleteByCliend("1");
        }

        [TestMethod()]
        public void FindByNameTest()
        {
            os.FindByName("1");
        }

        [TestMethod()]
        public void FindByIDTest()
        {
            os.FindByID(1);
        }

        [TestMethod()]
        public void FindByTotalTest()
        {
            os.FindByTotal(10000);
        }

        [TestMethod()]
        public void ShowForUserTest()
        {
            Order order = new Order();
            order.Client = "潘浩宇";
            os.AddOrder(order);
            os.ShowForUser();
        }

        [TestMethod()]
        public void ExportTest()
        {
            os.Export();
        }

        [TestMethod()]
        public void ImportTest()
        {
            os.Import();
        }
    }
}
using System;
using System.Collections.Generic;

namespace program2
{
    internal class OrderService
    {
        private List<OrderDetails> MyOreder = new List<OrderDetails>();

        //（订单明细，编号，名称，数量，价格，客户）
        public static void Add(List<OrderDetails> a, int b, string c, int d, float e, string f) //（订单明细，编号，名称，数量，价格，客户）
        {
            var NewOrderDetails = new OrderDetails();
            NewOrderDetails.CommodityID = b;
            NewOrderDetails.CommodityName = c;
            NewOrderDetails.CommodityNumber = d;
            NewOrderDetails.CommodityPrice = e;
            NewOrderDetails.Client = f;
            a.Add(NewOrderDetails);
        }

        public static void Delete(List<OrderDetails> a, int b, string c, int d, float e, string f) //编号删除
        {
            if (a.Count == 0 || a.FindAll(s =>
                    s.CommodityID == b && s.Client == c && s.CommodityName == f && s.CommodityNumber == d &&
                    s.CommodityPrice == e) == null)
                throw new Exception("没有此明细");
            a.RemoveAll(s =>
                s.CommodityID == b && s.Client == c && s.CommodityName == f && s.CommodityNumber == d &&
                s.CommodityPrice == e);
            var DeleteOrderDetails = a;
            foreach (var O in DeleteOrderDetails)
                Console.WriteLine(O.CommodityID + " " + O.CommodityName + " " + O.CommodityNumber + " " +
                                  O.CommodityPrice + " " + O.Client);
        }

        public static void Search(List<OrderDetails> a, int b, string c, int d, float e, string f) //编号查询
        {
            if (a.Count == 0 || a.FindAll(s =>
                    s.CommodityID == b && s.Client == c && s.CommodityName == f && s.CommodityNumber == d &&
                    s.CommodityPrice == e) == null)
                throw new Exception("没有此明细");
            var FindOrderDetails = a.FindAll(s =>
                s.CommodityID == b && s.Client == c && s.CommodityName == f && s.CommodityNumber == d &&
                s.CommodityPrice == e);
            foreach (var O in FindOrderDetails)
                Console.WriteLine(O.CommodityID + " " + O.CommodityName + " " + O.CommodityNumber + " " +
                                  O.CommodityPrice + " " + O.Client);
        }
    }
}
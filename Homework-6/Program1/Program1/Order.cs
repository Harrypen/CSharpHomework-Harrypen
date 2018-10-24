using System;
using System.Collections.Generic;
using System.Linq;

namespace program1
{
    public class Order
    {
        public List<OrderDetails> MyOreder = new List<OrderDetails>();

        //订单的编号
        public int OrderId { set; get; }

        //该订单的客户
        public string Client { set; get; }

        //订单金额
        private float sum { set; get; }

        public float Sum()
        {
            foreach (var A in MyOreder) sum += A.TotalPrice;
            return sum;
        }

        //添加明细
        public void AddDetails(OrderDetails od) //（订单明细，编号，名称，数量，价格，客户）
        {
            MyOreder.Add(od);
        }

        //按商品的编号删除该明细
        public void DelectByName(string name)
        {
            var A = MyOreder.Where(a => a.good.Id == name).Select(a => a);
            foreach (var B in A) MyOreder.Remove(B);
        }

        //按商品的名称查询该明细
        public void FindByName(string name)
        {
            var A = MyOreder.Where(a => a.good.Id == name).Select(a => a);
            foreach (var B in A)
                Console.WriteLine(
                    $" {B.DetailsNumber}.  \n" +
                    $"商品编号：{B.good.Id}  \n" +
                    $"名称：{B.good.Name}  \n" +
                    $"单价：{B.good.Price}  \n" +
                    $"数量：{B.CommodityNumber}  \n" +
                    $"价格：{B.TotalPrice}");
        }
    }
}
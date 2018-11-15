using System;
using System.Collections.Generic;
using System.Linq;

namespace program1
{
    public class Order
    {
        public List<OrderDetails> MyOrder = new List<OrderDetails>();

        //订单的编号
        public int OrderId { set; get; }

        //该订单的客户
        public string Client { set; get; }

        //订单金额
        public float sum
        {
            set;
            get;
        }

        public float Sum()
        {
            foreach (var A in MyOrder)
            {
                sum += A.TotalPrice;
            }
            return sum;
        }

        //客户电话
        private string str_tel;
        public string Tel
        {
            set
            {
               if (System.Text.RegularExpressions.Regex.IsMatch(value, @"^[1]+[3,4,5,8]+\d{9}"))
                    str_tel = value;
            }
            get { return str_tel; }
            
        }

        //添加明细
        public void AddDetails(OrderDetails od) //（订单明细，编号，名称，数量，价格，客户）
        {
            MyOrder.Add(od);
        }

        //按商品的编号删除该明细
        public void DelectByName(string name)
        {
            var A = MyOrder.Where(a => a.Good.Id == name).Select(a => a);
            foreach (var B in A) MyOrder.Remove(B);
        }

        //按商品的名称查询该明细
        public void FindByName(string name)
        {
            var A = MyOrder.Where(a => a.Good.Id == name).Select(a => a);
            foreach (var B in A)
                Console.WriteLine(
                    $" {B.DetailsNumber}.  \n" +
                    $"商品编号：{B.Good.Id}  \n" +
                    $"名称：{B.Good.Name}  \n" +
                    $"单价：{B.Good.Price}  \n" +
                    $"数量：{B.CommodityNumber}  \n" +
                    $"价格：{B.TotalPrice}");
        }
    }
}
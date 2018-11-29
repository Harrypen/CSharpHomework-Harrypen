using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem
{
    public class Order
    {
        static OrderService service = new OrderService();
        public static int CountOr = service.CountRow("order");
        public Order()
        {
            details = new List<OrderDetails>();
            Customer Customer0 = new Customer();
            CountOr++;
            this.Id = 1;
            this.OrderId = DateTime.Now.Year + "" + DateTime.Now.Month + DateTime.Now.Day + CountOr.ToString().PadLeft(3, '0'); ;
            this.Customer = Customer0.CustomerName;
        }

        public Order(string customerName)
        {
            CountOr++;
            this.OrderId =DateTime.Now.Year + "" + DateTime.Now.Month + DateTime.Now.Day + CountOr.ToString().PadLeft(3, '0'); ;
            details = new List<OrderDetails>();
            this.Id = 1;
            Customer Customer0 = new Customer(customerName);
            this.Customer = Customer0.CustomerName;
        }
        [Key]
        public int Id { get; set; }            //主键
        public string OrderId { set; get; }             //订单号
        public string Phone { set; get; }               //电话
        public string Customer { set; get; }          //客户
        public float ToTal {  get => details.Sum(a=>a.GoodNum*a.Good.Price); }                //总金额
        public List<OrderDetails> details { set; get; } //订单明细集合

        //添加明细
        public void AddDetail(Good good,int goodNum)
        {
            OrderDetails orderDetail = new OrderDetails((details.Count()+1).ToString(),good, goodNum);
            details.Add(orderDetail);
        }
       
        //删除明细
        public void DeleteDetail(OrderDetails deletedetail)
        {
            details.Remove(deletedetail);
        }
    }
}

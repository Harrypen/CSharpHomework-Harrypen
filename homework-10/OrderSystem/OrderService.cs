using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem
{
    public class OrderService
    {
      //添加
        public void Add(Order order) {
            using (var db= new OrderDB())
            {
                db.Order.Add(order);
                db.SaveChanges();
            }
           
        }
        //删除
        public void Delete(int KeyId) {
            using (var db = new OrderDB())
            {
                db.OrderDetail.Include("Good").ToList<OrderDetails>();
                var order = db.Order.Include("details").SingleOrDefault(o => o.Id==KeyId);            
                foreach (var good in order.details)
                {
                    db.Good.Remove(good.Good);
                }
                
                db.OrderDetail.RemoveRange(order.details);
                db.Order.Remove(order);
                db.SaveChanges();
            }
        }
        //修改
        public void Update(Order order) {
            using (var db = new OrderDB())
            {
                db.Order.Attach(order);
                db.Entry(order).State = EntityState.Modified;
                order.details.ForEach(
                    item => db.Entry(item).State = EntityState.Modified);
                db.SaveChanges();
            }
        }
        //订单号查询
        public Order GetOrder(string orderId) {
            using (var db = new OrderDB())
            {
                return db.Order.Include("details").
                  SingleOrDefault(o => o.OrderId== orderId);
            }
        }
        //显示所有订单
        public List<Order> GetAllOrders()
        {
            using (var db = new OrderDB())
            {           
                db.OrderDetail.Include("Good").ToList<OrderDetails>();
              
                return db.Order.Include("details").ToList<Order>();
            }
        }
        //客户查询
        public List<Order> ShowByCustormer(String custormer)
        {
            using (var db = new OrderDB())
            {
                return db.Order.Include("details")
                  .Where(o => o.Customer.Equals(custormer)).ToList<Order>();
            }
        }
        //商品查询
        public List<Order> ShowByGoods(string product)
        {
            using (var db = new OrderDB())
            {
                var query = db.Order.Include("details")
                  .Where(o => o.details.Where(
                    item => item.Good.GoodName.Equals(product)).Count() > 0);
                return query.ToList<Order>();
            }
        }
        //金额小于Sum
        public List<Order> ShowBySum0(string sum)
        {
            using (var db = new OrderDB())
            {
                var query = db.Order.Include("details")
                  .Where(o => o.ToTal<Convert.ToSingle(sum));
                return query.ToList<Order>();
            }
        }
        //金额大于等于Sum
        public List<Order> ShowBySum1(string sum)
        {
            using (var db = new OrderDB())
            {
                var query = db.Order.Include("details")
                  .Where(o => o.ToTal >= Convert.ToSingle(sum));
                return query.ToList<Order>();
            }
        }
        //行数
        public int CountRow(string order)
        {
            if(order.Equals("details"))
            using (var db = new OrderDB())
            {
                return db.OrderDetail.ToList<OrderDetails>().Count();
            }
            else
            using (var db = new OrderDB())
            {
                return db.Order.ToList<Order>().Count();
            }

        }
    }
}

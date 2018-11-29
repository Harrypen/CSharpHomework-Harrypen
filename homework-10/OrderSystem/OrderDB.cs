using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem
{
    public class OrderDB: DbContext
    {    
        public OrderDB() : base("ODB") { }
        public DbSet<Order> Order { set; get; }
        public DbSet<OrderDetails> OrderDetail { set; get; }
        public DbSet<Good> Good { set; get; }  
        
    }
}

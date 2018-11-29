using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem
{
    public class Customer
    {
        public Customer() { }
        public Customer(string name)
        {       
            this.CustomerName = name;
        }

        public int Id { set; get; }     
        public string CustomerName { set; get; } //客户名
        public override string ToString()
        {         
            return CustomerName;
        }
    }
}

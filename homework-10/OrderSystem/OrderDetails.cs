using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem
{
    public class OrderDetails
    {
        public OrderDetails() {
           
                }
        public OrderDetails(string id,Good good,int num)
        {
            this.KeyId = 1;       
            this.Id = id;
            this.GoodNum = num;
            this.Good = good;     
        }
        [Key]
        public int KeyId { set; get; }
        public string Id { set; get; }      //明细序号 
        public int GoodNum { set; get; }    //商品数量
        public Good Good {  set; get; }      //商品

    }
}

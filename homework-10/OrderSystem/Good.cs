using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem
{
    public class Good
    {      public Good() { }
        public Good(string name)
        {
            KeyId = 1;
            switch (name){
                case "香蕉":                   
                    GoodName = "香蕉";
                    Price = 3;
                    break;
                case "苹果":                 
                    GoodName = "苹果";
                    Price = 4;
                    break;
                case "酸奶":                  
                    GoodName = "酸奶";
                    Price = 5;
                    break;
            }
        }
        [Key]
        public int KeyId { set; get; }      //主键
        public string GoodName { set; get; }    //商品名
        public float Price { set; get; }        //单价      
        public override string ToString()
        {
            return $"商品:{GoodName}, 单价:{Price}";
        }
    }
}

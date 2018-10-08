using System.Collections.Generic;

namespace program2
{
    internal class Order
    {
        public List<OrderDetails> MyOreder;

        public Order()
        {
            MyOreder = new List<OrderDetails>();
        }

        public string ItemNumber { set; get; }
    }
}
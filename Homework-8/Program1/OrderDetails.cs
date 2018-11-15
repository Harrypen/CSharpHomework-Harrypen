namespace program1
{
    public class OrderDetails //订单明细/条目
    {
        public OrderDetails(Goods goods, int number)
        {
            CommodityNumber = number;
            Good = goods;
            goodName = goods.Name;
            TotalPrice = Good.Price * CommodityNumber;
        }

        public OrderDetails()
        {

        }

        public Goods Good { set; get; }
        public string goodName { set; get; }//商品名
        public int DetailsNumber { set; get; } //明细序号      
        public float TotalPrice { set; get; } //商品总价格
        public int CommodityNumber { set; get; } //商品数量(外部传入)            
    }
}
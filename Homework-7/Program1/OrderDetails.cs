namespace program1
{
    public class OrderDetails //订单明细/条目
    {
        public OrderDetails(Goods goods, int number)
        {
            CommodityNumber = number;
            good = goods;
            TotalPrice = good.Price * CommodityNumber;
        }

        public OrderDetails()
        {

        }

        public Goods good { set; get; }
        public int DetailsNumber { set; get; } //明细序号      
        public float TotalPrice { set; get; } //商品总价格
        public int CommodityNumber { set; get; } //商品数量(外部传入)            
    }
}
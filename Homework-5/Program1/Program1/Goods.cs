using System;

namespace program1
{
    internal class Goods
    {
        public Goods(string goods)
        {
            if (goods.Equals("water"))
            {
                Id = "2018101701";
                Price = 0.5f;
                Name = goods;
            }
            else if (goods.Equals("bread"))
            {
                Id = "2018101702";
                Price = 1.0f;
                Name = goods;
            }
            else if (goods.Equals("book"))
            {
                Id = "2018101703";
                Price = 3.0f;
                Name = goods;
            }
            else
            {
                throw new Exception("没有此商品");
            }
        }

        public string Id { get; }

        public float Price { get; }

        public string Name { get; }
    }
}
using System;

namespace program2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var a = new Order();
            int Id, Price, Number;
            string Name, Client;

            var T = true;

            while (T)
                try
                {
                    Console.WriteLine("\n请选择您要功能：\n1.添加订单   2.删除订单   3.查询    4.完成操作 \n    其他键退出\n");
                    var select = Convert.ToInt32(Console.ReadLine());
                    if (select == 1)
                    {
                        Console.WriteLine("1.添加订单：");
                        Console.WriteLine("编号：");
                        Id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("名称：");
                        Name = Console.ReadLine();
                        Console.WriteLine("数量：");
                        Price = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("价格：");
                        Number = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("客户：");
                        Client = Console.ReadLine();
                        OrderService.Add(a.MyOreder, Id, Name, Number, Price, Client);
                    }
                    else if (select == 2)
                    {
                        Console.WriteLine("2.删除订单：");
                        Console.WriteLine("编号：");
                        Id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("名称：");
                        Name = Console.ReadLine();
                        Console.WriteLine("数量：");
                        Price = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("价格：");
                        Number = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("客户：");
                        Client = Console.ReadLine();
                        OrderService.Delete(a.MyOreder, Id, Name, Number, Price, Client);
                    }
                    else if (select == 3)
                    {
                        Console.WriteLine("3.查询：");
                        Console.WriteLine("编号：");
                        Id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("名称：");
                        Name = Console.ReadLine();
                        Console.WriteLine("数量：");
                        Price = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("价格：");
                        Number = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("客户：");
                        Client = Console.ReadLine();
                        OrderService.Search(a.MyOreder, Id, Name, Number, Price, Client);
                    }
                    else if (select == 4)
                    {
                        T = false;
                    }
                    else
                    {
                        Console.WriteLine("谢谢使用！");
                        Console.ReadKey();
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("请正确输入！");
                }
        }
    }
}
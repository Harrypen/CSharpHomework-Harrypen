using System;

namespace program1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string Name;

            var T = true;
            int index = 0, Number = 0;
            var os = new OrderService();
            while (T)
                try
                {
                    Console.WriteLine(
                        " |  商品目录: water bread book  | \n\n" +
                        " ========= 请选择功能 =========\n" +
                        " |      1.添加订单            |\n" +
                        " |      2.删除订单            |\n" +
                        " |      3.查询订单            |\n" +
                        " |      4.显示订单            |\n" +
                        " ========= 数字0退出 ==========\n");

                    var select = Convert.ToInt32(Console.ReadLine());
                    if (select == 1)
                    {
                        index++;
                        //创建订单
                        var order1 = new Order();
                        order1.OrderId = index;
                        Console.Write("\n************订单***********\n" +
                                      "\n客户名: ");
                        order1.Client = Console.ReadLine();
                        //添加明细
                        var index1 = 0;
                        tag: Console.WriteLine("\n ------------- \n" +
                                          "  1.添加明细 \n" +
                                          "  2.完成订单 \n" +
                                          " -------------\n");
                        var select1 = Convert.ToInt32(Console.ReadLine());
                        if (select1 == 1)
                        {
                            index1++;
                            Console.WriteLine("\n----订单明细----\n" +
                                              "客户名: " + order1.Client);
                            Console.Write("商品名：");
                            Name = Console.ReadLine();
                            var goods = new Goods(Name);
                            Console.Write("商品数：");
                            Number = Convert.ToInt32(Console.ReadLine());
                            var orderDetails = new OrderDetails(goods, Number);
                            orderDetails.DetailsNumber = index1;
                            order1.AddDetails(orderDetails);
                            Console.WriteLine("----订单完成----\n");
                            goto tag;
                        }
                        else if (select1 == 2)
                        {
                            Console.WriteLine("\n************完成***********\n");
                        }
                        else
                        {
                            goto tag;
                        }
                        //通过OrderService加入OrderList
                        os.AddOrder(order1);
                    }
                    else if (select == 2)
                    {
                        Console.WriteLine(
                            "\n***********删除订单*********\n" +
                            " ----------------------\n" +
                            " | 1.按客户名删除订单 |\n" +
                            " | 2.按订单号删除订单 |\n" +
                            " |     其他键返回     |\n" +
                            " ----------------------\n");
                        var sd = Convert.ToInt32(Console.ReadLine());
                        if (sd == 1)
                        {
                            Console.WriteLine("\n----1.按客户名删除订单----");
                            Console.Write("需要删除掉订单的客户：");
                            var client = Console.ReadLine();
                            os.DeleteByCliend(client);
                            Console.WriteLine("\n************完成***********\n");
                        }
                        else if (sd == 2)
                        {
                            Console.WriteLine("\n----2.按订单号删除订单----");
                            Console.Write("需要删除掉订单的订单号：");
                            var client = Convert.ToInt32(Console.ReadLine());
                            os.DeleteById(client);
                            Console.WriteLine("\n************完成***********\n");
                        }
                    }
                    else if (select == 3)
                    {
                        Console.WriteLine(
                            "\n***********查询订单*********\n" +
                            " ----------------------------\n" +
                            " | 1.按客户名查询订单       |\n" +
                            " | 2.按订单号查询订单       |\n" +
                            " | 3.查询小于指定金额的订单 |\n" +
                            " |     其他键返回           |\n" +
                            " ----------------------------\n");
                    
                        var sd = Convert.ToInt32(Console.ReadLine());
                        if (sd == 1)
                        {
                            Console.WriteLine("\n----1.按客户名查询订单----");
                            Console.Write("需要查询订单的客户：");
                            var client = Console.ReadLine();
                            os.FindByName(client);
                            Console.WriteLine("\n************完成***********\n");
                        }
                        else if (sd == 2)
                        {
                            Console.WriteLine("\n----2.按订单号查询订单----");
                            Console.Write("需要查询订单的订单号：");
                            var client = Convert.ToInt32(Console.ReadLine());
                            os.FindByID(client);
                            Console.WriteLine("************完成***********\n");
                        }
                        else if (sd == 3)
                        {
                            Console.WriteLine("\n----3.查询小于指定金额的订单----");
                            Console.Write("输入您的金额：");
                            var client = Convert.ToDouble(Console.ReadLine());
                            os.FindByTotal(client);
                            Console.WriteLine("\n************完成***********\n");
                        }
                    }
                    else if (select == 4)
                    {
                        os.ShowForUser();
                        Console.WriteLine("\n************完成***********\n  ");
                    }
                    else
                    {
                        Console.WriteLine("\n***** 谢谢使用! *****");
                        Console.ReadKey();
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("\n******请正确输入！******\n");
                }
        }
    }
}
using System;

namespace CommandMUL
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入两个整数");

            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("乘积为:"+num1*num2);
            Console.ReadKey();
        }
    }
}

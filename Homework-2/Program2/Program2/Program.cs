using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[5] {1, 2, 3, 4, 5};
            int sum = 0, average, max = num[0], min = num[0];
            for (int i = 0; i < num.Length; i++)
            {
                max = num[i] > max ? num[i] : max;
                min = num[i] < min ? num[i] : min;
                sum += num[i];
            }
            average = sum / num.Length;
            Console.WriteLine("最大值: " + max);
            Console.WriteLine("最小值: " + min);
            Console.WriteLine("平均值: " + average);
            Console.WriteLine("和值: " + sum);
            Console.ReadKey();
        }
    }
}

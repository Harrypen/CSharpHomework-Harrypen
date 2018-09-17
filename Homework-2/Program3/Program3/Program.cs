using System;

namespace Program3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            IsPrime(n);
            Console.ReadKey();
        }

        private static void IsPrime(int n)
        {
            bool[] mark = new bool[n + 1];

            for (int i = 2; i <= n; i++)
            {
                mark[i] = true;
            }

            for (int i = 2; i <= (int) Math.Sqrt(n); i++)
            {
                if (mark[i] == true)
                {
                    for (int j = i; j * i <= n; j++)
                    {
                        mark[i * j] = false;
                    }
                }
            }

            for (int i = 2; i <= n; i++)
            {
                if (mark[i] == true)
                {
                   Console.Write(i + " ");
                }
            }
        }
    }
}

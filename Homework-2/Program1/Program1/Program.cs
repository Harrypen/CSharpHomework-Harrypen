using System;

namespace Program1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write("素数因子: ");
            for (int i = 2; i <= num; i++)
            {
                if (num % i == 0)
                {
                    if (IsPrime(i)) Console.Write(i + " ");
                }
            }
            Console.ReadKey();
        }

       private static bool IsPrime(int num)
        {
            if (num == 2 || num == 3) return true;
            if (num % 6 != 1 && num % 6 != 5) return false;
            int numSqrt = (int)Math.Sqrt(num);
            for (int i = 5; i <= numSqrt; i += 6)
            {
                if (num % (i) == 0 | num % (i + 2) == 0) return false;
            }
            return true;

        }
    }
}

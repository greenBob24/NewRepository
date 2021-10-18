using System;

namespace sumOfPrimes
{
    class Program
    {
        static void Main(string[] args)
        {
            long sum = 5;
            bool err ;
            for (int i = 5; i <= 200000; i=i+2)
            {
                err = false;
                for (int m = 2; m < i; m++)
                {
                    if (i % m == 0)
                    {
                        err = true;
                        break;
                    }
                }
                if (err == false)
                    sum = sum + i;
            }
            Console.WriteLine("Сумма {0}", sum);
        }
    }
}

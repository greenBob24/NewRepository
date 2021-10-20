using System;
using System.Diagnostics;
using System.Threading;
using System.Collections.Generic;

namespace sumOfPrimes
{
    class Program
    {
        static void Main(string[] args)
        {   // Сумма простых чисел меньше 10 равна 2 + 3 + 5 + 7 = 17.Найдите сумму всех простых чисел меньше двух миллионов.
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            List<long> numbers = new List<long>();
            long sum = 17;
            bool err = false;
            for (int i = 11; i < 2000000; i = i + 10)
            {
                numbers.Add(i);
            }
            for (int i = 13; i < 2000000; i = i + 10)
            {
                numbers.Add(i);
            }
            for (int i = 17; i < 2000000; i = i + 10)
            {
                numbers.Add(i);
            }
            for (int i = 19; i < 2000000; i = i + 10)
            {
                numbers.Add(i);
            }

            foreach (int elem in numbers)
            {
                err = false;
                for (int m = 3; m <= Convert.ToInt32(Math.Sqrt(elem)); m = m + 2)
                {
                    if (elem % m == 0)
                    {
                        err = true;
                        break;
                    }
                }
                if (err == false)
                {
                    sum = sum + elem;
                }
            }
            Console.WriteLine(sum);
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;

            // Format and display the TimeSpan value.
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
ts.Hours, ts.Minutes, ts.Seconds,
ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);
        }
    }
}

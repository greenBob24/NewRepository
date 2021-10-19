using System;
using System.Diagnostics;
using System.Threading;

namespace sumOfPrimes
{
    class Program
    {
        static void Main(string[] args)
        {   // сумма простых чисел до 20000000
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            long sum = 5;
            bool err ;
            for (int i = 5; i <= 2000000; i=i+2)
            {
                err = false;//g45g5g
                for (int m = 3; m < i; m=m+2)
                {
                    if (i % m == 0)
                    {   //t5by5b
                        err = true;
                        break;
                    }
                }
                if (err == false)
                    sum = sum + i;

            }
            Console.WriteLine(sum);
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;

            // Format and display the TimeSpan value.
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);//rfrwf
        }
    }
}

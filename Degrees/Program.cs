using System;

namespace Degrees
{
    class Program
    {
        /* Удивительно, но существует только три числа, которые могут быть записаны в виде суммы четвертых степеней их цифр:

         1634 = 14 + 64 + 34 + 44
         8208 = 84 + 24 + 04 + 84
         9474 = 94 + 44 + 74 + 44
         1 = 14 не считается, так как это - не сумма.

         Сумма этих чисел равна 1634 + 8208 + 9474 = 19316.

         Найдите сумму всех чисел, которые могут быть записаны в виде суммы пятых степеней их цифр.*/


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] numbers = new int[90000];
            int sum = 0;
            for (int i = 0; i < 90000; i++)
            {
                numbers[i] = i + 10000;
            }
            foreach (int elem in numbers)
            {
                string str = elem.ToString();
                int first = Convert.ToInt32(str.Substring(0, 1));
                int second = Convert.ToInt32(str.Substring(1, 1));
                int third = Convert.ToInt32(str.Substring(2, 1));
                int fourth = Convert.ToInt32(str.Substring(3, 1));
                int fifth = Convert.ToInt32(str.Substring(4, 1));

                if ((Math.Pow(first, 5)) +
                    (Math.Pow(second, 5)) +
                    (Math.Pow(third, 5)) + (Math.Pow(fourth, 5)) + (Math.Pow(fifth, 5)) == elem)
                {
                    sum = sum + elem;
                    Console.WriteLine($"элемент: {elem}");
                }

            }

            Console.WriteLine($"сумма:{sum}");
        }
    }
}

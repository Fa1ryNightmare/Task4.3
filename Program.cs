using System;

namespace Task4_3
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите точность: ");
            double eps = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите X: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double aPrev = 0;
            double a = 0;
            double n = 0;
            while(Math.Abs(aPrev - a) < eps)
            {
                aPrev = 3 + (1 / Math.Pow(2, n)) * Math.Pow(Math.Cos(aPrev - x), 2);
                n++;
                a = 3 + (1 / Math.Pow(2, n)) * Math.Pow(Math.Cos(aPrev - x), 2);
            }
            Console.WriteLine($"Сумма: {a}");

            Console.ReadKey();
        }
    }
}

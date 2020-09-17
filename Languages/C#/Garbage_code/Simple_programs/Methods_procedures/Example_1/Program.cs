using System;

namespace Example_1
{
    class Program
    {
        // Метод, находящий минимальное число из
        static double Min_number(double x, double y)
        {
            if (x < y) return x;
            else return y;
        }
        
        static void Main(string[] args)
        {
            double a,b;

            Console.Write("Введите a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите b: ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"\nМинимальное из чисел ({a} и {b}) - {Min_number(a,b)}");
        }
    }
}

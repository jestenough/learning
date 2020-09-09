using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y");
            double y = Convert.ToDouble(Console.ReadLine());

            double a = 2 * Math.Sin(x) + 1.0/2.0 * Math.Cos(y);

            Console.WriteLine("Результат: {0:00.###}",a);
            Console.ReadKey();
        }
    }
}

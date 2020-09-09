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
            double pi = Math.PI;

            double f = (2 * Math.Sin(x) * Math.Cos(y)) / (Math.Tan(x-pi));
            
            Console.WriteLine("Результат: {0:00.###}",f);
            Console.ReadKey();
        }
    }
}

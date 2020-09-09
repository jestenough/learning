using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первую сторону треугольника");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите вторую сторону треугольника");
            double b = Convert.ToDouble(Console.ReadLine());

            double P = 2 * (a + b);
            double S = a * b;
            
            Console.WriteLine("\nПериметр прямоугольника = {0:0.###}, Площадь прямоугольника = {1:0.###}",P,S);
            Console.ReadKey();
        }
    }
}

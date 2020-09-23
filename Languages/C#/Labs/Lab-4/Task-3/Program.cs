using System;

namespace Task_3
{
    class Program
    {
        /*
        Описать функцию RectPS(a, b), 
        вычисляющую площадь S прямоугольника со сторонами a, b.
        */

        static double RectPS(double a, double b)
        {
            return a * b;
        }
        static void Main(string[] args)
        {
            double a,b;
            
            Console.WriteLine("Введите стороны прямоугольника");
            Console.Write("a = ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b = ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nПлощадь прямоугольника = {0:0.###}",RectPS(a,b));
        }
    }
}
